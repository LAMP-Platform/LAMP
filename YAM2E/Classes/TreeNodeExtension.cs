using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YAM2E.Classes
{
    class TreeNodeExtension
    {
        //If a Node represents an Opcode or parameter for an opcode
        public bool IsOpcode { get; set; } = false;
        //What part of the byte to read
        public ReadByte ByteRead { get; set; } = ReadByte.Whole;
        //The byte to read
        public int Byte { get; set; }
        //Length of the Opcode
        public int OpcodeLength { get; set; } = 0;
    }

    public enum ReadByte
    {
        Whole,
        HighNybble,
        LowNybble,
        Pointer
    }
}
