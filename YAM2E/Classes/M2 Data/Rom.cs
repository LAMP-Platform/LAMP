using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using LAMP.Classes.M2_Data;
using System.Runtime.Intrinsics.Arm;
using System.CodeDom;
using System.Windows.Forms;

namespace LAMP.Classes;

public class Rom
{
    public int Size => Data.Length;
    /// <summary>
    /// Data of the ROM. Should always be unmodified!
    /// </summary>
    public readonly byte[] Data;

    /// <summary>
    /// Copy of the <see cref="Data"/>, which can be modified and saved with <see cref="SaveROMAsFile(string)"/>.
    /// </summary>
    private byte[] DataCopy;

    public string Filepath;

    public static Dictionary<string, Pointer> OffsetOf => Globals.LoadedProject.WriteOffsets;

    // constructor
    public Rom(string filename)
    {
        Data = File.ReadAllBytes(filename);
        DataCopy = (byte[])Data.Clone();
        Filepath = filename;

        // check title and code
        string title = ReadAscii(0x134, 0x8);

        if (title != "METROID2")
        {
            throw new IOException("File is not a valid Metroid II: Return of Samus ROM.");
        }
    }

    /// <summary>
    /// Compiles all the data from the Editor to a copy of the base <see cref="Rom"/>.
    /// </summary>
    /// <param name="filename"></param>
    public void Compile(string filename)
    {
        //Fresh copy of the Data
        DataCopy = (byte[])Data.Clone();

        //This holds the info on items that should not be compiled as per the users choice
        CompilationItem exceptions = Globals.CompilerExclude;

        #region Screens
        if ((exceptions & CompilationItem.Screens) == 0)
        {
            for (int area = 0; area < 7; area++)
            {
                for (int i = 0; i < 59; i++)
                {
                    Pointer pointer = GetPointerForArea(area) + 0x500 + 0x100 * i;
                    ReplaceBytes(pointer.Offset, Globals.Screens[area][i].Data);
                }
            }
        }
        #endregion

        #region Areas
        if ((exceptions & CompilationItem.Areas) == 0)
        {
            for (int area = 0; area < 7; area++)
            {
                Area a = Globals.Areas[area];
                for (int i = 0; i < 256; i++)
                {
                    Pointer offset = Rom.GetPointerForArea(area);

                    //Screens used
                    int data = a.Screens[i];
                    data *= 0x100;
                    data += 0x4500;
                    Write16(offset.Offset + 2 * i, (ushort)data);

                    //Scroll data
                    data = a.Scrolls[i];
                    Write8(offset.Offset + 0x200 + i, (byte)data);

                    //Transition and Priorities data
                    data = a.Tansitions[i];
                    if (a.Priorities[i]) data |= 0x800;
                    Write16(offset.Offset + 0x300 + 2 * i, (ushort)data);
                }
            }
        }
        #endregion

        #region Objects
        Pointer lastAdd = OffsetOf["ObjectDataLists"];
        if ((exceptions & CompilationItem.Objects) == 0)
        {
            for (int i = 0; i < 256 * 7; i++)
            {
                //Empty object list
                if (Globals.Objects[i].Count == 0)
                {
                    if (Globals.LoadedProject.OptimizeObjectData) Write16(OffsetOf["ObjectPointerTable"] + 2 * i, (ushort)OffsetOf["ObjectDataLists"].bOffset); //Writing pointer to list
                    else
                    {
                        lastAdd += 1;
                        Write16(OffsetOf["ObjectPointerTable"] + 2 * i, (ushort)lastAdd.bOffset);
                        Write8(lastAdd.Offset, 0xFF);
                    }
                }
                else //Objects on screen
                {
                    lastAdd += 1;
                    Write16(OffsetOf["ObjectPointerTable"] + 2 * i, (ushort)lastAdd.bOffset); //Writing pointer to list
                    foreach (Enemy o in Globals.Objects[i])
                    {
                        //Writing Object list consecutively
                        Write8(lastAdd.Offset, o.Number);
                        lastAdd += 1;
                        Write8(lastAdd.Offset, o.Type);
                        lastAdd += 1;
                        Write8(lastAdd.Offset, o.sX);
                        lastAdd += 1;
                        Write8(lastAdd.Offset, o.sY);
                        lastAdd += 1;
                    }
                    Write8(lastAdd.Offset, 0xFF);
                }
            }
            if (lastAdd >= OffsetOf["ObjectDataEnd"]) MessageBox.Show($"The amount of object data is exceeding the reserved space in the ROM!\n\nThe ROM might get corrupted.", "Too many objects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #endregion

        #region Transitions
        if ((exceptions & CompilationItem.Transitions) == 0)
        {
            lastAdd = OffsetOf["TransitionDataLists"];
            lastAdd += 1;
            List<int> offsets = new List<int>(); //List saving written pointers for duplicate tansitions
            for (int i = 0; i < 0x200; i++)
            {
                Transition t = Globals.Transitions[i]; //Transition is empty / ends instantly
                if (t.Data.Count == 1)
                {
                    Write16(OffsetOf["TransitionPointerTable"] + (2 * i), (ushort)OffsetOf["TransitionDataLists"].bOffset); //Writing pointer to list
                    offsets.Add(OffsetOf["TransitionDataLists"].bOffset);
                }
                else if (t.CopyOf != -1) //Transition is a duplicate and the data is already written
                {
                    Write16(OffsetOf["TransitionPointerTable"] + (2 * i), (ushort)offsets[t.CopyOf]); //Writing pointer to list
                    offsets.Add(offsets[t.CopyOf]);
                }
                else //Transition is used and unique
                {
                    Write16(OffsetOf["TransitionPointerTable"] + (2 * i), (ushort)lastAdd.bOffset); //Writing pointer to list
                    offsets.Add(lastAdd.bOffset);
                    //Writing transition
                    ReplaceBytes(lastAdd.Offset, t.Data);
                    lastAdd += t.Data.Count;
                }
            }
            if (lastAdd >= OffsetOf["TransitionDataEnd"]) MessageBox.Show($"The amount of transition data is exceeding the reserved space in the ROM!\n\nThe ROM might get corrupted.", "Too many objects", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        #endregion

        #region Savedata
        if ((exceptions & CompilationItem.Save) == 0) Globals.InitialSaveGame.WriteToROM(this);
        #endregion

        SaveROMAsFile(filename);
    }

    public void SaveROMAsFile(string filepath)
    {
        File.WriteAllBytes(filepath, DataCopy);
    }

    #region read/write

    public byte Read8(int offset)
    {
        foreach (DataChunk c in Globals.DataChunks)
        {
            if (c.DataStart.Offset <= offset && offset < c.DataStart.Offset + c.DataLength) //Read offset lies within a saved data chunk
            {
                //return the value from the data chunk instead of the ROM
                return c.Read8(offset);
            }
        }
        if (offset >= Size) return 0;
        return Data[offset];
    }

    public ushort Read16(int offset)
    {
        byte first = Read8(offset);
        byte second = Read8(offset + 1);
        return (ushort)(first | (second << 8));
    }

    /// <summary>
    /// Returns len amount of ASCII characters, read from the given offset.
    /// </summary>
    //TODO: probably wont return correct ASCII if used with DataChunk
    public string ReadAscii(int offset, int len)
    {
        byte[] text = new byte[len];
        Array.Copy(Data, offset, text, 0, len);
        return Encoding.ASCII.GetString(text);
    }

    public string GetRawDataString(int offset, int length)
    {
        StringBuilder rawData = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            rawData.Append(Read8(offset + i).ToString("X2")).Append(' ');
        }
        return rawData.ToString();
    }

    /// <summary>
    /// Writes 1 byte at the given offset.
    /// </summary>
    public void Write8(int offset, byte val)
    {
        DataCopy[offset] = val;
    }

    /// <summary>
    /// Writes a ushort at the given offset in little endian form.
    /// </summary>
    public void Write16(int offset, ushort val)
    {
        DataCopy[offset] = (byte)val;
        DataCopy[offset + 1] = (byte)(val >> 8);
    }

    /// <summary>
    /// Writes the input array at the offset in ROM.
    /// </summary>
    public void ReplaceBytes(int offset, byte[] values)
    {
        Buffer.BlockCopy(values, 0, DataCopy, offset, values.Length);
    }

    /// <summary>
    /// Writes the input list at the offset in ROM.
    /// </summary>
    public void ReplaceBytes(int offset, List<byte> values)
    {
        ReplaceBytes(offset, values.ToArray());
    }

    /// <summary>
    /// Writes a range of the input array at the offset in ROM.
    /// </summary>
    public void ReplaceBytes(int offset, byte[] values, int start, int end)
    {
        Buffer.BlockCopy(values, start, DataCopy, offset, end - start);
    }

    /// <summary>
    /// Writes a byte from the list for each offset in the list.
    /// </summary>
    public void ReplaceBytes(int[] offsets, byte[] values)
    {
        for (int i = 0; i < values.Length; i++)
            DataCopy[offsets[i]] = values[i];
    }

    /// <summary>
    /// Reads amount bytes from the offset in the ROM and writes them to dstArray
    /// </summary>
    //TODO: Wont work with datachunks
    public void ReadBytes(int offset, byte[] dstArray, int amount)
    {
        Buffer.BlockCopy(Data, offset, dstArray, 0, amount);
    }

    public static Pointer GetPointerForArea(int area)
    {
        if (Globals.LoadedProject == null) return A_BANKS[area];
        return OffsetOf["Areas"] + area * 0x4000;
    }
    #endregion  

    ///CONSTANTS used for Reading
    //Areas
    public static Pointer[] A_BANKS { get; } = { new Pointer(0x24000), new Pointer(0x28000), new Pointer(0x2C000), new Pointer(0x30000), new Pointer(0x34000), new Pointer(0x38000), new Pointer(0x3C000) };

    //object data
    public Pointer ObjectPointerTable { get; } = new Pointer(0x3, 0x42E0); //6 Tables of Pointers to object lists

    //transition data
    public Pointer TransitionPointerTable { get; } = new Pointer(0x5, 0x42E5); //Table of 512 or 0x200 pointers to transition codes

    //Graphics and Solidity
    public Pointer MetatilePointers { get; } = new Pointer(0x8, 0x7F1A);
    public Pointer CollisionPointers { get; } = new Pointer(0x8, 0x7EEA);
    public Pointer SolidityIndices { get; } = new Pointer(0x8, 0x7EFA);
}
