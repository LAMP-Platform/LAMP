using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.Xml;
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
    /// GFX are seen as a grid of tiles, defined by the <see cref="Width"/> and <see cref="Height"/>.
    /// </summary>
    public GFX(Pointer offset, int width, int height)
    {
        DataOffset = offset;
        Width = width; Height = height;
        Tiles = new Tile[TileAmount];

        //Filling in the Tile array
        for (int i = 0; i < TileAmount; i++)
        {
            Tiles[i] = new Tile(offset + 16 * i);
        }
    }

    public Tile[] Tiles
    {
        get => tiles;
        set => tiles = value;
    }
    private Tile[] tiles;

    public int Width { get; set; }
    public int Height { get; set; }
    public int TileAmount => Width * Height;

    /// <summary>
    /// The last drawn representation of the GFX
    /// </summary>
    public Bitmap Image
    {
        get
        {
            return image;
        }
        set
        {
            if (image == value) return;
            image?.Dispose();
            image = value;
        }
    }
    private Bitmap image;

    private Pointer DataOffset { get; set; }
    private byte[] TileData
    {
        get
        {
            List<byte> result = new List<byte>();
            for (int i = 0; i < tiles.Length; i++)
            {
                foreach(byte b in tiles[i].Data) result.Add(b);
            }

            return result.ToArray();
        }
    }

    /// <summary>
    /// Changes the Pixel of a tile at the <paramref name="x"/>, <paramref name="y"/> position of the GFX plane
    /// </summary>
    public void SetPixel(int x, int y, int value)
    {
        //figure out which tile should be modified
        int tileNr = (y / 8) * Width + (x / 8);

        //Telling that tile to modify the pixel
        Tiles[tileNr].SetPixel(x % 8, y % 8, value);

        //Update the modified Tile
        Redraw(tileNr);
    }
    /// <summary>
    /// Changes the Pixel of a tile at the <see cref="Point"/> <paramref name="p"/> of the GFX plane.
    /// </summary>
    public void SetPixel(Point p, int value) => SetPixel(p.X, p.Y, value);

    /// <summary>
    /// Gets the value of the pixel at <paramref name="x"/>, <paramref name="y"/> of the GFX plane.
    /// </summary>
    public int GetPixel(int x, int y)
    {
        //figure out which tile should be modified
        int tileNr = (y / 8) * Width + (x / 8);

        //grabbing the two bytes for the according row
        int row = y % 8;
        byte topByte = Tiles[tileNr].Data[row * 2];
        byte lowByte = Tiles[tileNr].Data[row * 2 + 1];

        //getting the bits
        return (topByte & 0b0000_0001) | (lowByte & 0b0000_0010);
    }
    /// <summary>
    /// Gets the value of the pixel at <see cref="Point"/> <paramref name="p"/> of the GFX plane.
    /// </summary>
    public int GetPixel(Point p) => GetPixel(p.X, p.Y);

    /// <summary>
    /// Gets the index of the tile at the coordinates <paramref name="x"/>, <paramref name="y"/>.
    /// </summary>
    public int GetTileID(int x, int y) => (y / 8) * Width + (x / 8);

    /// <summary>
    /// Draws the GFX map
    /// </summary>
    /// <returns></returns>
    public void Draw()
    {
        Bitmap result = new Bitmap(Width * 8, Height * 8);
        Graphics g = Graphics.FromImage(result);

        int i = 0;
        foreach(Tile t in Tiles)
        {
            Bitmap tileImage = t.Draw();

            //calculating position
            int x = i % Width;
            int y = i / Width;

            g.DrawImage(tileImage, x * 8, y * 8);
            tileImage.Dispose();

            i++;
        }

        g.Dispose();

        Image = result;
    }

    public void Redraw(int tileNr)
    {
        if (tileNr >= Tiles.Length) { throw new Exception("Tile ID is not currently loaded"); }

        Graphics g = Graphics.FromImage(Image);
        int y = tileNr / Width * 8;
        int x = tileNr % Width * 8;

        Bitmap tile = Tiles[tileNr].Draw();
        g.DrawImage(tile, x, y);

        tile.Dispose();
        g.Dispose();
    }

    public static explicit operator DataChunk(GFX gfx) 
        => new DataChunk(gfx.DataOffset, gfx.TileData);
}
