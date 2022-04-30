using System;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace YAM2E.Classes;

public static class Editor
{
    public static byte[] ROM; //byte array of the ROM
    public static string ROMPath; //direct path to ROM file,
    public static int[] A_BANKS = { 0x24000, 0x28000, 0x2C000, 0x30000, 0x34000, 0x38000, 0x3C000 }; //pointers to level data banks
    public static int SelectionWidth = 0;
    public static int SelectionHeight = 0;
    public static byte[] SelectedTiles;

    public static void open_rom()
    {
        //Get the path to ROM
        string path = GetFilePath("Gameboy ROM (*.gb)|*.gb");

        if (path != String.Empty)
        {
            open_path(path);
        }
    }

    public static void open_path(string path)
    {
        //Changing button appearance
        Globals.rom_loaded = true;

        ROMPath = path;
        ROM = File.ReadAllBytes(path);
        MainWindow.Current.ROMLoaded();
        update_title_bar();
    }

    public static string GetFilePath(string filter) //Opens Dialog Window and returns path to file
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = filter;
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
            return openFileDialog.FileName;
        return String.Empty;
    }

    public static string SaveFilePath(string filter) //Opens Dialog Window and returns path to saved file
    {
        using SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = filter;
        saveFileDialog.FilterIndex = 2;
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            return saveFileDialog.FileName;
        return String.Empty;
    }

    public static void update_title_bar()
    {
        MainWindow.Current.Text = $"{Path.GetFileNameWithoutExtension(ROMPath)} - YAM2E";
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
        string path = SaveFilePath("Gameboy ROM (*.gb)|*.gb");
        if (path == String.Empty)
            return;
        ROMPath = path;
        SaveROM();
    }

    public static void ReplaceBytes(int offsets, byte[] values)
    {
        for (int i = 0; i < values.Length; i++)
            Editor.ROM[offsets + i] = values[i];
    }

    public static void ReplaceBytes(int offsets, byte[] values, int start, int end)
    {
        byte[] newArray = new byte[end - start];
        for (int i = 0; i < newArray.Length; i++)
        {
            newArray[i] = values[i + start];
        }

        for (int i = 0; i < newArray.Length; i++)
            Editor.ROM[offsets + i] = newArray[i];
    }

    public static Rectangle UniteRect(Rectangle rect1, Rectangle rect2)
    {
        //This Function returns a rectangle with the most top left
        //position of the given rectangles and the maximum width and height
        int x = Math.Min(rect1.X, rect2.X) - 1;
        int y = Math.Min(rect1.Y, rect2.Y) - 1;
        int width = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width) - x + 2;
        int height = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height) - y + 2;
        return new Rectangle(x, y, width, height);
    }

    public static Rectangle SetValSize(Rectangle rect)
    {
        return new Rectangle(rect.X - 1, rect.Y - 1, rect.Width + 1, rect.Height + 1);
    }

    public static void DrawBlack8(Bitmap bpm, int x, int y)
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                bpm.SetPixel(x + i, y + j, Globals.CBlack);
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
            byte topByte = ROM[offset + (2 * i)];
            byte lowByte = ROM[offset + (2 * i) + 1];

            for (int j = 0; j < 8; j++) //looping through both bytes to generate the colours
            {
                if (!ByteOp.IsBitSet(lowByte, 7 - j) && !ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.CBlack);
                if (ByteOp.IsBitSet(lowByte, 7 - j) && !ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.CLightGray);
                if (!ByteOp.IsBitSet(lowByte, 7 - j) && ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.CWhite);
                if (ByteOp.IsBitSet(lowByte, 7 - j) && ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.CDarkGray);
            }
        }

    }

    public static void DrawTile8Set(int offset, Bitmap bpm, Point p, int tilesWide, int tilesHigh)
    {
        int count = 0;
        for (int i = 0; i < tilesHigh; i++)
        {
            for (int j = 0; j < tilesWide; j++)
            {
                DrawTile8(offset + 16 * count, bpm, p.X + 8 * j, p.Y + 8 * i);
                count++;
            }
        }
    }

    public static void DrawMetaTile(int gfxOffset, int metaOffset, Bitmap bpm, int x, int y)
    {
        if (ROM[metaOffset + 0] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM[metaOffset + 0], bpm, x, y);
        else DrawBlack8(bpm, x, y);
        if (ROM[metaOffset + 1] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM[metaOffset + 1], bpm, x + 8, y);
        else DrawBlack8(bpm, x + 8, y);
        if (ROM[metaOffset + 2] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM[metaOffset + 2], bpm, x, y + 8);
        else DrawBlack8(bpm, x, y + 8);
        if (ROM[metaOffset + 3] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM[metaOffset + 3], bpm, x + 8, y + 8);
        else DrawBlack8(bpm, x + 8, y + 8);
    }

    public static Bitmap DrawTileSet(int gfxOffset, int metaOffset, int tilesWide, int tilesHigh)
    {
        int count = 0;
        for (int i = 0; i < tilesHigh; i++)
        {
            for (int j = 0; j < tilesWide; j++)
            {
                if (Globals.TilesetTiles[count] != null) Globals.TilesetTiles[count].Dispose();
                Globals.TilesetTiles[count] = new Bitmap(16, 16);
                DrawMetaTile(gfxOffset, metaOffset + count * 4, Globals.TilesetTiles[count], 0, 0);
                count++;
            }
        }

        Bitmap tileset = new Bitmap(16 * tilesWide, 16 * tilesHigh);
        Graphics g = Graphics.FromImage(tileset);
        count = 0;
        for (int i = 0; i < tilesHigh; i++)
        {
            for (int j = 0; j < tilesWide; j++)
            {
                g.DrawImage(Globals.TilesetTiles[count], new Point(16 * j, 16 * i));
                count++;
            }
        }
        g.Dispose();
        return tileset;
    }

    public static Bitmap DrawScreen(int screenOffset)
    {
        Bitmap screen = new Bitmap(256, 256);
        Graphics g = Graphics.FromImage(screen);
        int counter = 0;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                g.DrawImage(Globals.TilesetTiles[ROM[screenOffset + counter]], new Point(16 * j, 16 * i));
                counter++;
            }
        }
        g.Dispose();
        return screen;
    }

    public static void DrawAreaBank(int bankOffset, Bitmap bmp, Point p)
    {
        //reading in all the screens first
        for (int i = 0; i < 59; i++)
        {
            if (Globals.Screens[i] != null) Globals.Screens[i].Dispose();
            Globals.Screens[i] = DrawScreen(bankOffset + 0x500 + (0x100 * i));
        }

        //populating area array
        int count = 0;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                int screenPointer = ROM[bankOffset + (count * 2) + 1];
                Globals.AreaScreens[j, i] = screenPointer;
                count++;
            }
        }

        //drawing the areas
        Graphics g = Graphics.FromImage(bmp);
        count = 0;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                int screen = Globals.AreaScreens[j, i] - 0x45;
                Point screenPoint = new Point(p.X + (j * 256), p.Y + (i * 256));
                if (screen >= 0) g.DrawImage(Globals.Screens[screen], screenPoint);
                count++;
            }
        }
        g.Dispose();
    }

    public static void UpdateScreen(int screen, int bankOffset)
    {
        Globals.Screens[screen] = DrawScreen(bankOffset + 0x500 + (0x100 * screen));
    }

    public static void WritePointerLittleEndian(int index, int twoByteValue)
    {
        ROM[index] = (byte)(twoByteValue & 0x00FF);
        ROM[index + 1] = (byte)(twoByteValue >> 8);
    }

    public static string GetRawDataString(int offset, int length)
    {
        StringBuilder rawData = new StringBuilder();
        for (int i = 0; i < length; i++)
        {
            rawData.Append(ROM[offset + i].ToString("X2")).Append(' ');
        }
        return rawData.ToString();
    }
}