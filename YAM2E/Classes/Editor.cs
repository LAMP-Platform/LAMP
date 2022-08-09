using System;
using System.Text;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Xml;

namespace YAM2E.Classes;
//TODO: some of this should be put into their respective forms.
public static class Editor
{
    /// <summary>
    /// The ROM as a byte array.
    /// </summary>
    public static Rom ROM;

    /// <summary>
    /// Pointers to level data banks.
    /// </summary>
    public static int[] A_BANKS = { 0x24000, 0x28000, 0x2C000, 0x30000, 0x34000, 0x38000, 0x3C000 }; //pointers to level data banks

    /// <summary>
    /// The width of the tile selection in tiles.
    /// </summary>
    public static int SelectionWidth = 0;

    /// <summary>
    /// The height of the tile selection in tiles.
    /// </summary>
    public static int SelectionHeight = 0;

    /// <summary>
    /// The contents of the tile selection.
    /// </summary>
    public static byte[] SelectedTiles;

    /// <summary>
    /// Prompts to open a ROM and loads it.
    /// </summary>
    public static void OpenRomAndLoad()
    {
        //Get the path to ROM
        string path = ShowOpenDialog("GameBoy ROM (*.gb)|*.gb");

        if (path != String.Empty)
            LoadRomFromPath(path);
    }

