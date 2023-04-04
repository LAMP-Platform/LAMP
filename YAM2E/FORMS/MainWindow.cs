﻿using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.FORMS;
using LAMP.Controls;
using LAMP.Classes.M2_Data;
using System.Collections.Generic;
using LAMP.Utilities;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Linq;

namespace LAMP;

public partial class MainWindow : Form
{
    public static MainWindow Current;

    //Tile Viewer vars
    public static TileViewer Tileset = new TileViewer();
    public static RoomViewer Room = new RoomViewer();
    private Point StartSelection = new Point(-1, -1);
    private Point TilesetSelectedTile = new Point(-1, -1);
    private Point RoomSelectedTile = new Point(-1, -1); //Despite of what the name might suggest, this is not actually the selected tile but the top-left corner of the selected tile
    private Point RoomSelectedCoordinate = new Point(-1, -1);
    private Size RoomSelectedSize = new Size(-1, -1);
    public static Enemy heldObject = null;

    //Main Editor vars
    public static bool EditingTiles = true;
    bool TilesetSelected = true;

    //Graphics vars
    private Pointer gfxOffset;
    private Pointer MetatilePointer;
    private Tileset selectedTileset = null;

    public MainWindow()
    {
        Current = this;
        InitializeComponent();

        //Check for new Version
        Editor.CheckForUpdate();

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

        //binding the event to tileset input
        //tls_input.onDataChanged += new EventHandler(this.tls_input_OnDataChanged);

        //Adding custom controls
        #region Tileset
        Controls.Add(Tileset);
        grp_main_tileset_viewer.Controls.Add(Tileset);
        Tileset.Location = new Point(15, 20);
        Tileset.BackColor = Globals.ColorBlack;
        Tileset.MouseDown += new MouseEventHandler(Tileset_MouseDown);
        Tileset.MouseMove += new MouseEventHandler(Tileset_MouseMove);
        Tileset.MouseUp += new MouseEventHandler(Tileset_MouseUp);
        #endregion

        #region Room
        Controls.Add(Room);
        flw_main_room_view.Controls.Add(Room);
        Room.Location = new Point(15, 20);
        Room.BackColor = Globals.ColorBlack;
        Room.MouseDown += new MouseEventHandler(Room_MouseDown);
        Room.MouseMove += new MouseEventHandler(Room_MouseMove);
        Room.MouseUp += new MouseEventHandler(Room_MouseUp);
        #endregion
    }

    public void ProjectLoaded() //greys out buttons or enables them if a Project is loaded
    {
        //Enabling UI
        btn_save_project.Enabled = true;
        btn_create_backup.Enabled = true;
        tool_strip_editors.Enabled = true;
        tool_strip_tools.Enabled = true;
        btn_open_tweaks_editor_image.Enabled = true;
        btn_save_rom_image.Enabled = true;
        btn_open_transition_editor_image.Enabled = true;
        tool_strip_view.Enabled = true;
        btn_tile_mode.Enabled = true;
        btn_tile_mode.Checked = true;
        btn_object_mode.Checked = false;
        btn_object_mode.Enabled = true;
        btn_tileset_definitions.Enabled = true;
        btn_compile_ROM.Enabled = true;
        btn_project_settings.Enabled = true;
        btn_open_tileset_editor.Enabled = true;

        //Enabling either offset or tileset UI
        tls_input.setMode();

        //Setting base UI values
        gfxOffset = new(0x229BC);
        MetatilePointer = new(0x217BC);
        tls_input.SetGraphics(gfxOffset, 9);

        UpdateTileset();
        UpdateRoom();

        #region Tile Viewer
        Tileset.BringToFront();
        Tileset.ResetSelection();
        #endregion

        #region Room Viewer
        cbb_area_bank.SelectedIndex = 0;
        Room.BringToFront();
        Room.ResetSelection();
        #endregion

        pnl_main_window_view.Visible = true;
    }

