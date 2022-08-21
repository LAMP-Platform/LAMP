using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.FORMS;
using LAMP.Controls;
using LAMP.Classes.M2_Data;
using System.Collections.Generic;

namespace LAMP;

public partial class MainWindow : Form
{
    public static MainWindow Current;

    //Tile Viewer vars
    public static TileViewer Tileset = new TileViewer();
    public static RoomViewer Room = new RoomViewer();
    private Point StartSelection = new Point(-1, -1);
    private Point TilesetSelectedTile = new Point(-1, -1);
    private Point RoomSelectedTile = new Point(-1, -1);
    private Size RoomSelectedSize = new Size(-1, -1);

    //Main Editor vars
    bool EditingTiles = true;
    bool TilesetSelected = true;

    public MainWindow()
    {
        Current = this;
        InitializeComponent();

        //Reading vanilla ROM path
        string path = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "/LAMP/rompath.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(path));
        if (File.Exists(path))
        {
            Globals.RomPath = File.ReadAllText(path);
        } else
        {
            File.WriteAllText(path, "");
        }
    }

    public void ProjectLoaded(bool value = true) //greys out buttons or enables them if ROM is loaded
    {
        //Enabling UI
        btn_save_project.Enabled = value;
        btn_create_backup.Enabled = value;
        tool_strip_editors.Enabled = value;
        tool_strip_tools.Enabled = value;
        grp_data_selector.Visible = value;
        btn_open_tweaks_editor_image.Enabled = value;
        btn_save_rom_image.Enabled = value;
        btn_open_transition_editor_image.Enabled = value;
        grp_main_tileset_viewer.Visible = value;
        grp_main_room_viewer.Visible = value;
        tool_strip_view.Enabled = value;
        grp_main_view.Visible = value;
        btn_tile_mode.Enabled = value;
        btn_tile_mode.Checked = value;
        btn_object_mode.Enabled = value;
        btn_tileset_definitions.Enabled = value;

        if (value != true) return;

        #region Tile Viewer
        Controls.Add(Tileset);
        Tileset.BringToFront();
        grp_main_tileset_viewer.Controls.Add(Tileset);
        Tileset.Location = new Point(15, 20);
        Tileset.BackColor = Globals.ColorBlack;
        Tileset.MouseDown += new MouseEventHandler(Tileset_MouseDown);
        Tileset.MouseMove += new MouseEventHandler(Tileset_MouseMove);
        Tileset.MouseUp += new MouseEventHandler(Tileset_MouseUp);
        Tileset.ResetSelection();
        UpdateTileset();
        #endregion

        #region Room Viewer
        cbb_area_bank.SelectedIndex = 0;
        Controls.Add(Room);
        Room.BringToFront();
        flw_main_room_view.Controls.Add(Room);
        Room.Location = new Point(15, 20);
        Room.BackColor = Globals.ColorBlack;
        Room.MouseDown += new MouseEventHandler(Room_MouseDown);
        Room.MouseMove += new MouseEventHandler(Room_MouseMove);
        Room.MouseUp += new MouseEventHandler(Room_MouseUp);
        Room.ResetSelection();
        #endregion
    }

