using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data;

/// <summary>
/// The Metatiles Object Stores two GFX objects and a table that arranges the tiles from the GFX
/// </summary>
public class Metatiles
{
    public Metatiles(GFX gfx, Pointer Offset)
    {
        TileGraphics = gfx;
        this.Offset = Offset;

        //Read the table
        for (int i = 0; i < 512; i++)
        {
            Table[i] = Editor.ROM.Read8(Offset.Offset + i);
        }
    }

    /// <summary>
    /// Primary Graphics for the tiletable
    /// </summary>
    public GFX TileGraphics { get; set; }
    /// <summary>
    /// Secondary Graphics for the tiletable. These can be empty!
    /// </summary>
    public GFX SpriteGraphics { get; set; }

    /// <summary>
    /// The last drawn representation of the GFX
    /// </summary>
    public Bitmap Image
    {
        get
        {
            if (image == null) throw new Exception("The image has not been drawn yet. Run GFX.Draw() first!");
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

    private Pointer Offset { get; set; }
    private byte[] Table = new byte[512];

    /// <summary>
    /// returns the graphic used at the index in the table
    /// </summary>
    private Bitmap getTableGraphic(int index)
    {
        byte tableValue = Table[index];

        //if the value is >= 128 it has to use the sprite graphics set
        if (tableValue < TileGraphics.Tiles.Length && tableValue < 128) return TileGraphics.Tiles[tableValue].Draw();
        else if (tableValue == 0xFF) return Editor.DrawColored8x8Tile(Color.Black);
        else return Editor.DrawColored8x8Tile(Color.DarkRed);
    }

    public Bitmap Draw()
    {
        Bitmap result = new Bitmap(256, 128);
        Graphics g = Graphics.FromImage(result);

        //Drawing the Metatiles
        for (int i = 0; i < 128; i++)
        {
            int x = i % 16 * 16;
            int y = i / 16 * 16;

            Bitmap metatile = DrawMetatile(i * 4);
            g.DrawImage(metatile, x, y);

            metatile.Dispose();
        }

        g.Dispose();
        Image = result;
        return result;
    }

    private Bitmap DrawMetatile(int index)
    {
        Bitmap result = new Bitmap(16, 16);
        Graphics g = Graphics.FromImage(result);

        Bitmap tileTopLeft = getTableGraphic(index ++);
        Bitmap tileTopRight = getTableGraphic(index ++);
        Bitmap tileBottomLeft = getTableGraphic(index ++);
        Bitmap tileBottomRight = getTableGraphic(index ++);
        g.DrawImage(tileTopLeft, 0, 0);
        g.DrawImage(tileTopRight, 8, 0);
        g.DrawImage(tileBottomLeft, 0, 8);
        g.DrawImage(tileBottomRight, 8, 8);

        tileTopLeft.Dispose(); tileTopRight.Dispose(); tileBottomLeft.Dispose(); tileBottomRight.Dispose(); g.Dispose();
        return result;
    }

    /// <summary>
    /// Creates a list of Bitmaps with each metatile as a single Bitmap
    /// </summary>
    /// <returns></returns>
    public Bitmap[] DrawMetatileList()
    {
        Bitmap[] result = new Bitmap[128];

        for (int i = 0; i < 128; i++)
        {
            result[i] = DrawMetatile(i * 4);
        }

        return result;
    }

    /// <summary>
    /// Redraws every occurance of the <paramref name="tileID"/>.
    /// Returns rectangles of every changed tile for invalidation
    /// </summary>
    public List<Rectangle> RedrawTile(int tileID)
    {
        List<Rectangle> result = new();
        Graphics g = Graphics.FromImage(Image);
        for (int i = 0; i < 512; i++)
        {
            if (Table[i] != tileID) continue;

            Bitmap tileGfx = getTableGraphic(i);
            int metaNr = i / 4;
            int corner = i % 4;
            int x = metaNr % 16 * 16;
            int y = metaNr / 16 * 16;

            if (corner == 0) g.DrawImage(tileGfx, x, y);
            if (corner == 1) { g.DrawImage(tileGfx, x + 8, y); x += 8; }
            if (corner == 2) { g.DrawImage(tileGfx, x, y + 8); y += 8; }
            if (corner == 3) { g.DrawImage(tileGfx, x + 8, y + 8); x += 8; y += 8; }

            result.Add(new Rectangle(x, y, 8, 8));

            tileGfx.Dispose();
        }

        g.Dispose();
        return result;
    }

    public static explicit operator DataChunk(Metatiles meta)
        => new DataChunk(meta.Offset, meta.Table, "MetatileTable");
}