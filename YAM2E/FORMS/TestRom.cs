﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMP.Classes.M2_Data;
using LAMP.Classes;
using System.IO;
using System.Diagnostics;
using LAMP.Utilities;

namespace LAMP.FORMS
{
    public partial class TestRom : Form
    {
        public TestRom(Save s, bool isSaveFile = false)
        {
            InitializeComponent();

            save = s;

            FillValues();
            if (isSaveFile) btn_set_savegame.Visible = false;
        }

        //Fields
        private Save save;

        //Methods
        private void FillValues()
        {
            //Items
            byte check = save.Items;
            chb_bombs.Checked = (check & 0x1) == 0x1 ? true : false;
            chb_hijump.Checked = (check & 0x2) == 0x2 ? true : false;
            chb_screw.Checked = (check & 0x4) == 0x4 ? true : false;
            chb_space_jump.Checked = (check & 0x8) == 0x8 ? true : false;
            chb_spring.Checked = (check & 0x10) == 0x10 ? true : false;
            chb_spider.Checked = (check & 0x20) == 0x20 ? true : false;
            chb_varia.Checked = (check & 0x40) == 0x40 ? true : false;

            //Beam
            check = save.Beam;
            rdb_ice.Checked = check == 1 ? true : false;
            rdb_wave.Checked = check == 2 ? true : false;
            rdb_spazer.Checked = check == 3 ? true : false;
            rdb_plasma.Checked = check == 4 ? true : false;

            //Misc
            txb_energy.Text = Format.IntToString((save.EnergyTanksFilled * 100) + save.StartEnegery);
            txb_max_missiles.Text = Format.IntToString(save.MaxMissiles);
            txb_missiles.Text = Format.IntToString(save.StartMissiles);
            txb_metroids.Text = Format.IntToString(save.MetroidCount);
            txb_music.Text = Format.IntToString(save.Music);

            //Position
            txb_sam_screen_x.Text = Format.IntToString(save.SamusScreenX);
            txb_sam_screen_y.Text = Format.IntToString(save.SamusScreenY);
            txb_sam_x.Text = Format.IntToString(save.SamusX);
            txb_sam_y.Text = Format.IntToString(save.SamusY);

            txb_cam_screen_x.Text = Format.IntToString(save.CamScreenX);
            txb_cam_screen_y.Text = Format.IntToString(save.CamScreenY);
            txb_cam_x.Text = Format.IntToString(save.CamX);
            txb_cam_y.Text = Format.IntToString(save.CamY);

            //Graphics
            if (save.TilesetUsed != -1 && Globals.LoadedProject.useTilesets == true && Globals.Tilesets.Count >= 1)
            {
                tls_tileset_input.SetTileset(save.TilesetUsed);
                cbb_collision_table.Enabled = false;
                cbb_solidity.Enabled = false;
            }
            else
            {
                tls_tileset_input.ForceOffsets = true;
                tls_tileset_input.SetGraphics(save.TileGraphics, save.MetatileTable);
                tls_tileset_input.setMode();
            }

            //Collision and Sprites
            txb_sprite_graphics.Text = Format.IntToString(save.SpriteGraphics.bOffset);
            cbb_collision_table.SelectedIndex = save.CollisionTable;
            cbb_solidity.SelectedIndex = save.SolidityTable;
            cbb_area_bank.SelectedIndex = save.MapBank;
            txb_acid_damage.Text = Format.IntToString(save.AcidDamage);
            txb_spike_damage.Text = Format.IntToString(save.SpikeDamage);

        }

