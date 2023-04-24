using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes;

[Serializable]
internal class TileSelection
{
    public TileSelection(int Width, int Height, byte[] data)
    {
        SelectionHeight = Height;
        SelectionWidth = Width;
        Tiles = data;
    }
    //Fields
    public int SelectionWidth { get; set; }
    public int SelectionHeight { get; set; }
    public byte[] Tiles { get; set; }
}
