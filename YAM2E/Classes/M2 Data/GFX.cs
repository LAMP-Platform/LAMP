using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data;

/// <summary>
/// A GFX Object stores a range of Tiles which can be modified.
/// GFX are seen as a grid of tiles, defined by the <see cref="Width"/> and <see cref="Height"/>
/// </summary>
public class GFX
{
    /// <summary>
    /// A GFX Object stores a range of Tiles which can be modified.
    /// GFX are seen as a grid of tiles, defined by the <see cref="Width"/> and <see cref="Height"/>
    /// </summary>
    public GFX(Pointer offset, int tileAmount)
    {
    }

    public Tile[] Tiles
    {
        get => tiles;
        set => tiles = value;
    }
    private Tile[] tiles;

    public int Width { get; set; }
    public int Height { get; set; }

    /// <summary>
    /// Changes the Pixel of a tile at the <paramref name="x"/>, <paramref name="y"/> position of the GFX plane
    /// </summary>
    public void drawPixel(int x, int y)
    {

    }
}
