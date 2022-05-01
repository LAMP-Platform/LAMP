using System;
using System.Drawing;
using System.Windows.Forms;
using YAM2E.Classes;
using YAM2E.FORMS;

namespace YAM2E;

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

    public MainWindow()
    {
        Current = this;
        InitializeComponent();
    }

    public void ROMLoaded() //greys out buttons or enables them if ROM is loaded
    {
        //Enabling UI
        bool value = true;
        btn_save_rom.Enabled = value;
        btn_save_rom_as.Enabled = value;
        btn_create_backup.Enabled = value;
        tool_strip_editors.Enabled = value;
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
        Room.ContextMenuStrip = ctx_room_context_menu;
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
        Editor.DrawAreaBank(Editor.A_BANKS[cbb_area_bank.SelectedIndex], Globals.AreaBank, p);
        Room.BackgroundImage = Globals.AreaBank;
        //pnl_main_room_view.Size = new Size(Room.BackgroundImage.Width + 30, Room.BackgroundImage.Height + 35);
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
        int bank_screen_offset = Globals.AreaScreens[Globals.SelectedScreenX, Globals.SelectedScreenY];
        int screen_offset = Editor.A_BANKS[cbb_area_bank.SelectedIndex] + 0x500 + (0x100 * (bank_screen_offset - 0x45));

        //coordinates on screen
        int x = RoomSelectedTile.X / 16 - 16 * Globals.SelectedScreenX;
        int y = RoomSelectedTile.Y / 16 - 16 * Globals.SelectedScreenY;
        lbl_main_hovered_screen.Text = $"Selected Tile: {x}, {y}";

        //writing data
        int start = (16 * y) + x;
        for (int i = 0; i < Editor.SelectionHeight; i++)
        {
            Editor.ReplaceBytes(screen_offset + start + (16 * i), Editor.SelectedTiles, i * Editor.SelectionWidth, i * Editor.SelectionWidth + Editor.SelectionWidth);
        }

        //updating screens
        Editor.UpdateScreen(bank_screen_offset - 0x45, Editor.A_BANKS[cbb_area_bank.SelectedIndex]);

        //invalidating screen
        for (int i = 0; i < 16; i++)
        {
            for (int j = 0; j < 16; j++)
            {
                if (Globals.AreaScreens[i, j] == bank_screen_offset)
                {
                    Graphics g = Graphics.FromImage(Room.BackgroundImage);
                    g.DrawImage(Globals.Screens[bank_screen_offset - 0x45], new Point(256 * i, 256 * j));
                    g.Dispose();
                    Room.Invalidate(new Rectangle(256 * i, 256 * j, 256, 256));
                }
            }
        }
    }

    public void ToggleScreenOutlines()
    {
        Room.ShowScreenOutlines = !Room.ShowScreenOutlines;
        Room.Invalidate();
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
            Rectangle rect = Tileset.SelRect; //old selection rectangle
            Tileset.SelRect = new Rectangle(Math.Min(StartSelection.X, TilesetSelectedTile.X), Math.Min(StartSelection.Y, TilesetSelectedTile.Y), width, height);
            Tileset.RedRect = new Rectangle(-1, 0, 0, 0); //This hides the red Rect
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

        }
    }

    private void Room_MouseMove(object sender, MouseEventArgs e)
    {
        Globals.SelectedScreenX = e.X / 256; //screen the mouse cursor is on
        Globals.SelectedScreenY = e.Y / 256; //
        if (Room.SelectedScreen != Globals.AreaScreens[Globals.SelectedScreenX, Globals.SelectedScreenY])
        {
            Room.SelectedScreen = Globals.AreaScreens[Globals.SelectedScreenX, Globals.SelectedScreenY];
            lbl_main_hovered_screen.Text = $"Selected Screen: {Globals.SelectedScreenX}, {Globals.SelectedScreenY}";
        }

        int mouse_x = (e.X >> 4) * 16; //locks position of mouse to edge of tiles
        int mouse_y = (e.Y >> 4) * 16; //
        if ((RoomSelectedTile.X == mouse_x && RoomSelectedTile.Y == mouse_y) && (mouse_x < 0 || mouse_y < 0) || (mouse_x > Room.BackgroundImage.Width || mouse_y > Room.BackgroundImage.Height)) //if mouse out of Room bounds
            return;

        RoomSelectedTile.X = mouse_x;
        RoomSelectedTile.Y = mouse_y;

        Rectangle rect = Room.RedRect; //old Position of the rectangle
        Room.RedRect = new Rectangle(mouse_x, mouse_y, RoomSelectedSize.Width, RoomSelectedSize.Height);
        Rectangle unirect = Editor.UniteRect(Room.RedRect, rect);
        Room.Invalidate(unirect);
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
        => Editor.open_rom();

    private void btn_tweaks_editor_Click(object sender, EventArgs e)
        => new TweaksEditor().Show();

    private void btn_open_rom_image_Click(object sender, EventArgs e)
        => Editor.open_rom();

    private void btn_open_tweaks_editor_image_Click(object sender, EventArgs e)
        => new TweaksEditor().Show();

    private void btn_save_rom_image_Click(object sender, EventArgs e)
        => Editor.SaveROM();

    private void btn_save_rom_as_Click(object sender, EventArgs e)
        => Editor.SaveROMAs();

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
        Editor.open_path(s[0]);
    }

    private void cbb_area_bank_SelectedIndexChanged(object sender, EventArgs e)
    {
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
    #endregion

    #endregion
}