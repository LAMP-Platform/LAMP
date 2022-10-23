using System;
using System.Text.Json;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using LAMP.FORMS;
using LAMP.Classes.M2_Data;
using System.ComponentModel.Design;
using System.Linq;

namespace LAMP.Classes;
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
    /// Creates a new project file and the needed data folders with data read from the ROM in it
    /// </summary>
    public static void CreateNewProject()
    {
        //checking if a vanilla ROM exists
        if (!File.Exists(Globals.RomPath))
        {
            MessageBox.Show("No Metroid 2: Return to Samus ROM has been selected yet!", "ROM missing",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            new ProgramSettins().Show();
            return;
        }

        //ROM
        if (LoadRomFromPath(Globals.RomPath) == false) return;

        //Creating folder structure
        string projname = ShowSaveDialog("Project File (*.m2)|*.m2");
        if (projname == String.Empty) return;
        SaveJsonObject(new Project(), projname);

        Globals.ProjName = projname;
        string dir = Path.GetDirectoryName(projname);
        Globals.ProjDirectory = dir;
        string dirData = dir + "/Data";
        string dirCustom = dir + "/Custom";
        Directory.CreateDirectory(dirData + "/Screens");
        Directory.CreateDirectory(dirCustom);

        //populating Data
        //Screens
        string path = dirData + "/Screens";
        Globals.Screens = new();
        for (int area = 0; area < 7; area ++)
        {
            Globals.Screens.Add(new List<GameScreen>());
            for (int i = 0; i < 59; i++)
            {
                Pointer pointer = new Pointer(ROM.A_BANKS[area].Offset + 0x500 + 0x100 * i);
                Globals.Screens[area].Add(new GameScreen(pointer));
            }
            SaveJsonObject(Globals.Screens[area], path + $"/Area_{area}.json");
        }

        //Areas
        path = dirData + "/Areas.json";
        Globals.Areas = new();
        for (int area = 0; area < 7; area ++)
        {
            Area a = new();
            for (int i = 0; i < 256; i++)
            {
                Pointer offset = ROM.A_BANKS[area];

                //Screens used
                int data = ROM.Read16(offset.Offset + 2*i);
                data -= 0x4500;
                data /= 0x100;
                a.Screens[i] = data;

                //Scroll data
                data = ROM.Read8(offset.Offset + 0x200 + i);
                a.Scrolls[i] = (byte)data;

                //Transition data
                data = ROM.Read16(offset.Offset + 0x300 + 2 * i);
                data &= 0xF7FF; //0xF7FF masks out the priority bit
                a.Tansitions[i] = data;

                //Priority bit
                data = ROM.Read16(offset.Offset + 0x300 + 2 * i);
                data &= 0x800;
                if (data == 0x800) a.Priorities[i] = true;
                else a.Priorities[i] = false;
            }
            Globals.Areas.Add(a);
        }
        SaveJsonObject(Globals.Areas, path);

        //Objects
        path = dirData + "/Objects.json";
        Globals.Objects = new List<List<Enemy>>();
        for (int i = 0; i < 256 * 7; i++)
        {
            Globals.Objects.Add(new List<Enemy>());
            Pointer currentPtr = new Pointer(0x3, ROM.Read16(ROM.ObjectPointerTable.Offset + 2 * i));
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
                Globals.Objects[i].Add(new Enemy(num, typ, x, y));
                count++;
            }
        }
        SaveJsonObject(Globals.Objects, path);

        //Transitions
        path = dirData + "/Transitions.json";
        Globals.Transitions = new List<Transition>();
        List<int> offsets = new List<int>(); //List saving used pointers to check for duplicate transitions
        for (int i = 0; i < 0x200; i++)
        {
            Pointer offset = new Pointer(0x5, Editor.ROM.Read16(ROM.TransitionPointerTable.Offset + (2 * i)));
            Transition t = new Transition();
            List<byte> data = new();
            //Loading transition from ROM
            for (int b = 0; b < 64; b++)
            {
                byte val = Editor.ROM.Read8(offset.Offset + b);
                data.Add(val);
                if (val == 0xFF) //End was found
                {
                    t.Data = data;
                    break;
                }
            }
            if (t.Data == null) t.Data = new List<byte>() { 0xFF }; //No end has been found, Transition is unusable so it gets replaced by an empty one
            if (offsets.Contains(offset.bOffset)) //Transition isnt unique but a copy of an existing one
            {
                int originalID = offsets.IndexOf(offset.bOffset);
                t.CopyOf = originalID;
            }
            t.Number = i;
            Globals.Transitions.Add(t);
            offsets.Add(offset.bOffset);
        }
        SaveJsonObject(Globals.Transitions, path);

        //Clearing tileset list
        Globals.Tilesets.Clear();

        //New Project created
        MainWindow.Current.ProjectLoaded();
    }

    /// <summary>
    /// Prompts to open a ROM and loads it.
    /// </summary>
    public static void OpenProjectAndLoad(string path = "")
    {
        //checking if a vanilla ROM exists
        if (!File.Exists(Globals.RomPath))
        {
            MessageBox.Show("No Metroid 2: Return to Samus ROM has been selected yet!", "ROM missing",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            new ProgramSettins().Show();
            return;
        }


        //ROM
        if (LoadRomFromPath(Globals.RomPath) == false) return;

        //Get the path to ROM
        if (path == "") path = ShowOpenDialog("Project file (*.m2)|*.m2");
        if (path != String.Empty) LoadProjectFromPath(path);
    }

    /// <summary>
    /// Loads a Project from the given path.
    /// </summary>
    /// <param name="path">The path to the Project file.</param>
    public static void LoadProjectFromPath(string path)
    {
        //try
        //{
            string json = File.ReadAllText(path);
            Globals.ProjName = path;
            path = Path.GetDirectoryName(path);
            Globals.ProjDirectory = path;
            string dirData = path + "/Data";
            string dirCustom = path + "/Custom";

            //Loading Data
            Globals.LoadedProject = JsonSerializer.Deserialize<Project>(json);

            ///METROID 2 DATA
            //Screens
            Globals.Screens = new();
            for (int area = 0; area < 7; area ++)
            {
                Globals.Screens.Add(new List<GameScreen>());
                json = File.ReadAllText(dirData + $"/Screens/Area_{area}.json");
                Globals.Screens[area] = JsonSerializer.Deserialize<List<GameScreen>>(json);
            }

            //Areas
            json = File.ReadAllText(dirData + "/Areas.json");
            Globals.Areas = JsonSerializer.Deserialize<List<Area>>(json);

            //Objects
            json = File.ReadAllText(dirData + "/Objects.json");
            Globals.Objects = JsonSerializer.Deserialize<List<List<Enemy>>>(json);

            //Transitions
            json = File.ReadAllText(dirData + "/Transitions.json");
            Globals.Transitions = JsonSerializer.Deserialize<List<Transition>>(json);

            ///CUSTOM DATA
            //Tilesets
            Globals.Tilesets.Clear();
            if (File.Exists(dirCustom + "/Tilesets.json"))
            {
                json = File.ReadAllText(dirCustom + "/Tilesets.json");
                Globals.Tilesets = JsonSerializer.Deserialize<List<Tileset>>(json);
            }

            //Tweaks
            Globals.Tweaks.Clear();
            if (File.Exists(dirCustom + "/Tweaks.json"))
            {
                json = File.ReadAllText(dirCustom + "/Tweaks.json");
                Globals.Tweaks = JsonSerializer.Deserialize<List<Tweak>>(json);
            }

            //Project loaded
            MainWindow.Current.ProjectLoaded();
            UpdateTitlebar(path);
        //}
        //catch(Exception ex)
        //{
        //    MessageBox.Show("Something went wrong while loading the project.\n"+ex.Message, "Error",
        //        MessageBoxButtons.OK, MessageBoxIcon.Error);
        //}

    }

    /// <summary>
    /// Loads a Metroid 2 ROM from the given path
    /// </summary>
    /// <param name="path">The path to the Metroid 2 ROM</param>
    /// <returns></returns>
    public static bool LoadRomFromPath(string path)
    {
        try
        {
            ROM = new Rom(path);

            //Changing button appearance
            Globals.RomLoaded = true;
            return true;
        }
        catch
        {
            MessageBox.Show("File is not a Metroid II: Return of Samus ROM!\n", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
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
    /// Compiles all the data files into a modified M2 ROM
    /// </summary>
    public static void CompileROM()
    {
        try
        {
            string filepath = ShowSaveDialog("Metroid 2: Return of Samus ROM (*.gb)|*.gb");
            if (filepath == String.Empty) return;
            SaveProject();

            //Compiling ROM by writing loaded data
            //Screens
            for (int area = 0; area < 7; area++)
            {
                for (int i = 0; i < 59; i++)
                {
                    Pointer pointer = new Pointer(ROM.A_BANKS[area].Offset + 0x500 + 0x100 * i);
                    ROM.ReplaceBytes(pointer.Offset, Globals.Screens[area][i].Data);
                }
            }

            //Areas
            for (int area = 0; area < 7; area++)
            {
                Area a = Globals.Areas[area];
                for (int i = 0; i < 256; i++)
                {
                    Pointer offset = ROM.A_BANKS[area];

                    //Screens used
                    int data = a.Screens[i];
                    data *= 0x100;
                    data += 0x4500;
                    ROM.Write16(offset.Offset + 2 * i, (ushort)data);

                    //Scroll data
                    data = a.Scrolls[i];
                    ROM.Write8(offset.Offset + 0x200 + i, (byte)data);

                    //Transition and Priorities data
                    data = a.Tansitions[i];
                    if (a.Priorities[i]) data |= 0x800;
                    ROM.Write16(offset.Offset + 0x300 + 2 * i, (ushort)data);
                }
            }

            //Objects
            Pointer lastAdd = new Pointer(ROM.ObjectDataLists.Offset);
            for (int i = 0; i < 256 * 7; i++)
            {
                //Empty object list
                if (Globals.Objects[i].Count == 0)
                {
                    if (Globals.LoadedProject.OptimizeObjectData) ROM.Write16(ROM.ObjectPointerTable.Offset + 2 * i, (ushort)ROM.ObjectDataLists.bOffset); //Writing pointer to list
                    else
                    {
                        lastAdd.Add(1);
                        ROM.Write8(lastAdd.Offset, 0xFF);
                    }
                }
                else //Objects on screen
                {
                    lastAdd.Add(1);
                    ROM.Write16(ROM.ObjectPointerTable.Offset + 2 * i, (ushort)lastAdd.bOffset); //Writing pointer to list
                    foreach (Enemy o in Globals.Objects[i])
                    {
                        //Writing Object list consecutively
                        ROM.Write8(lastAdd.Offset, o.Number);
                        lastAdd.Add(1);
                        ROM.Write8(lastAdd.Offset, o.Type);
                        lastAdd.Add(1);
                        ROM.Write8(lastAdd.Offset, o.sX);
                        lastAdd.Add(1);
                        ROM.Write8(lastAdd.Offset, o.sY);
                        lastAdd.Add(1);
                    }
                    ROM.Write8(lastAdd.Offset, 0xFF);
                }
            }

            //Transitions
            lastAdd = new Pointer(ROM.TransitionDataLists.Offset);
            lastAdd.Add(1);
            List<int> offsets = new List<int>(); //List saving written pointers for duplicate tansitions
            for (int i = 0; i < 0x200; i++)
            {
                Transition t = Globals.Transitions[i]; //Transition is empty / ends instantly
                if (t.Data.Count == 1)
                {
                    ROM.Write16(ROM.TransitionPointerTable.Offset + (2 * i), (ushort)ROM.TransitionDataLists.bOffset); //Writing pointer to list
                    offsets.Add(ROM.TransitionDataLists.bOffset);
                }
                else if (t.CopyOf != -1) //Transition is a duplicate and the data is already written
                {
                    ROM.Write16(ROM.TransitionPointerTable.Offset + (2 * i), (ushort)offsets[t.CopyOf]); //Writing pointer to list
                    offsets.Add(offsets[t.CopyOf]);
                }
                else //Transition is used and unique
                {
                    ROM.Write16(ROM.TransitionPointerTable.Offset + (2 * i), (ushort)lastAdd.bOffset); //Writing pointer to list
                    offsets.Add(lastAdd.bOffset);
                    //Writing transition
                    ROM.ReplaceBytes(lastAdd.Offset, t.Data);
                    lastAdd.Add(t.Data.Count);
                }
            }

            //Saving the ROM
            ROM.Compile(filepath);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Something went wrong while compiling the ROM.\n" + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    /// <summary>
    /// Updates the title bar of the application to show the ROM name.
    /// </summary>
    public static void UpdateTitlebar(string path)
    {
        MainWindow.Current.Text = $"{Path.GetFileNameWithoutExtension(path)} - LAMP";
    }

    /// <summary>
    /// Saves the ROM to <see cref="Globals.ProjDirectory"/>.
    /// </summary>
    public static void SaveProject()
    {
        string dir = Globals.ProjDirectory;
        string dirData = dir + "/Data";
        string dirCustom = dir + "/Custom";

        //saving Data
        //project file
        SaveJsonObject(Globals.LoadedProject, Globals.ProjName);

        //screens
        string path = dirData + "/Screens";
        for (int area = 0; area < 7; area++)
        {
            SaveJsonObject(Globals.Screens[area], path + $"/Area_{area}.json");
        }

        //Areas
        path = dirData + "/Areas.json";
        SaveJsonObject(Globals.Areas, path);

        //Objects
        path = dirData + "/Objects.json";
        SaveJsonObject(Globals.Objects, path);

        //Transitions
        path = dirData + "/Transitions.json";
        SaveJsonObject(Globals.Transitions, path);

        ///CUSTOM
        //Tilesets
        if (Globals.Tilesets.Count != 0)
        {
            path = dirCustom + "/Tilesets.json";
            SaveJsonObject(Globals.Tilesets, path);
        }

        //Tweaks
        if (Globals.Tweaks.Count != 0)
        {
            path = dirCustom + "/Tweaks.json";
            SaveJsonObject(Globals.Tweaks, path);
        }
    }

    /// <summary>
    /// Creates a Backup of the current ROM data in the same folder
    /// </summary>
    public static void CreateBackup()
    {
        string romName = DateTime.Now.ToString("\\/yy-MM-dd_hh-mm-ss") + ".gb";
    }

    /// <summary>
    /// Saves an object serialized as JSON
    /// </summary>
    public static void SaveJsonObject(object obj, string filepath)
    {
        //writing JSON file
        JsonSerializerOptions options = new JsonSerializerOptions();
        options.WriteIndented = true;
        string json = JsonSerializer.Serialize(obj, options);
        File.WriteAllText(filepath, json);
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

    /// <summary>
    /// Returns the Screen used at the given X and Y coordinates
    /// </summary>
    public static int GetScreenNrFromXY(int x, int y, int area)
    {
        if (x >= MainWindow.Room.Width || y >= MainWindow.Room.Height) return -1;
        x /= 256;
        y /= 256;
        int screenNr = y * 16 + x;
        return Globals.Areas[area].Screens[screenNr];
    }

    /// <summary>
    /// Returns the tile id at the given X and Y coordinates
    /// </summary>
    public static byte GetTileFromXY(int x, int y, int area)
    {
        int screenNr = GetScreenNrFromXY(x, y, area);
        x %= 256;
        y %= 256;
        x /= 16;
        y /= 16;
        int tileNr = y * 16 + x;
        return Globals.Screens[area][screenNr].Data[tileNr];
    }

    #region Objects

    /// <summary>
    /// Adds an object at the current mouse location
    /// </summary>
    public static void AddObject(int x, int y, int bank)
    {
        x %= 256;
        y %= 256;
        x += 8;
        y += 8;
        int screen = Globals.SelectedScreenNr + 256 * bank;
        Enemy o = new Enemy(0, 0, (byte)x, (byte)y);
        Globals.Objects[screen].Add(o);
    }

    public static Enemy FindObject(int x, int y, int bank)
    {
        x %= 256;
        y %= 256;
        int screen = Globals.SelectedScreenNr + 256 * bank;
        foreach (Enemy o in Globals.Objects[screen])
        {
            //Checking if x and y are inside a 16px rectangle of the object
            Rectangle check = new Rectangle(o.sX - 8, o.sY - 8, 16, 16);
            if (check.Contains(x, y)) return o;
        }
        return null;
    }

    public static bool RemoveObject(int x, int y, int bank)
    {
        x %= 256;
        y %= 256;
        int screen = Globals.SelectedScreenNr + 256 * bank;
        int count = 0;
        foreach (Enemy o in Globals.Objects[screen])
        {
            //Checking if x and y are inside a 16px rectangle of the object
            Rectangle check = new Rectangle(o.sX - 8, o.sY - 8, 16, 16);
            if (check.Contains(x, y))
            {
                Globals.Objects[screen].RemoveAt(count);

                //Invalidating part where object is removed
                int X = (Globals.SelectedScreenNr % 16) * 256;
                int Y = (Globals.SelectedScreenNr / 16) * 256;
                MainWindow.Room.Invalidate(new Rectangle(X + o.sX - 8, Y + o.sY - 8, 16, 16));

                return true;
            }
            count++;
        }
        return false;
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
            byte topByte = ROM.Read8(offset + (2 * i));
            byte lowByte = ROM.Read8(offset + (2 * i) + 1);

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

    public static Bitmap DrawTileSet(Pointer gfxOffset, Pointer metaOffset, int tilesWide, int tilesHigh, bool updateMain = true)
    {
        int count = 0;
        Bitmap[] Metatiles = new Bitmap[128]; //List of tile bitmaps
        for (int i = 0; i < tilesHigh; i++) //Filling list
        {
            for (int j = 0; j < tilesWide; j++)
            {
                Metatiles[count] = new Bitmap(16, 16);
                DrawMetaTile(gfxOffset.Offset, metaOffset.Offset + count * 4, Metatiles[count], 0, 0);
                count++;
            }
        }

        //Drawing the contents of the list onto a tileset bitmap
        Bitmap tileset = new Bitmap(16 * tilesWide, 16 * tilesHigh);
        Graphics g = Graphics.FromImage(tileset);
        count = 0;
        for (int i = 0; i < tilesHigh; i++)
        {
            for (int j = 0; j < tilesWide; j++)
            {
                g.DrawImage(Metatiles[count], new Point(16 * j, 16 * i));
                count++;
            }
        }
        g.Dispose();

        if (updateMain)
        {
            for (int i = 0; i < Metatiles.Length; i++)
            {
                if (Globals.Metatiles[i] != null) Globals.Metatiles[i].Dispose();
                Globals.Metatiles[i] = (Bitmap)Metatiles[i].Clone();
                Metatiles[i].Dispose();
            }
        }

        return tileset;
    }

    public static void UpdateTileList()
    {
    }

    /// <summary>
    /// Saves a Bitmap of a Screen from the screen list
    /// </summary>
    public static void DrawScreen(int area, int screenNr)
    {
        Bitmap screen = new Bitmap(256, 256);
        Graphics g = Graphics.FromImage(screen);
        GameScreen s = Globals.Screens[area][screenNr];
        int counter = 0;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                g.DrawImage(Globals.Metatiles[s.Data[counter]], new Point(16 * j, 16 * i));
                counter++;
            }
        }
        g.Dispose();
        if (s.image != null) s.image.Dispose();
        s.image = screen;
    }

    public static void DrawAreaBank(int bankNr, Bitmap bmp, Point p)
    {
        for (int i = 0; i < 59; i++)
        {
            DrawScreen(bankNr, i);
        }

        //drawing the areas
        Graphics g = Graphics.FromImage(bmp);
        Area a = Globals.Areas[bankNr];
        int count = 0;
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                int screen = a.Screens[count];
                Point screenPoint = new Point(p.X + (j * 256), p.Y + (i * 256));
                if (screen >= 0) g.DrawImage(Globals.Screens[bankNr][screen].image, screenPoint);
                count++;
            }
        }
        g.Dispose();
    }
    #endregion
}