    private void UpdateTileset()
    {
        Pointer gfx = gfxOffset;
        Pointer meta = MetatilePointer;
        if (Globals.LoadedProject != null && Globals.LoadedProject.useTilesets && selectedTileset != null)
        {
            gfx = selectedTileset.GfxOffset;
            meta = new Pointer(0x8, Editor.ROM.Read16(Editor.ROM.MetatilePointers.Offset + 2 * selectedTileset.MetatileTable));
        }
        Globals.Tileset.Dispose();
        Globals.Tileset = Editor.DrawTileSet(gfx, meta, 16, 8, true);
        Tileset.BackgroundImage = Globals.Tileset;
        grp_main_tileset_viewer.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);
    }

    private void UpdateRoom()
    {
        Point p = new Point(0, 0);
        Globals.AreaBank.Dispose();
        Globals.AreaBank = new Bitmap(4096, 4096, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
        Editor.DrawAreaBank(Globals.SelectedArea, Globals.AreaBank, p);
        Room.BackgroundImage = Globals.AreaBank;
        Editor.GetScrollBorders();
    }

    private void UpdateSelectedTiles()
    {
        if (TilesetSelected)
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
        else
        {
            RoomSelectedSize = new Size(Room.SelRect.Width, Room.SelRect.Height);
            int x = Room.SelRect.X;
            int y = Room.SelRect.Y;
            int width = (Room.SelRect.Width + 1) / 16;
            int height = (Room.SelRect.Height + 1) / 16;
            Editor.SelectionWidth = width;
            Editor.SelectionHeight = height;
            lbl_main_selection_size.Text = $"Selected Area: {width} x {height}";

            //returns the selected Metatile offsets
            Editor.SelectedTiles = new byte[width * height];
            int count = 0;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    byte value = Editor.GetTileFromXY(x + j * 16, y + i * 16, Globals.SelectedArea);
                    Editor.SelectedTiles[count] = value;
                    count++;
                }
            }
        }
    }

    private void PlaceSelectedTiles()
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
                int scrnNr = Editor.GetScreenNrFromXY(tx, ty, Globals.SelectedArea);
                if (scrnNr == -1)
                {
                    replaceTiles[count++] = new Tile() { Unused = true };
                    continue;
                }
                t.ScreenNr = scrnNr;
                t.Screen = Globals.Screens[Globals.SelectedArea][t.ScreenNr];
                t.Area = Globals.SelectedArea;
                t.Position = new Point(tx % 256, ty % 256);
                replaceTiles[count++] = t;
            }
        }

        //Writing data
        count = 0;
        List<int> updatedScreens = new List<int>();
        foreach (Tile t in replaceTiles)
        {
            if (t.Unused) continue;
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

    private void ToggleScreenOutlines()
    {
        Room.ShowScreenOutlines = !Room.ShowScreenOutlines;
        Room.Invalidate();
    }

    private void ToggleDuplicateOutlines()
    {
        Room.ShowDuplicateOutlines = !Room.ShowDuplicateOutlines;
        Room.Invalidate();
    }

    private void ToggleScrollBorders()
    {
        Room.ShowScrollBorders = !Room.ShowScrollBorders;
        Room.Invalidate();
    }

    private void ToggleSelectionFocus(bool TilesetFocused)
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

    private void ToggleEditingMode()
    {
        EditingTiles = !EditingTiles;
        btn_tile_mode.Checked = EditingTiles;
        btn_object_mode.Checked = !EditingTiles;
        if (EditingTiles) Room.ContextMenuStrip = null;
        else Room.ContextMenuStrip = ctx_room_context_menu;
    }

    public void SwitchTilesetOffsetMode()
    {
        tls_input.setMode();
    }

    public void LoadTilesetList()
    {
        tls_input.populateTilesets();
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
        int x = (e.X >> 4) * 16; //tile position at moment of click
        int y = (e.Y >> 4) * 16; //
        if (e.Button == MouseButtons.Left)
        {
            //Object editing mode
            if (!EditingTiles && Room.ShowObjects)
            {
                heldObject = Editor.FindObject(e.X, e.Y, Globals.SelectedArea);
                Editor.RemoveObject(e.X, e.Y, Globals.SelectedArea);
                Rectangle oldObject = Room.HeldObject;
                Room.HeldObject = new Rectangle(e.X - 8, e.Y - 8, 15, 15);
                Room.Invalidate(Editor.UniteRect(oldObject, Room.HeldObject));
                return;
            }

            //Tile editing mode
            PlaceSelectedTiles();
        }
        if (e.Button == MouseButtons.Middle)
        {
            ToggleEditingMode();
            Room.CursorRect = new Rectangle(x, y, 15, 15);
            Room.Invalidate(Editor.UniteRect(Room.RedRect, Room.CursorRect));
        }
        if (e.Button == MouseButtons.Right)
        {
            //object mode
            if (!EditingTiles)
            {
                RoomSelectedTile.X = x;
                RoomSelectedTile.Y = y;
                RoomSelectedCoordinate.X = e.X;
                RoomSelectedCoordinate.Y = e.Y;

                //Checking if object selected
                if (Editor.FindObject(e.X, e.Y, Globals.SelectedArea) == null) {
                    ctx_btn_remove_object.Enabled = false;
                    ctx_btn_edit_object.Enabled = false;
                }
                else
                {
                    ctx_btn_remove_object.Enabled = true;
                    ctx_btn_edit_object.Enabled = true;
                }

                //returning because we dont want to select tiles
                return;
            }

            //If not in object mode
            ToggleSelectionFocus(false);
            StartSelection.X = x;
            StartSelection.Y = y;

            Rectangle oldRed = Room.RedRect;
            oldRed.Width++;
            oldRed.Height++;
            Room.Invalidate(oldRed);
            Room.RedRect = new Rectangle(-1, 0, 0, 0); //This hides the red Rect
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
        lbl_main_hovered_screen.Text = $"Selected Screen: {Globals.SelectedScreenX.ToString("X2")}, {Globals.SelectedScreenY.ToString("X2")}";

        //Moving selected object
        if ((RoomSelectedCoordinate.X != e.X || RoomSelectedCoordinate.Y != e.Y) && !(e.X < 0 || e.Y < 0) && !(e.X > Room.BackgroundImage.Width || e.Y > Room.BackgroundImage.Height) && heldObject != null)
        {
            RoomSelectedCoordinate.X = e.X;
            RoomSelectedCoordinate.Y = e.Y;

            if ((ModifierKeys & Keys.Shift) != 0)
            {
                RoomSelectedCoordinate.X = (e.X >> 4) * 16 + 8;
                RoomSelectedCoordinate.Y = (e.Y >> 4) * 16 + 8;
            }

            Rectangle oldObject = Room.HeldObject;
            Room.HeldObject = new Rectangle(RoomSelectedCoordinate.X - 8, RoomSelectedCoordinate.Y - 8, 15, 15);
            Room.Invalidate(Editor.UniteRect(oldObject, Room.HeldObject));
        }

        int mouse_x = (e.X >> 4) * 16; //locks position of mouse to edge of tiles
        int mouse_y = (e.Y >> 4) * 16; //
        if ((RoomSelectedTile.X == mouse_x && RoomSelectedTile.Y == mouse_y) || (mouse_x < 0 || mouse_y < 0) || (mouse_x >= Room.BackgroundImage.Width || mouse_y >= Room.BackgroundImage.Height)) //if mouse out of Room bounds
            return;

        RoomSelectedTile.X = mouse_x;
        RoomSelectedTile.Y = mouse_y;

        if (!EditingTiles)
        {
            Rectangle oldCursor = Room.CursorRect;
            Room.CursorRect = new Rectangle(mouse_x, mouse_y, 15, 15);
            Room.Invalidate(Editor.UniteRect(oldCursor,Room.CursorRect));
        }

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

        if (e.Button == MouseButtons.Right && EditingTiles)
        {
            int width = Math.Abs((RoomSelectedTile.X) - StartSelection.X) + 16 - 1; //Width and Height of the Selection
            int height = Math.Abs((RoomSelectedTile.Y) - StartSelection.Y) + 16 - 1;//

            Rectangle oldRed = Room.RedRect;
            oldRed.Width++;
            oldRed.Height++;
            Room.Invalidate(oldRed);
            Room.RedRect = new Rectangle(-1, 0, 0, 0); //This hides the red Rect
            Rectangle sRect = Room.SelRect; //old selection rectangle
            Room.SelRect = new Rectangle(Math.Min(StartSelection.X, RoomSelectedTile.X), Math.Min(StartSelection.Y, RoomSelectedTile.Y), width, height);
            Room.Invalidate(Editor.UniteRect(Room.SelRect, sRect));

            lbl_main_selection_size.Text = $"Selected Area: {(width + 1) / 16} x {(height + 1) / 16}";
        }
    }

    private void Room_MouseUp(object sender, MouseEventArgs e)
    {
        if (heldObject != null)
        {
            heldObject.sX = (byte)(RoomSelectedCoordinate.X % 256);
            heldObject.sY = (byte)(RoomSelectedCoordinate.Y % 256);

            Globals.Objects[Globals.SelectedScreenNr + 256 * Globals.SelectedArea].Add(heldObject);
            heldObject = null;
        }
        UpdateSelectedTiles();
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

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        if (Globals.LoadedProject == null) return;

        DialogResult r = MessageBox.Show("Save changes before closing?", "Unsaved changes",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

        if (r == DialogResult.Yes) Editor.SaveProject();
        e.Cancel = (r == DialogResult.Cancel);
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

        //resetting scroll bars
        flw_main_room_view.AutoScrollPosition = new Point(0, 0);
        flw_main_room_view.VerticalScroll.Value = 0;
        flw_main_room_view.HorizontalScroll.Value = 0;

        UpdateRoom();
    }

    private void main_window_Load(object sender, EventArgs e)
    {

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
        new ScreenSettings(0, 0, Current).Show();
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
        => new ScreenSettings(Globals.SelectedArea, Globals.SelectedScreenNr, Current).Show();

    private void btn_show_duplicate_outlines_Click(object sender, EventArgs e)
    {
        ToggleDuplicateOutlines();
        btn_show_duplicate_outlines.Checked = Room.ShowDuplicateOutlines;
    }

    private void scrollBoundariesToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ToggleScrollBorders();
        btn_show_scroll_bounds.Checked = Room.ShowScrollBorders;
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
                Point p = o.GetPosition(screen % 256);
                Rectangle inv = new Rectangle(p.X, p.Y, 16, 16);
                Room.Invalidate(inv);
            }
        }
    }

    private void ctx_btn_test_here_Click(object sender, EventArgs e)
    {
        Save s = Globals.TestROMSave;

        if (Globals.LoadedProject.useTilesets == true && Globals.Tilesets.Count >= 1)
        {
            s.setTilesetID(tls_input.SelectedTileset);
        }
        else
        {
            s.TilesetUsed = -1;

            //setting data manually
            s.TileGraphics = tls_input.GraphicsOffset;
            s.MetatileData = tls_input.MetatilePointer;
            s.MetatileTable = tls_input.MetatileTable;
        }

        //populating the rest of data
        //Position
        s.MapBank = (byte)(cbb_area_bank.SelectedIndex); // +9 because the Game expects the actual bank and nost just an index
        s.CamScreenX = s.SamusScreenX = (byte)(RoomSelectedTile.X / 256);
        s.CamScreenY = s.SamusScreenY = (byte)(RoomSelectedTile.Y / 256);
        s.CamX = s.SamusX = (byte)RoomSelectedTile.X;
        s.CamY = s.SamusY = (byte)(RoomSelectedTile.Y - 16);

        new TestRom(s).Show();
    }

    private void ctx_btn_add_object_Click(object sender, EventArgs e)
    {
        Editor.AddObject(RoomSelectedTile.X, RoomSelectedTile.Y, Globals.SelectedArea);
    }

    private void btn_tileset_definitions_Click(object sender, EventArgs e)
    {
        new TilesetDefinitions().Show();
    }

    private void rOMFileToolStripMenuItem_Click(object sender, EventArgs e)
        => new ProgramSettins().Show();

    private void ctx_btn_remove_object_Click(object sender, EventArgs e)
        => Editor.RemoveObject(RoomSelectedCoordinate.X, RoomSelectedCoordinate.Y, Globals.SelectedArea);

    private void ctx_btn_edit_object_Click(object sender, EventArgs e)
        => new ObjectSettings(Editor.FindObject(RoomSelectedCoordinate.X, RoomSelectedCoordinate.Y, Globals.SelectedArea)).Show();

    private void btn_compile_ROM_Click(object sender, EventArgs e)
        => Editor.CompileROM();

    private void btn_project_settings_Click(object sender, EventArgs e)
        => new ProjectSettings().Show();

    private void btn_open_tileset_editor_Click(object sender, EventArgs e)
        => btn_tileset_definitions_Click(sender, e);

    private void tls_input_OnDataChanged(object sender, EventArgs e)
    {
        selectedTileset = tls_input.SelectedTileset;
        gfxOffset = tls_input.GraphicsOffset;
        MetatilePointer = tls_input.MetatilePointer;

        UpdateTileset();
        UpdateRoom();
    }

    private void btn_wiki_Click(object sender, EventArgs e)
    {
        string target = "https://github.com/ConConner/LAMP/wiki";
        Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
    }

    private void btn_save_editor_Click(object sender, EventArgs e)
    {
        new TestRom(Globals.InitialSaveGame, true).Show();
    }

    private void btn_bug_report_Click(object sender, EventArgs e)
    {
        string target = "https://github.com/ConConner/LAMP/issues";
        Process.Start(new ProcessStartInfo(target) { UseShellExecute = true });
    }
    #endregion

    #endregion

    private void btnTest_Click(object sender, EventArgs e)
    {
        DataChunk d = new DataChunk(new Pointer(0x3), new byte[] { 0xFF, 0xFE, 0xEF, 0x3D, 0x5F, 0x99, 0xDD, 0x69});
        DataChunk c = new DataChunk(new Pointer(0x20), new byte[] { 0x42, 0x66, 0x88, 0x43, 0x55, 0xAB, 0xCD, 0xEF });
        d = d.Merge(c, true);
        Globals.DataChunks.Add(d);
    }
}