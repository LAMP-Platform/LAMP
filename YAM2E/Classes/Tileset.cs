using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YAM2E.Classes;

namespace YAM2E.Classes
{
    public class Tileset
    {
        public Tileset(int id)
        {
            ID = id;
        }

        public string Name { get; set; } = "";
        public int ID { get; set; } = 0;
        public Pointer GfxOffset { get; set; } = new Pointer(0x0);
        public int MetatileTable { get; set; } = 0;
        public int CollisionTable { get; set; } = 0;
        public int SolidityTable { get; set; } = 0;
    }
}
