using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    public class Transition
    {
        [JsonConstructor]
        public Transition() { }

        public int Number { get; set; }
        public List<byte> Data { get; set; }
        public int CopyOf { get; set; } = -1;
    }
}
