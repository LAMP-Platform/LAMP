using System;
using System.Text;
using System.IO;
using System.Collections.Generic;
using LAMP.Classes;

namespace LAMP.Classes
{
    public class Rom
    {
        public int Size => Data.Length;
        public byte[] Data;

        public string Filepath;

        // constructor
        public Rom(string filename)
        {
            Data = File.ReadAllBytes(filename);
            Filepath = filename;

            // check title and code
            string title = ReadAscii(0x134, 0x8);

            if (title != "METROID2")
            {
                throw new IOException("File is not a valid Metroid II: Return of Samus ROM.");
            }
        }

        public void Compile(string filename)
        {
            File.WriteAllBytes(filename, Data);
        }

        #region read/write

        public byte Read8(int offset)
        {
            return Data[offset];
        }

        public ushort Read16(int offset)
        {
            return (ushort)(Data[offset] | (Data[offset + 1] << 8));
        }

        /// <summary>
        /// Returns len amount of ASCII characters, read from the given offset.
        /// </summary>
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
            Data[offset] = val;
        }

        /// <summary>
        /// Writes 2 bytes at the given offset.
        /// </summary>
        public void Write16(int offset, ushort val)
        {
            Data[offset] = (byte)val;
            Data[offset + 1] = (byte)(val >> 8);
        }

        /// <summary>
        /// Writes the input array at the offset in ROM.
        /// </summary>
        public void ReplaceBytes(int offset, byte[] values)
        {
            Buffer.BlockCopy(values, 0, Data, offset, values.Length);
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
            Buffer.BlockCopy(values, start, Data, offset, end - start);
        }

        /// <summary>
        /// Writes a byte from the list for each offset in the list.
        /// </summary>
        public void ReplaceBytes(int[] offsets, byte[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Data[offsets[i]] = values[i];
        }

        /// <summary>
        /// Reads amount bytes from the offset in the ROM and writes them to dstArray
        /// </summary>
        public void ReadBytes(int offset, byte[] dstArray, int amount)
        {
            Buffer.BlockCopy(Data, offset, dstArray, 0, amount);
        }

        #endregion  

        ///CONSTANTS
        //Areas
        public Pointer[] A_BANKS = { new Pointer(0x24000), new Pointer(0x28000), new Pointer(0x2C000), new Pointer(0x30000), new Pointer(0x34000), new Pointer(0x38000), new Pointer(0x3C000) };

        //object data
        public Pointer ObjectPointerTable = new Pointer(0x3, 0x42E0); //6 Tables of Pointers to object lists
        public Pointer ObjectDataLists = new Pointer(0x3, 0x50E0); //Lists of objects on screen, first entry should always be empty
        public Pointer ObjectDataEnd = new Pointer(0x3, 0x6300); //This is the first byte of new data that should not be overwritten!

        //transition data
        public Pointer TransitionPointerTable = new Pointer(0x5, 0x42E5); //Table of 512 or 0x200 pointers to transition codes
        public Pointer TransitionDataLists = new Pointer(0x5, 0x46E5); //Table of <512 Transitions, first one should stay 0xFF

        //Graphics
        public Pointer MetatilePointers = new Pointer(0x8, 0x7F1A);
    }
}
