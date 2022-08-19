using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes
{
    public class Pointer
    {
        [JsonConstructor]
        public Pointer (int offset)
        {
            Offset = offset;

            //calculating bank and pointer
            int bankNr = Offset / 0x4000;
            Bank = bankNr;

            int bOff = bankNr * 0x4000;
            bOff = Offset - bOff + 0x4000;
            bOffset = bOff;
        }

        public Pointer (int bank, int pointer)
        {
            Bank = bank;
            bOffset = pointer;

            //calculating direct offset
            int offset = (int)((pointer - 0x4000) + bank * 0x4000);
            Offset = offset;
        }

        public int Offset { get; set; }
        public int Bank { get; set; }
        public int bOffset { get; set; }
    }
}
