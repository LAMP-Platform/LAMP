using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YAM2E.Classes
{
    public static class Editor
    {
        public static byte[] ROM; //byte array of the ROM
        public static string ROMPath;
        public static int[] A_BANKS = { 0x24000, 0x28000, 0x2C000, 0x30000, 0x34000, 0x38000, 0x3C000 }; //pointers to level data banks

        public static void open_rom()
        {
            //Get the path to ROM
            string path = getFilePath("Gameboy ROM (*.gb)|*.gb");

            if (path != string.Empty)
            {
                open_path(path);
            }
        }

        public static void open_path(string path)
        {
            //Changing button appearence
            Globals.rom_loaded = true;
            main_window.Current.ROMLoaded();

            ROMPath = path;
            ROM = File.ReadAllBytes(path);
            update_title_bar();
        }

        public static string getFilePath(string filter) //Opens Dialog Window and returns path to file
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = filter;
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    return openFileDialog.FileName;
                return string.Empty;
            }
        }

        public static string saveFilePath(string filter) //Opens Dialog Window and returns path to saved file
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = filter;
                saveFileDialog.FilterIndex = 2;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    return saveFileDialog.FileName;
                return string.Empty;
            }
        }

        public static void update_title_bar()
        {
            main_window.Current.Text = (Path.GetFileNameWithoutExtension(ROMPath) + " - YAM2E");
        }

        public static void SaveROM()
        {
            // Open rom, go to origin, dump byte array, close file stream
            FileStream file = File.OpenWrite(ROMPath);
            file.Position = 0;
            file.Write(ROM, 0, ROM.Length);
            file.Close();
            update_title_bar();
        }

        public static void SaveROMAs()
        {
            string path = saveFilePath("Gameboy ROM (*.gb)|*.gb");
            if (path == string.Empty)
                return;
            ROMPath = path;
            SaveROM();
        }

        public static void DrawBlack8(Bitmap bpm, int x, int y)
        {
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    bpm.SetPixel(x + i, y + j, Globals.cBlack);
                }
            }
        }

        public static void DrawTile8(int offset, Bitmap bpm, int x, int y)
        {
            //one 8x8 tile = 16 bytes
            for (int i = 0; i < 8; i++)
            {
                //load one 8 pixel row
                //one row = 2 bytes
                byte topbyte = ROM[offset + (2 * i)];
                byte lowbyte = ROM[offset + (2 * i) + 1];

                for (int j = 0; j < 8; j++) //looping through both bytes to generate the colours
                {
                    if (!ByteOp.IsBitSet(lowbyte, 7 - j) && !ByteOp.IsBitSet(topbyte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.cBlack);
                    if (ByteOp.IsBitSet(lowbyte, 7 - j) && !ByteOp.IsBitSet(topbyte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.cLightGray);
                    if (!ByteOp.IsBitSet(lowbyte, 7 - j) && ByteOp.IsBitSet(topbyte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.cWhite);
                    if (ByteOp.IsBitSet(lowbyte, 7 - j) && ByteOp.IsBitSet(topbyte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.cDarkGray);
                }
            }

        }

        public static void DrawTile8Set(int offset, Bitmap bpm, Point p, int tiles_wide, int tiles_high)
        {
            int count = 0;
            for (int i = 0; i < tiles_high; i++)
            {
                for (int j = 0; j < tiles_wide; j++)
                {
                    DrawTile8(offset + 16 * count, bpm, p.X + 8 * j, p.Y + 8 * i);
                    count++;
                }
            }
        }

        public static void DrawMetaTile(int gfx_offset, int meta_offset, Bitmap bpm, int x, int y)
        {
            if (ROM[meta_offset] >= 0x7F) DrawBlack8(bpm, x, y);
            else DrawTile8(gfx_offset + 16 * ROM[meta_offset], bpm, x, y);
            if (ROM[meta_offset + 1] >= 0x7F) DrawBlack8(bpm, x + 8, y);
            else DrawTile8(gfx_offset + 16 * ROM[meta_offset + 1], bpm, x + 8, y);
            if (ROM[meta_offset + 2] >= 0x7F) DrawBlack8(bpm, x, y + 8);
            else DrawTile8(gfx_offset + 16 * ROM[meta_offset + 2], bpm, x, y + 8);
            if (ROM[meta_offset + 3] >= 0x7F) DrawBlack8(bpm, x + 8, y + 8);
            else DrawTile8(gfx_offset + 16 * ROM[meta_offset + 3], bpm, x + 8, y + 8);
            //if (ROM[meta_offset + 0] <= 0x7F) DrawTile8(gfx_offset + 16 * ROM[meta_offset + 0], bpm, x, y);
            //if (ROM[meta_offset + 1] <= 0x7F) DrawTile8(gfx_offset + 16 * ROM[meta_offset + 1], bpm, x + 8, y);
            //if (ROM[meta_offset + 2] <= 0x7F) DrawTile8(gfx_offset + 16 * ROM[meta_offset + 2], bpm, x, y + 8);
            //if (ROM[meta_offset + 3] <= 0x7F) DrawTile8(gfx_offset + 16 * ROM[meta_offset + 3], bpm, x + 8, y + 8);
        }

        public static void DrawTileSet(int gfx_offset, int meta_offset,Bitmap bpm, Point p, int tiles_wide, int tiles_high)
        {
            int count = 0;
            for (int i = 0; i < tiles_high; i++)
            {
                for (int j = 0; j < tiles_wide; j++)
                {
                    DrawMetaTile(gfx_offset, meta_offset + count * 4, bpm, p.X + 16 * j, p.Y + 16 * i);
                    count++;
                }
            }
        }

        public static void DrawScreen(int gfx_offset, int meta_offset, Bitmap bmp, Point p)
        {
            int screen_offset = 0x25F00;
            int counter = 0;
            for (int i = 0; i < 16; i++)
            {
                for (int j = 0; j < 16; j++)
                {
                    DrawMetaTile(gfx_offset, meta_offset + ROM[screen_offset + counter] * 4, bmp, p.X + 16 * j, p.Y + 16 * i);
                    counter++;
                }
            }
        }

        public static Bitmap ResizeBitmap(Bitmap bmp, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);
            using (Graphics g = Graphics.FromImage(result))
            {
                g.DrawImage(bmp, 0, 0, width, height);
            }

            return result;
        }
    }
}
