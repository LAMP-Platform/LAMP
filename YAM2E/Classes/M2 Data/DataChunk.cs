﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using LAMP.Classes;
using LAMP.Classes.M2_Data;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    /// <summary>
    /// A block of data. In use with a <see cref="Rom"/> it will have reading priority when using <see cref="Rom.Read8(int)"/> and <see cref="Rom.Read16(int)"/>
    /// </summary>
    public class DataChunk
    {
        //Constructors
        [JsonConstructor]
        public DataChunk()
        {
        }

        /// <summary>
        /// Creates a new DataChunk.
        /// If <paramref name="FillWithExisting"/> is set to true, the DataChunk will be generated with existing data read from a <see cref="Rom"/>.
        /// </summary>
        public DataChunk(Pointer dataStart, int dataLength, bool FillWithExisting = true)
        {
            DataStart = dataStart;
            DataLength = dataLength;
            //Filling data
            Data = new byte[dataLength];
            if (FillWithExisting)
            {
                Buffer.BlockCopy(Editor.ROM.Data, dataStart.Offset, Data, 0, dataLength);
            }
        }

        /// <summary>
        /// Creates a new DataChunk with the data defined in <paramref name="data"/>.
        /// </summary>
        public DataChunk(Pointer dataStart, byte[] data)
        {
            DataStart = dataStart;
            Data = data;

            DataLength = Data.Length;
        }


        //Fields
        public Pointer DataStart { get; set; }
        public int DataLength { get; set; }
        public byte[] Data { get; set; }


        //Methods
        /// <summary>
        /// Returns one <see cref="byte"/> from the given offset in the <see cref="DataChunk"/>.
        /// Other than directly reading from an array this will take the <see cref="DataStart"/> value into account.
        /// </summary>
        public byte Read8(int offset)
        {
            return Data[offset - DataStart.Offset];
        }

        /// <summary>
        /// Returns one <see cref="byte"/> from the given <see cref="Pointer"/> in the <see cref="DataChunk"/>.
        /// Other than directly reading from an array this will take the <see cref="DataStart"/> value into account.
        /// </summary>
        public byte Read8(Pointer offset)
        {
            return Read8(offset.Offset);
        }

        /// <summary>
        /// Returns a <see cref="ushort"/> from the given offset in the <see cref="DataChunk"/>.
        /// Other than directly reading from an array this will take the <see cref="DataStart"/> value into account.
        /// This function expects the values to be little endian.
        /// </summary>
        public ushort Read16(int offset)
        {
            byte first = Read8(offset);
            byte second = Read8(offset + 1);
            return (ushort)(first | (second << 8));
        }

        /// <summary>
        /// Returns a <see cref="ushort"/> from the given <see cref="Pointer"/> in the <see cref="DataChunk"/>.
        /// Other than directly reading from an array this will take the <see cref="DataStart"/> value into account.
        /// This function expects the values to be little endian.
        /// </summary>
        public ushort Read16(Pointer offset)
        {
            return Read16(offset.Offset);
        }

        /// <summary>
        /// Checks if the <see cref="DataChunk"/> overlaps somewhere with the <paramref name="SecondChunk"/>.
        /// </summary>
        public bool Overlap(DataChunk SecondChunk)
        {
            int a1 = DataStart.Offset;
            int a2 = DataStart.Offset + DataLength;
            int b1 = SecondChunk.DataStart.Offset;
            int b2 = SecondChunk.DataStart.Offset + SecondChunk.DataLength;

            //If the length of both ranges combined does not fit into the length of the memory space they span they have to overlap
            return (Math.Max(a2, b2) - Math.Min(a1, b1) < DataLength + SecondChunk.DataLength);
        }

        /// <summary>
        /// If <paramref name="SecondChunk"/> overlaps with the <see cref="DataChunk"/> it merges both of them into a new <see cref="DataChunk"/>.
        /// The data of the <paramref name="SecondChunk"/> will take priority over the existing <see cref="DataChunk"/>.
        /// If <paramref name="forceMerge"/> is set to true it will always merge the two chunks, even if they do not overlap. Data not covered by any chunk will be filled with data from the ROM.
        /// </summary>
        public DataChunk Merge(DataChunk SecondChunk, bool forceMerge = false)
        {
            if (!Overlap(SecondChunk) && !forceMerge) return this; //The 'new' DataChunk is just the old one cause nothing could have been merged

            int a1 = DataStart.Offset;
            int a2 = DataStart.Offset + DataLength;
            int b1 = SecondChunk.DataStart.Offset;
            int b2 = SecondChunk.DataStart.Offset + SecondChunk.DataLength;

            int combinedLength = Math.Max(a2, b2) - Math.Min(a1, b1);
            int dataStart = Math.Min(a1, b1);
            byte[] data = new byte[combinedLength];
            if (forceMerge) Buffer.BlockCopy(Editor.ROM.Data, dataStart, data, 0, combinedLength); //Copy data from ROM first if merge is forced, then overwrite it

            //writing the new data
            Buffer.BlockCopy(Data, 0, data, a1 - dataStart, DataLength); //DataChunk Data
            Buffer.BlockCopy(SecondChunk.Data, 0, data, b1 - dataStart, SecondChunk.DataLength); //SecondChunk Data

            DataChunk d = new DataChunk(new Pointer(dataStart), data);
            return (d);
        }
    }
}
