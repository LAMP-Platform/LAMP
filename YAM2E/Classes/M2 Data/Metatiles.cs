using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data
{
    /// <summary>
    /// The Metatiles Object Stores a GFX object and a table that arranges the tiles from the GFX
    /// </summary>
    public class Metatiles
    {
        public Metatiles(GFX gfx, Pointer Offset)
        {
            TileGraphics = gfx;
        }

        private GFX TileGraphics { get; set; }
        private Pointer Offset { get; set; }
        private byte[] Table = new byte[128];

        public Bitmap Draw()
        {
            Bitmap result = new Bitmap(256, 128);
            Graphics g = Graphics.FromImage(result);

            //Drawing the Metatiles
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Bitmap tileTopLeft = TileGraphics.Tiles[Table[(i + 0) * 4 + j * 16]].Draw();
                    Bitmap tileTopRight = TileGraphics.Tiles[Table[(i + 1) * 4 + j * 16]].Draw();
                    Bitmap tileBottomLeft = TileGraphics.Tiles[Table[(i + 2) * 4 + j * 16]].Draw();
                    Bitmap tileBottomRight = TileGraphics.Tiles[Table[(i + 3) * 4 + j * 16]].Draw();
                    g.DrawImage(tileTopLeft, (i + 0) * 16, (j + 0 ) * 16);
                    g.DrawImage(tileTopRight, (i + 8) * 16, (j + 0) * 16);
                    g.DrawImage(tileBottomLeft, (i + 0) * 16, (j + 8) * 16);
                    g.DrawImage(tileBottomRight, (i + 8) * 16, (j + 8) * 16);

                    tileTopLeft.Dispose(); tileTopRight.Dispose(); tileBottomLeft.Dispose(); tileBottomRight.Dispose();
                }
            }

            g.Dispose();
            return result;
        }
    }
}
