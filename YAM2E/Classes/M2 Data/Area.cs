using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace YAM2E.Classes.M2_Data
{
    public class Area
    {
        [JsonConstructor]
        public Area() { }

        public int[] Screens { get; set; } = new int[256];
        public byte[] Scrolls { get; set; } = new byte[256];
        public int[] Tansitions { get; set; } = new int[256];
        public bool[] Priorities { get; set; } = new bool[256];
    }
}