        #region Events
        private void btn_test_Click(object sender, EventArgs e)
        {
            try
            {
                string tempPath = Path.Combine(Path.GetTempPath(), "M2test.gb");
                Editor.ROM.Compile(tempPath);

                //inefficient way of making changes only to TestROM
                Rom tROM = new Rom(tempPath);
                
                //Applying the save file
                save.WriteToROM(tROM);

                //applying tweaks
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

        private void chb_bombs_CheckedChanged(object sender, EventArgs e) //Triggers if any checkbox is changed
        {
            byte item = 0;
            item = chb_bombs.Checked == true ? (byte)(item | 0x1) : item;
            item = chb_hijump.Checked == true ? (byte)(item | 0x2) : item;
            item = chb_screw.Checked == true ? (byte)(item | 0x4) : item;
            item = chb_space_jump.Checked == true ? (byte)(item | 0x8) : item;
            item = chb_spring.Checked == true ? (byte)(item | 0x10) : item;
            item = chb_spider.Checked == true ? (byte)(item | 0x20) : item;
            item = chb_varia.Checked == true ? (byte)(item | 0x40) : item;

            save.Items = item;
        }

        private void rdb_ice_CheckedChanged(object sender, EventArgs e) //Triggers if any radio button is checked
        {
            byte beam = 0;
            beam = rdb_ice.Checked == true ? (byte)1 : beam;
            beam = rdb_wave.Checked == true ? (byte)2 : beam;
            beam = rdb_spazer.Checked == true ? (byte)3 : beam;
            beam = rdb_plasma.Checked == true ? (byte)4 : beam;

            save.Beam = beam;
        }

        private void btn_set_savegame_Click(object sender, EventArgs e) //Copies all the data from the current TestROM Save to initial save game
        {
            if (MessageBox.Show("Are you sure you want to overwrite the initial save file?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                save.CopyTo(Globals.InitialSaveGame);
            }
        }

        private void txb_leave(object sender, EventArgs e) //Triggers if any textbox gets left
        {
            TextBox t = (TextBox)sender;
            int val = Format.StringToInt(t.Text);
            t.Text = Format.IntToString(val);
        }

        private void num_energy_ValueChanged(object sender, EventArgs e)
        {
            int val = Format.StringToInt(txb_energy.Text, 0x699);
            val = Format.BcdToInt(val);
            save.EnergyTanksAmount = save.EnergyTanksFilled = (byte)Format.DecimalToBcd(val / 100);
            save.StartEnegery = (byte)Format.DecimalToBcd(val - ((val / 100) * 100));
        }

        private void num_max_missiles_ValueChanged(object sender, EventArgs e)
        {
            save.MaxMissiles = (byte)Format.StringToInt(txb_max_missiles.Text);
        }

        private void num_missiles_ValueChanged(object sender, EventArgs e)
        {
            save.StartMissiles = (byte)Format.StringToInt(txb_missiles.Text);
        }

        private void num_metroid_count_ValueChanged(object sender, EventArgs e)
        {
            int val = Format.StringToInt(txb_metroids.Text);
            save.MetroidCount = (byte)val;
            save.RealMetroidCount = (byte)(Format.DecimalToBcd(Format.BcdToInt(val) + 0x8));
        }

        private void txb_music_TextChanged(object sender, EventArgs e)
        {
            save.Music = (byte)Format.StringToInt(txb_music.Text);
        }

        private void tls_tileset_input_DataChanged(object sender, EventArgs e)
        {
            if (Globals.LoadedProject.useTilesets && Globals.Tilesets.Count >= 1 && save.TilesetUsed != -1)
            {
                Tileset t = tls_tileset_input.SelectedTileset;
                if (t == null) return;
                save.TileGraphics = t.GfxOffset;
                save.MetatileData = Editor.GetMetaPointerFromTable(t.MetatileTable);
                cbb_collision_table.SelectedIndex = t.CollisionTable;
                cbb_solidity.SelectedIndex = t.SolidityTable;
            }
            else
            {
                save.TileGraphics = tls_tileset_input.GraphicsOffset;
                save.MetatileData = tls_tileset_input.MetatilePointer;
                save.MetatileTable = tls_tileset_input.MetatileTable;
            }
        }

        private void cbb_collision_table_SelectedIndexChanged(object sender, EventArgs e)
        {
            save.CollisionData = Editor.GetCollisionPointerFromTable(cbb_collision_table.SelectedIndex);
        }

        private void cbb_solidity_SelectedIndexChanged(object sender, EventArgs e)
        {
            byte[] solidity = Editor.GetSolidityIndices(cbb_solidity.SelectedIndex);
            save.SamusSolidity = solidity[0];
            save.EnemySolidity = solidity[1];
            save.ProjectileSolidity = solidity[2];
        }

        private void txb_sprite_graphics_TextChanged(object sender, EventArgs e)
        {
            save.SpriteGraphics = new Pointer(0x8, Format.StringToInt(txb_sprite_graphics.Text, 0xFFFF));
        }

        private void cbb_area_bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            save.MapBank = (byte)cbb_area_bank.SelectedIndex;
        }

        private void txb_sam_screen_x_TextChanged(object sender, EventArgs e)
        {
            save.SamusScreenX = (byte)Format.StringToInt(txb_sam_screen_x.Text);
        }

        private void txb_sam_screen_y_TextChanged(object sender, EventArgs e)
        {
            save.SamusScreenY = (byte)Format.StringToInt(txb_sam_screen_y.Text);
        }

        private void txb_sam_x_TextChanged(object sender, EventArgs e)
        {
            save.SamusX = (byte)Format.StringToInt(txb_sam_x.Text);
        }

        private void txb_sam_y_TextChanged(object sender, EventArgs e)
        {
            save.SamusY = (byte)Format.StringToInt(txb_sam_y.Text);
        }

        private void txb_cam_screen_x_TextChanged(object sender, EventArgs e)
        {
            save.CamScreenX = (byte)Format.StringToInt(txb_cam_screen_x.Text);
        }

        private void txb_cam_screen_y_TextChanged(object sender, EventArgs e)
        {
            save.CamScreenY = (byte)Format.StringToInt(txb_cam_screen_y.Text);
        }

        private void txb_cam_x_TextChanged(object sender, EventArgs e)
        {
            save.CamX = (byte)Format.StringToInt(txb_cam_x.Text);
        }

        private void txb_cam_y_TextChanged(object sender, EventArgs e)
        {
            save.CamY = (byte)Format.StringToInt(txb_cam_y.Text);
        }

        private void txb_acid_damage_TextChanged(object sender, EventArgs e)
        {
            save.AcidDamage = (byte)Format.StringToInt(txb_acid_damage.Text);
        }

        private void txb_spike_damage_TextChanged(object sender, EventArgs e)
        {
            save.SpikeDamage = (byte)Format.StringToInt(txb_spike_damage.Text);
        }
        #endregion
    }
}
