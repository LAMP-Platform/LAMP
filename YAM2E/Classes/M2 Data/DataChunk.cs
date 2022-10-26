using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    public class DataChunk
    {
        [JsonConstructor]
        public DataChunk()
        {
        }

        public DataChunk(Pointer dataStart, int dataLength, bool FillWithExisting = true)
        {
            DataStart = dataStart;
            DataLength = dataLength;
            
            //Filling data
            Data = new byte[dataLength];
            if (FillWithExisting)
            {
                for (int i = 0; i < DataLength; i++)
                {
                    int offset = DataStart.Offset + i;
                    Data[i] = Editor.ROM.Data[offset];
                }
            }
        }

        public DataChunk(Pointer dataStart, byte[] data)
        {
            DataStart = dataStart;
            Data = data;

            DataLength = Data.Length;
        }

        public Pointer DataStart { get; set; }
        public int DataLength { get; set; }
        public byte[] Data { get; set; }
    }
}
