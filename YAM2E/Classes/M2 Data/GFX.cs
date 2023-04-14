using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    public class GFX
    {
        /// <summary>
        /// A GFX object stores a specific range of Graphics Data, which can be modified
        /// </summary>
        public GFX() { }

        public Tile[] Tiles
        {
            get => tiles;
            set => tiles = value;
        }
        private Tile[] tiles;

        public int Width { get; set; }
        public int Height { get; set; }
    }
}
