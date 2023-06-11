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
        for (int i = 0; i < 128; i++) //TODO: Convert to single loop. You are stupid. Why did you use a 2D loop
        {
            int x = i % 16;
            int y = i / 16;

            Bitmap tileTopLeft = getTableGraphic(i * 4 + 0);
            Bitmap tileTopRight = getTableGraphic(i * 4 + 1);
            Bitmap tileBottomLeft = getTableGraphic(i * 4 + 2);
            Bitmap tileBottomRight = getTableGraphic(i * 4 + 3);
            g.DrawImage(tileTopLeft, x * 16, y * 16);
            g.DrawImage(tileTopRight, x * 16 + 8, y * 16);
            g.DrawImage(tileBottomLeft, x * 16, y * 16 + 8);
            g.DrawImage(tileBottomRight, x * 16 + 8, y * 16 + 8);

            tileTopLeft.Dispose(); tileTopRight.Dispose(); tileBottomLeft.Dispose(); tileBottomRight.Dispose();
        }

        g.Dispose();
        return result;
    }
}