    public void UpdateTileset()
    {
        Globals.Tileset.Dispose();
        Globals.Tileset = Editor.DrawTileSet((int)num_main_graphics_offset.Value, (int)num_main_metatile.Value, 16, 8);
        Tileset.BackgroundImage = Globals.Tileset;
        grp_main_tileset_viewer.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);
    }

    public void UpdateRoom()
    {
        Point p = new Point(0, 0);
        Globals.AreaBank.Dispose();
        Globals.AreaBank = new Bitmap(4096, 4096, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        Editor.DrawAreaBank(Globals.SelectedArea, Globals.AreaBank, p);
        Room.BackgroundImage = Globals.AreaBank;
    }

    public void UpdateSelectedTiles()
    {
        RoomSelectedSize = new Size(Tileset.SelRect.Width, Tileset.SelRect.Height);
        int x = Tileset.SelRect.X / 16;
        int y = Tileset.SelRect.Y / 16;
        int width = (Tileset.SelRect.Width + 1) / 16;
        int height = (Tileset.SelRect.Height + 1) / 16;
        Editor.SelectionWidth = width;
        Editor.SelectionHeight = height;
        lbl_main_selection_size.Text = $"Selected Area: {width} x {height}";

        //returns the selected Metatile offsets
        int tiles_width = Tileset.BackgroundImage.Width / 16;
        Editor.SelectedTiles = new byte[width * height];
        int count = 0;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                int val = (y + i) * tiles_width + j + x;
                Editor.SelectedTiles[count] = (byte)val;
                count++;
            }
        }
    }

    public void PlaceSelectedTiles()
    {
        int x = RoomSelectedTile.X;
        int y = RoomSelectedTile.Y;

        //generate array with tiles that have to be replaced
        Tile[] replaceTiles = new Tile[Editor.SelectionWidth * Editor.SelectionHeight];
        int count = 0;
        for (int i = 0; i < Editor.SelectionHeight; i++)
        {
            for (int j = 0; j < Editor.SelectionWidth; j++)
            {
                int tx = x + 16 * j;
                int ty = y + 16 * i;
                Tile t = new Tile();
                t.ScreenNr = Editor.GetScreenNrFromXY(tx, ty, Globals.SelectedArea);
                t.Screen = Globals.Screens[Globals.SelectedArea][t.ScreenNr];
                t.Area = Globals.SelectedArea;
                t.Position = new Point(tx % 256, ty % 256);
                replaceTiles[count] = t;
                count++;
            }
        }

        //Writing data
        count = 0;
        List<int> updatedScreens = new List<int>();
        foreach (Tile t in replaceTiles)
        {
            t.ReplaceTile(Editor.SelectedTiles[count]);
            if (!updatedScreens.Contains(t.ScreenNr)) updatedScreens.Add(t.ScreenNr);
            Editor.DrawScreen(Globals.SelectedArea, t.ScreenNr);
            count++;
        }

        //redrawing updated screens
        count = 0;
        Graphics g = Graphics.FromImage(Globals.AreaBank);
        foreach (int nr in Globals.Areas[Globals.SelectedArea].Screens)
        {
            //screen pos
            int sy = count / 16;
            int sx = count % 16;
            sx *= 256;
            sy *= 256;

            if (!updatedScreens.Contains(nr))
            {
                count++;
                continue;
            }
            GameScreen screen = Globals.Screens[Globals.SelectedArea][nr];
            g.DrawImage(screen.image, new Point(sx, sy));
            Room.Invalidate(new Rectangle(sx, sy, 256, 256));
            count++;
        }
        g.Dispose();
    }

    public void ToggleScreenOutlines()
    {
        Room.ShowScreenOutlines = !Room.ShowScreenOutlines;
        Room.Invalidate();
    }

    public void ToggleDuplicateOutlines()
    {
        Room.ShowDuplicateOutlines = !Room.ShowDuplicateOutlines;
        Room.Invalidate();
    }

    public void ToggleSelectionFocus(bool TilesetFocused)
    {
        if (TilesetFocused == true)
        {
            Room.ResetSelection();
            Room.Invalidate();
        }
        else
        {
            Tileset.ResetSelection();
            Tileset.Invalidate();
        }
        TilesetSelected = TilesetFocused;
    }

    void ToggleEditingMode()
    {
        EditingTiles = !EditingTiles;
        btn_tile_mode.Checked = EditingTiles;
        btn_object_mode.Checked = !EditingTiles;
        if (EditingTiles) Room.ContextMenuStrip = null;
        else Room.ContextMenuStrip = ctx_room_context_menu;
    }

    #region Main Window Events

    #region Tileset Events
    private void Tileset_MouseDown(object sender, MouseEventArgs e)
    {
        ToggleSelectionFocus(true);
        int x = (e.X >> 4) * 16; //tile position at moment of click
        int y = (e.Y >> 4) * 16; //
        //setting start position for selection
        StartSelection.X = x;
        StartSelection.Y = y;
        Rectangle rect = Tileset.SelRect; //old selection rectangle
        Tileset.SelRect = new Rectangle(StartSelection.X, StartSelection.Y, 16 - 1, 16 - 1);
        Tileset.Invalidate(Editor.UniteRect(Tileset.SelRect, rect));
    }

    private void Tileset_MouseMove(object sender, MouseEventArgs e)
    {
        int x = (e.X >> 4) * 16; //locks position of mouse to edge of tiles
        int y = (e.Y >> 4) * 16; //
        if ((x == TilesetSelectedTile.X && y == TilesetSelectedTile.Y) || (x < 0 || y < 0) || (x > Tileset.BackgroundImage.Width - 16 || y > Tileset.BackgroundImage.Height - 16)) //if mouse out of Tileset bounds
            return;
        TilesetSelectedTile.X = x;
        TilesetSelectedTile.Y = y;
        if (e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
        {
            int width = Math.Abs((TilesetSelectedTile.X) - StartSelection.X) + 16 - 1; //Width and Height of the Selection
            int height = Math.Abs((TilesetSelectedTile.Y) - StartSelection.Y) + 16 - 1;//

            Tileset.RedRect = new Rectangle(-1, 0, 0, 0); //This hides the red Rect
            Rectangle rect = Tileset.SelRect; //old selection rectangle
            Tileset.SelRect = new Rectangle(Math.Min(StartSelection.X, TilesetSelectedTile.X), Math.Min(StartSelection.Y, TilesetSelectedTile.Y), width, height);
            Tileset.Invalidate(Editor.UniteRect(Tileset.SelRect, rect));

            lbl_main_selection_size.Text = $"Selected Area: {(width + 1) / 16} x {(height + 1) / 16}";
        }
        else
        {
            Rectangle rect = Tileset.RedRect; //old Position of the rectangle
            Tileset.RedRect = new Rectangle(TilesetSelectedTile.X, TilesetSelectedTile.Y, 16 - 1, 16 - 1);
            Tileset.Invalidate(Editor.UniteRect(Tileset.RedRect, rect));
        }

    }

    private void Tileset_MouseUp(object sender, MouseEventArgs e)
    {
        UpdateSelectedTiles();
    }
    #endregion

    #region Room Events
    private void Room_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            if (!EditingTiles) return;
            PlaceSelectedTiles();
        }
        if (e.Button == MouseButtons.Middle)
        {
            ToggleEditingMode();
        }
        if (e.Button == MouseButtons.Right)
        {
            if (!EditingTiles) return;
            ToggleSelectionFocus(false);
            int x = (e.X >> 4) * 16; //tile position at moment of click
            int y = (e.Y >> 4) * 16; //
            StartSelection.X = x;
            StartSelection.Y = y;
            Rectangle rect = Room.SelRect; //old selection rectangle
            Room.SelRect = new Rectangle(StartSelection.X, StartSelection.Y, 16 - 1, 16 - 1);
            Room.Invalidate(Editor.UniteRect(Room.SelRect, rect));
        }
    }

    private void Room_MouseMove(object sender, MouseEventArgs e)
    {
        Globals.SelectedScreenX = Math.Min(e.X / 256, 15); //screen the mouse cursor is on
        Globals.SelectedScreenY = Math.Min(e.Y / 256, 15); //
        Globals.SelectedScreenNr = Globals.SelectedScreenY * 16 + Globals.SelectedScreenX;
        if (Room.SelectedScreen != Globals.Areas[Globals.SelectedArea].Screens[Globals.SelectedScreenNr])
        {
            Room.SelectedScreen = Globals.Areas[Globals.SelectedArea].Screens[Globals.SelectedScreenNr];
        }
        lbl_main_hovered_screen.Text = $"Selected Screen: {Globals.SelectedScreenX}, {Globals.SelectedScreenY}";

        int mouse_x = (e.X >> 4) * 16; //locks position of mouse to edge of tiles
        int mouse_y = (e.Y >> 4) * 16; //
        if ((RoomSelectedTile.X == mouse_x && RoomSelectedTile.Y == mouse_y) && (mouse_x < 0 || mouse_y < 0) || (mouse_x > Room.BackgroundImage.Width || mouse_y > Room.BackgroundImage.Height)) //if mouse out of Room bounds
            return;

        RoomSelectedTile.X = mouse_x;
        RoomSelectedTile.Y = mouse_y;

        Rectangle rect = Room.RedRect; //old Position of the rectangle
        Room.RedRect = new Rectangle(mouse_x, mouse_y, RoomSelectedSize.Width, RoomSelectedSize.Height);
        Rectangle unirect = Editor.UniteRect(Room.RedRect, rect);
        unirect.X -= 1;
        unirect.Y -= 1;
        unirect.Width += 2;
        unirect.Height += 2;
        Room.Invalidate(unirect);

        if (e.Button == MouseButtons.Left)
        {
            if (!EditingTiles) return;
            PlaceSelectedTiles();
        }
    }

    private void Room_MouseUp(object sender, MouseEventArgs e)
    {

    }

    #endregion

    #region Main Events
    private void main_window_Resize(object sender, EventArgs e)
    {
        grp_main_room_viewer.Width = this.Width - 28 - grp_main_room_viewer.Location.X;
        grp_main_room_viewer.Height = this.Height - 64 - grp_main_room_viewer.Location.Y;
        flw_main_room_view.Width = grp_main_room_viewer.Width - 30;
        flw_main_room_view.Height = grp_main_room_viewer.Height - 30;
    }

    private void btn_open_rom_Click(object sender, EventArgs e)
        => Editor.OpenProjectAndLoad();

    private void btn_new_project_Click(object sender, EventArgs e)
        => Editor.CreateNewProject();

    private void btn_save_project_Click(object sender, EventArgs e)
        => Editor.SaveProject();

    private void btn_tweaks_editor_Click(object sender, EventArgs e)
        => new TweaksEditor().Show();

    private void btn_open_rom_image_Click(object sender, EventArgs e)
        => btn_open_rom_Click(sender, e);

    private void btn_open_tweaks_editor_image_Click(object sender, EventArgs e)
        => btn_tweaks_editor_Click(sender, e);

    private void btn_save_rom_image_Click(object sender, EventArgs e)
        => Editor.SaveProject();

    private void btn_create_backup_Click(object sender, EventArgs e)
        => Editor.CreateBackup();

    private void btn_data_viewer_Click(object sender, EventArgs e)
        => new DataViewer().Show();

    private void freeSpaceToolStripMenuItem_Click(object sender, EventArgs e)
        => new FreeSpace().Show();

    private void window_drag_over(object sender, DragEventArgs e)
    {
        if (e.Data.GetDataPresent(DataFormats.FileDrop))
            e.Effect = DragDropEffects.Link;
        else
            e.Effect = DragDropEffects.None;
    }

    private void window_file_drop(object sender, DragEventArgs e)
    {
        string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
        Editor.OpenProjectAndLoad(s[0]);
    }

    private void cbb_area_bank_SelectedIndexChanged(object sender, EventArgs e)
    {
        Globals.SelectedArea = cbb_area_bank.SelectedIndex;
        UpdateRoom();
    }

    private void main_window_Load(object sender, EventArgs e)
    {

    }

    private void num_main_graphics_offset_ValueChanged(object sender, EventArgs e)
    {
        UpdateTileset();
        UpdateRoom();
    }

    private void num_main_metatile_ValueChanged(object sender, EventArgs e)
    {
        UpdateTileset();
        UpdateRoom();
    }

    private void main_window_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.F5)
        {
            ToggleScreenOutlines();
        }
    }

    private void btn_transition_editor_Click(object sender, EventArgs e)
        => new TransitionsEditor().Show();

    private void btn_open_transition_editor_image_Click(object sender, EventArgs e)
        => new TransitionsEditor().Show();

    private void btn_show_screen_outlines_Click(object sender, EventArgs e)
    {
        ToggleScreenOutlines();
        btn_show_screen_outlines.Checked = Room.ShowScreenOutlines;
    }

    private void btn_screen_settings_Click(object sender, EventArgs e)
    {
        new ScreenSettings().Show();
    }

    private void btn_tile_mode_Click(object sender, EventArgs e)
    {
        ToggleEditingMode();
    }

    private void btn_object_mode_Click(object sender, EventArgs e)
    {
        ToggleEditingMode();
    }

    private void ctx_btn_screen_settings_Click(object sender, EventArgs e)
    {
        new ScreenSettings(Globals.SelectedArea, Globals.SelectedScreenNr).Show();
    }

    private void btn_show_duplicate_outlines_Click(object sender, EventArgs e)
    {
        ToggleDuplicateOutlines();
        btn_show_duplicate_outlines.Checked = Room.ShowDuplicateOutlines;
    }

    private void chb_view_objects_CheckedChanged(object sender, EventArgs e)
    {
        if (chb_view_objects.Checked == true)
        {
            Room.ShowObjects = true;
        }
        else
        {
            Room.ShowObjects = false;
        }

        for (int i = 0; i < 256; i++)
        {
            int screen = i + 256 * Globals.SelectedArea;
            if (Globals.Objects[screen].Count == 0) continue;

            foreach (Enemy o in Globals.Objects[screen])
            {
                Point p = o.GetPosition(screen);
                Rectangle inv = new Rectangle(p.X, p.Y, 16, 16);
                Room.Invalidate(inv);
            }
        }
    }

    private void ctx_btn_test_here_Click(object sender, EventArgs e)
    {
        try
        {
            string tempPath = Path.Combine(Path.GetTempPath(), "M2test.gb");
            Editor.ROM.Compile(tempPath);

            //inefficient way of making changes only to TestROM
            Rom tROM = new Rom(tempPath);

            //applying tweaks
            tROM.ReplaceBytes(Globals.EnableDebugMenuOffset, Globals.EnableDebugMenuValues);
            tROM.Write8(0x140EC, 0x0B); //Start new game on boot
            tROM.ReplaceBytes(new int[]{0x0D12, 0x0D17, 0x0D1C}, new byte[]{0x00, 0x00, 0x00}); //Skip Samus appearance fanfare

            //saving test ROM
            tROM.Compile(tempPath);

            ProcessStartInfo testROM = new ProcessStartInfo();
            testROM.FileName = tempPath;
            testROM.UseShellExecute = true;
            Process.Start(testROM);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Test ROM could not be launched.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ctx_btn_add_object_Click(object sender, EventArgs e)
    {
        Editor.AddObject(RoomSelectedTile.X, RoomSelectedTile.Y, cbb_area_bank.SelectedIndex);
    }

    private void btn_tileset_definitions_Click(object sender, EventArgs e)
    {
        new TilesetDefinitions(0).Show();
    }

    private void rOMFileToolStripMenuItem_Click(object sender, EventArgs e)
        => new Start().Show();
    #endregion

    #endregion
}