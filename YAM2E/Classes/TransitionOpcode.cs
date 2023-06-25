using LAMP.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAMP.Classes
{
    public struct TransitionOpcode
    {
        public TransitionOpcode(string opcode)
        {
            OpcodeString = opcode;
            OpcodeIndex = OpcodeInterpreter.GetOpcodeIndex(opcode);
            Description = OpcodeInterpreter.GetOpCodeDescription(opcode);
            OpcodeLength = OpcodeInterpreter.GetOpcodeLength(opcode);

            //get nybble data
            string[] templates = OpcodeInterpreter.GetDataTemplates(opcode);
            NybbleIndices = new int?[templates.Length];
            ParameterLength = new int[templates.Length];
            PredefinedValue = new int?[templates.Length];
            for (int i = 0; i < templates.Length; i++)
            {
                int? ind = null;
                int length = 1;
                int? value = null;

                string template = templates[i];

                if (template != "")
                {
                    MatchCollection c = Regex.Matches(template, @"[0-9]+");
                    ind = int.Parse(c[0].Value); //get the start nybble
                    if (c.Count > 1) //This means theres a range of nybbles
                    {
                        length = int.Parse(c[1].Value) - int.Parse(c[0].Value) + 1; //get the amount of nybbles
                    }

                    //get predefined value
                    string val = Regex.Match(Regex.Match(template, @"\((.*?)\)").Value, @"[0-9]+|[A-F]+").Value;
                    if (val != "") value = Format.StringToInt(val);
                }

                NybbleIndices[i] = ind;
                ParameterLength[i] = length;
                PredefinedValue[i] = value;
            }
        }

        public string OpcodeString { get; set; }

        public byte OpcodeIndex { get; set; }

        public string[] Description { get; set; }

        public int?[] NybbleIndices { get; set; }
        public int[] ParameterLength { get; set; }
        public int?[] PredefinedValue { get; set; }

        public int OpcodeLength { get; set; }
    }
}
