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

namespace LAMP.FORMS
{
    public partial class TilesetDefinitions : Form
    {
        public TileViewer Tileset = new TileViewer();
        private Bitmap tilemap;
        private Pointer MetatilePointer;

        public TilesetDefinitions(int ID)
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

            //Adding Preview Tileset
            Controls.Add(Tileset);
            Tileset.BringToFront();
            grp_tileset_preview.Controls.Add(Tileset);
            Tileset.Location = new Point(15, 20);
            Tileset.BackColor = Globals.ColorBlack;
            Tileset.ResetSelection();
            UpdateTileset();
        }

        private void UpdateTileset()
        {
            if (tilemap != null) tilemap.Dispose();
            tilemap = Editor.DrawTileSet((int)num_main_graphics_offset.Value, MetatilePointer.Offset, 16, 8);
            Tileset.BackgroundImage = tilemap;
            grp_tileset_preview.Size = new Size(Tileset.BackgroundImage.Width + 30, Tileset.BackgroundImage.Height + 35);
            grp_tileset_data.Height = grp_tileset_preview.Size.Height;
        }

        private void num_main_graphics_offset_ValueChanged(object sender, EventArgs e)
        {
            UpdateTileset();
        }

        private void cbb_metatile_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Table to offset
            MetatilePointer = new Pointer(0x8, Editor.ROM.Read16(Editor.ROM.MetatilePointers.Offset + 2 * cbb_metatile_table.SelectedIndex));

            UpdateTileset();
        }

        private void EnableComponents()
        {
            grp_tileset_preview.Visible = true;
            num_main_graphics_offset.Enabled = true;
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
        }
        private void DisableComponents()
        {
            grp_tileset_preview.Visible = false;
            num_main_graphics_offset.Enabled = false;
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
        }

        private void btn_add_tileset_Click(object sender, EventArgs e)
        {
            EnableComponents();
            Globals.Tilesets.Add(new Tileset(Globals.Tilesets.Count));
            UpdateIdList();
        }

        private void UpdateIdList()
        {
            cbb_tileset_id.Items.Clear();
            int width = cbb_tileset_id.Width;
            foreach (Tileset t in Globals.Tilesets)
            {
                string itemName = t.ID.ToString();
                if (t.Name != "") itemName += " - " + t.Name;
                cbb_tileset_id.Items.Add(itemName);

                //adjust the box width
                width = Math.Max(t.Name.Length * 7 ,width);
            }
            cbb_tileset_id.DropDownWidth = width;
            cbb_tileset_id.SelectedIndex = Globals.Tilesets.Count - 1;
            if (Globals.Tilesets.Count > 0) btn_save_tileset.Enabled = true;
        }

        private void btn_save_tileset_Click(object sender, EventArgs e)
        {
            //saving tileset object and tileset list
            //object
            Tileset t = Globals.Tilesets[cbb_tileset_id.SelectedIndex];
            t.ID = cbb_tileset_id.SelectedIndex;
            t.Name = txb_tileset_name.Text;
            t.GfxOffset = new Pointer((int)num_main_graphics_offset.Value);
            t.MetatileTable = cbb_metatile_table.SelectedIndex;
            t.CollisionTable = cbb_collision_table.SelectedIndex;
            t.SolidityTable = cbb_solidity_table.SelectedIndex;

            //file
            string path = Globals.TileDataPath;
            if (Globals.SaveROMSep) path = Path.GetDirectoryName(Editor.ROM.Filepath) + "/" + Path.GetFileNameWithoutExtension(Editor.ROM.Filepath) + ".tld";
            Editor.SaveEditorConfig(path);
        }

        private void cbb_tileset_id_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tileset t = Globals.Tilesets[cbb_tileset_id.SelectedIndex];
            num_main_graphics_offset.Value = t.GfxOffset.Offset;
            txb_tileset_name.Text = t.Name;
            cbb_metatile_table.SelectedIndex = t.MetatileTable;
            cbb_collision_table.SelectedIndex = t.CollisionTable;
            cbb_solidity_table.SelectedIndex = t.SolidityTable;
        }
    }
}
