using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes
{
    public struct TransitionOpcode
    {
        public TransitionOpcode(string opcode)
        {
            OpcodeString = opcode;
            OpcodeIndex = OpcodeInterpreter.GetOpcodeIndex(opcode);
        }

        public string OpcodeString { get; set; }

        public byte OpcodeIndex { get; set; }

        public string[] Description { get; set; }
    }
}
