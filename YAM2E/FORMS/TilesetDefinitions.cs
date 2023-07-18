using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.Controls;
using LAMP.Utilities;
using System.Windows.Forms.Design;
using LAMP.Classes.M2_Data;

namespace LAMP.FORMS;

public partial class TilesetDefinitions : Form
{
    public TileViewer Tileset = new TileViewer()
    {
        Location = new Point(3, 3),
        BackColor = Globals.ColorBlack,
    };
    private Pointer MetatilePointer;

    public TilesetDefinitions()
    {
        InitializeComponent();

        //setting indices
        cbb_metatile_table.SelectedIndex = 0;
        cbb_collision_table.SelectedIndex = 0;
        cbb_solidity_table.SelectedIndex = 0;

        if (Globals.Tilesets.Count < 1) DisableComponents();
        else
        {
            UpdateIdList();
        }

        //Toolbar
        Toolbar.SetTools(false, false, false, false);
        Toolbar.SetTransform(false, false, false, false);
        Toolbar.SetCopyPaste(false, false);
        Toolbar.DisableZoomSeperator();

        //Adding Preview Tileset
        pnl_preview.Controls.Add(Tileset);
        Tileset.BringToFront();
        Tileset.ResetSelection();
        UpdateTileset();
    }

    private void UpdateTileset()
    {
        if (Globals.Tilesets.Count < 1) return;
        Tileset.BackgroundImage?.Dispose();

        GFX gfx = new GFX(Globals.Tilesets[cbb_tileset_id.SelectedIndex].GfxOffset, 16, 8);
        Metatiles meta = new Metatiles(gfx, MetatilePointer);

        Tileset.BackgroundImage = meta.Draw();
        grp_tileset_preview.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);
    }

    private void cbb_metatile_table_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Table to offset
        MetatilePointer = new Pointer(0x8, Editor.ROM.Read16(Editor.ROM.MetatilePointers.Offset + 2 * cbb_metatile_table.SelectedIndex));
    }

    private void EnableComponents()
    {
        grp_tileset_preview.Visible = true;
        txb_gfx_offset.Enabled = true;
        cbb_metatile_table.Enabled = true;
        cbb_collision_table.Enabled = true;
        cbb_solidity_table.Enabled = true;
        txb_tileset_name.Enabled = true;
        lbl_metatile_table.Enabled = true;
        lbl_collision_table.Enabled = true;
        lbl_soliditiy_table.Enabled = true;
        lbl_tileset_name.Enabled = true;
        btn_save_tileset.Enabled = true;
        btn_remove_tileset.Enabled = true;
        lbl_tileset_gfx_offset.Enabled = true;
        cbb_tileset_id.Enabled = true;
        lbl_tileset_id.Enabled = true;
        btn_edit.Enabled = true;
        btn_edit_collision.Enabled = true;
        btn_edit_solidity.Enabled = true;
    }
    private void DisableComponents()
    {
        grp_tileset_preview.Visible = false;
        txb_gfx_offset.Enabled = false;
        cbb_metatile_table.Enabled = false;
        cbb_collision_table.Enabled = false;
        cbb_solidity_table.Enabled = false;
        txb_tileset_name.Enabled = false;
        lbl_metatile_table.Enabled = false;
        lbl_collision_table.Enabled = false;
        lbl_soliditiy_table.Enabled = false;
        lbl_tileset_name.Enabled = false;
        btn_save_tileset.Enabled = false;
        btn_remove_tileset.Enabled = false;
        lbl_tileset_gfx_offset.Enabled = false;
        cbb_tileset_id.Enabled = false;
        lbl_tileset_id.Enabled = false;
        btn_edit.Enabled = false;
        btn_edit_collision.Enabled = false;
        btn_edit_solidity.Enabled = false;

        cbb_tileset_id.Text = "";
        cbb_metatile_table.SelectedIndex = 0;
        cbb_collision_table.SelectedIndex = 0;
        cbb_solidity_table.SelectedIndex = 0;
        txb_gfx_offset.Text = "";
        txb_tileset_name.Text = "";
    }

    private void btn_add_tileset_Click(object sender, EventArgs e)
    {
        EnableComponents();
        Globals.Tilesets.Add(new Tileset());
        UpdateIdList();
        MainWindow.Current.SwitchTilesetOffsetMode();
        MainWindow.Current.LoadTilesetList();
    }

    private void UpdateIdList()
    {
        if (Globals.Tilesets.Count == 0)
        {
            DisableComponents();
            return;
        }

        //Updating the combobox with all the tilesets
        cbb_tileset_id.Items.Clear();
        for (int i = 0; i < Globals.Tilesets.Count; i++)
        {
            Tileset t = Globals.Tilesets[i];
            string name = i.ToString("X");
            if (t.Name != "") name = t.Name;
            cbb_tileset_id.Items.Add(name);
        }
        cbb_tileset_id.SelectedIndex = Globals.Tilesets.Count - 1;
        if (Globals.Tilesets.Count > 0) btn_save_tileset.Enabled = true;
        cbb_tileset_id.AutoSize();
    }

    private void UpdateNames()
    {
        //Updating the names of the list
        for (int i = 0; i < Globals.Tilesets.Count; i++)
        {
            Tileset t = Globals.Tilesets[i];
            string name = i.ToString("X");
            if (t.Name != "") name = t.Name;

            cbb_tileset_id.Items[i] = name;
        }
        cbb_tileset_id.AutoSize();
    }

    private void btn_save_tileset_Click(object sender, EventArgs e)
    {
        //saving tileset object and tileset list
        //object
        Tileset t = Globals.Tilesets[cbb_tileset_id.SelectedIndex];
        t.Name = txb_tileset_name.Text;
        t.GfxOffset = Format.StringToPointer(txb_gfx_offset.Text);
        txb_gfx_offset.Text = Format.PointerToString(t.GfxOffset);
        t.MetatileTable = cbb_metatile_table.SelectedIndex;
        t.CollisionTable = cbb_collision_table.SelectedIndex;
        t.SolidityTable = cbb_solidity_table.SelectedIndex;

        //Updating preview
        UpdateTileset();
        UpdateNames();

        //Updating main window list
        MainWindow.Current.SwitchTilesetOffsetMode();
        MainWindow.Current.LoadTilesetList();
    }

    private void cbb_tileset_id_SelectedIndexChanged(object sender, EventArgs e)
    {
        Tileset t = Globals.Tilesets[cbb_tileset_id.SelectedIndex];
        txb_gfx_offset.Text = Format.PointerToString(t.GfxOffset);
        txb_tileset_name.Text = t.Name;
        cbb_metatile_table.SelectedIndex = t.MetatileTable;
        cbb_collision_table.SelectedIndex = t.CollisionTable;
        cbb_solidity_table.SelectedIndex = t.SolidityTable;

        UpdateTileset();
    }

    private void btn_remove_tileset_Click(object sender, EventArgs e)
    {
        Globals.Tilesets.RemoveAt(cbb_tileset_id.SelectedIndex);
        UpdateIdList();
        MainWindow.Current.SwitchTilesetOffsetMode();
        MainWindow.Current.LoadTilesetList();
    }

    private void btn_edit_Click(object sender, EventArgs e)
    {
        new GraphicsEditor(Globals.Tilesets[cbb_tileset_id.SelectedIndex]).Show();
    }

    private void btn_edit_solidity_Click(object sender, EventArgs e)
    {
        new SolidityEditor(cbb_solidity_table.SelectedIndex, Format.StringToPointer(txb_gfx_offset.Text)).Show();
    }

    private void Toolbar_ToolCommandTriggered(object sender, EventArgs e)
    {
        switch(Toolbar.TriggeredCommand)
        {
            case (LampToolCommand.ZoomIn):
            case (LampToolCommand.ZoomOut):
                Tileset.Zoom = Toolbar.ZoomLevel;
                break;
        }
    }
}