    /// <summary>
    /// Loads a Metroid 2 ROM from a given path.
    /// </summary>
    /// <param name="path">The path to the Metroid 2 ROM.</param>
    public static void LoadRomFromPath(string path)
    {
        try 
        {
            ROM = new Rom(path);
            MainWindow.Current.ROMLoaded();
            UpdateTitlebar();

            //Changing button appearance
            Globals.RomLoaded = true;
        }
        catch
        {
            MessageBox.Show("File is not a Metroid II: Return of Samus ROM!\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }

    /// <summary>
    /// Opens an "open" Dialog Window and returns the path to the file.
    /// </summary>
    /// <param name="filter">The file name filter string, which determines the choices
    /// that appear in the "Files of type" box in the dialog box.</param>
    /// <returns>A string containing the file name selected in the file dialog box.
    /// <see cref="String.Empty"/> if the dialog was cancelled.</returns>
    public static string ShowOpenDialog(string filter)
    {
        using OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = filter;
        openFileDialog.FilterIndex = 2;
        openFileDialog.RestoreDirectory = true;

        if (openFileDialog.ShowDialog() == DialogResult.OK)
            return openFileDialog.FileName;
        return String.Empty;
    }

    /// <summary>
    /// Open a "save" Dialog Window and returns the path to the file
    /// </summary>
    /// <param name="filter">The file name filter string, which determines the choices
    /// that appear in the "Save as file type" box in the dialog box</param>
    /// <returns>A string containing the file name selected in the file dialog box.
    /// <see cref="String.Empty"/> if the dialog was cancelled.</returns>
    public static string ShowSaveDialog(string filter)
    {
        using SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = filter;
        saveFileDialog.FilterIndex = 2;
        saveFileDialog.RestoreDirectory = true;

        if (saveFileDialog.ShowDialog() == DialogResult.OK)
            return saveFileDialog.FileName;
        return String.Empty;
    }

    /// <summary>
    /// Updates the title bar of the application to show the ROM name.
    /// </summary>
    public static void UpdateTitlebar()
    {
        MainWindow.Current.Text = $"{Path.GetFileNameWithoutExtension(ROM.Filepath)} - YAM2E";
    }

    /// <summary>
    /// Saves the ROM to <see cref="ROMPath"/>.
    /// </summary>
    public static void SaveROM()
    {
        ROM.Save(ROM.Filepath);

        UpdateTitlebar();
    }

    /// <summary>
    /// Prompts the user to specify a <see cref="ROMPath"/> location and saves the ROM there.
    /// </summary>
    public static void SaveROMAs()
    {
        string path = ShowSaveDialog("GameBoy ROM (*.gb)|*.gb");
        if (path == String.Empty)
            return;
        ROM.Filepath = path;
        SaveROM();
    }

    /// <summary>
    /// Creates a Backup of the current ROM data in the same folder
    /// </summary>
    public static void CreateBackup()
    {
        string romName = DateTime.Now.ToString("\\/yy-MM-dd_hh-mm-ss") + ".gb";
        ROM.Save(Path.GetDirectoryName(ROM.Filepath) + romName);
    }

    public static void SaveEditorConfig(string filepath)
    {
        /*Directory.CreateDirectory(filepath);

        XmlWriter xW = XmlWriter.Create(filepath);
        xW.WriteStartDocument();
        xW.WriteStartElement("TILESETS");

        xW.WriteStartElement("TileInfo");
        xW.WriteAttributeString("amount", Globals.Tilesets.Count.ToString());
        xW.WriteEndElement();

        foreach (Tileset t in Globals.Tilesets)
        {
            xW.WriteStartElement("Tileset");
            xW.WriteAttributeString("ID", t.ID.ToString());
            xW.WriteAttributeString("Name", t.Name);
            xW.WriteAttributeString("MetaTable", t.MetatileTable.ToString());
            xW.WriteAttributeString("CollTable", t.CollisionTable.ToString());
            xW.WriteAttributeString("SolIndice", t.SolidityTable.ToString());
            xW.WriteEndElement();
        }

        xW.WriteEndDocument();
        xW.Close();*/

        XmlDocument xD = new XmlDocument();
        XmlElement rootNode = xD.CreateElement("TILESETS");
        xD.AppendChild(rootNode);

        XmlElement tileInfo = xD.CreateElement("TileInfo");
        XmlAttribute amount = xD.CreateAttribute("amount");
        amount.Value = Globals.Tilesets.Count.ToString();
        tileInfo.Attributes.Append(amount);
        xD.AppendChild(tileInfo);

        foreach (Tileset t in Globals.Tilesets)
        {
            XmlElement tileNode = xD.CreateElement("Tileset");
            XmlAttribute ID = xD.CreateAttribute("ID");
            XmlAttribute Name = xD.CreateAttribute("Name");
            XmlAttribute MetaTable = xD.CreateAttribute("MetaTable");
            XmlAttribute CollTable = xD.CreateAttribute("CollTable");
            XmlAttribute SolIndice = xD.CreateAttribute("SolIndice");
            ID.Value = t.ID.ToString();
            Name.Value = t.Name.ToString();
            MetaTable.Value = t.MetatileTable.ToString();
            CollTable.Value = t.CollisionTable.ToString();
            SolIndice.Value = t.SolidityTable.ToString();
            tileNode.Attributes.Append(ID);
            tileNode.Attributes.Append(Name);
            tileNode.Attributes.Append(MetaTable);
            tileNode.Attributes.Append(CollTable);
            tileNode.Attributes.Append(SolIndice);
            xD.AppendChild(tileNode);
        }

        xD.Save(filepath);
    }

    /// <summary>
    /// This Function returns a rectangle with the most top left
    /// position of the given rectangles and the maximum width and height.
    /// </summary>
    public static Rectangle UniteRect(Rectangle rect1, Rectangle rect2)
    {
        int x = Math.Min(rect1.X, rect2.X);
        int y = Math.Min(rect1.Y, rect2.Y);
        int width = Math.Max(rect1.X + rect1.Width, rect2.X + rect2.Width) - x + 1;
        int height = Math.Max(rect1.Y + rect1.Height, rect2.Y + rect2.Height) - y + 1;
        return new Rectangle(x, y, width, height);
    }

    public static Rectangle SetValSize(Rectangle rect)
    {
        return new Rectangle(rect.X - 1, rect.Y - 1, rect.Width + 1, rect.Height + 1);
    }

    #region Objects

    /// <summary>
    /// Returns a list of all the objects in the current selected area bank.
    /// </summary>
    public static List<Enemy> ReadObjects(int aBankIndex)
    {
        List<Enemy> oList = new List<Enemy>();

        for (int i = 0; i < 256; i++)
        {
            Pointer currentPtr = new Pointer(0x3, ROM.Read16(ROM.ObjectPointerTable.Offset + 2 * i + 512 * aBankIndex));
            if (ROM.Read8(currentPtr.Offset) == 0xFF)
            {
                continue;
            }

            //Object found on screen
            int count = 0;

            while (ROM.Read8(currentPtr.Offset + count * 4) != 0xFF)
            {
                byte num = ROM.Read8(currentPtr.Offset + count * 4);
                byte typ = ROM.Read8(currentPtr.Offset + 1 + count * 4);
                byte x = ROM.Read8(currentPtr.Offset + 2 + count * 4);
                byte y = ROM.Read8(currentPtr.Offset + 3 + count * 4);
                oList.Add(new Enemy(num, typ, x, y, i));
                count++;
            }
        }

        return oList;
    }

    /// <summary>
    /// Shifts Object Data together to remove bubbles of freespace
    /// </summary>
    public static void ShiftObjectData()
    {
        for (int i = 0; i < 7 * 256; i++)
        {

        }
    }

    /// <summary>
    /// Adds an object at the current mouse location
    /// </summary>
    public static void AddObject(int x, int y, int bank)
    {
        int screen = (y / 16) * 16 + (x / 16);
        int X = (x * 16) % 256;
        int Y = (y * 16) % 256;

        Pointer scrPtr = new Pointer(0x3, ROM.Read16(ROM.ObjectPointerTable.Offset + bank * 512 + 2 * screen));
        if (scrPtr.bOffset != 0x50E0) ; //F THIS SHIT AHH I NEED SLEEP
    }
    #endregion

    #region Level Drawing
    public static void DrawBlack8(Bitmap bpm, int x, int y)
    {
        for(int i = 0; i < 8; i++)
        {
            for(int j = 0; j < 8; j++)
            {
                bpm.SetPixel(x + i, y + j, Globals.ColorBlack);
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
            byte topByte = ROM.Data[offset + (2 * i)];
            byte lowByte = ROM.Data[offset + (2 * i) + 1];

            for (int j = 0; j < 8; j++) //looping through both bytes to generate the colours
            {
                if (!ByteOp.IsBitSet(lowByte, 7 - j) && !ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.ColorBlack);
                if (ByteOp.IsBitSet(lowByte, 7 - j) && !ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.ColorLightGray);
                if (!ByteOp.IsBitSet(lowByte, 7 - j) && ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.ColorWhite);
                if (ByteOp.IsBitSet(lowByte, 7 - j) && ByteOp.IsBitSet(topByte, 7 - j)) bpm.SetPixel(x + j, y + i, Globals.ColorDarkGray);
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
        if (ROM.Data[metaOffset + 0] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM.Data[metaOffset + 0], bpm, x, y);
        else DrawBlack8(bpm, x, y);
        if (ROM.Data[metaOffset + 1] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM.Data[metaOffset + 1], bpm, x + 8, y);
        else DrawBlack8(bpm, x + 8, y);
        if (ROM.Data[metaOffset + 2] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM.Data[metaOffset + 2], bpm, x, y + 8);
        else DrawBlack8(bpm, x, y + 8);
        if (ROM.Data[metaOffset + 3] <= 0x7F) DrawTile8(gfxOffset + 16 * ROM.Data[metaOffset + 3], bpm, x + 8, y + 8);
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
                g.DrawImage(Globals.TilesetTiles[ROM.Data[screenOffset + counter]], new Point(16 * j, 16 * i));
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
                int screenPointer = ROM.Data[bankOffset + (count * 2) + 1];
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
    #endregion
}