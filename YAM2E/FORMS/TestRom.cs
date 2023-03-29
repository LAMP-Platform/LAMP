using System;
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
        public TestRom(Save s)
        {
            InitializeComponent();

            save = s;
            //Disabling things if using tilesets
            if (Globals.LoadedProject.useTilesets == true || Globals.Tilesets.Count >= 1)
            {
                grp_more_data.Enabled = false;
            }

            #region Filling in the values
            //Items
            byte check = s.Items;
            chb_bombs.Checked = (check & 0x1) == 0x1 ? true : false;
            chb_hijump.Checked = (check & 0x2) == 0x2 ? true : false;
            chb_screw.Checked = (check & 0x4) == 0x4 ? true : false;
            chb_space_jump.Checked = (check & 0x8) == 0x8 ? true : false;
            chb_spring.Checked = (check & 0x10) == 0x10 ? true : false;
            chb_spider.Checked = (check & 0x20) == 0x20 ? true : false;
            chb_varia.Checked = (check & 0x40) == 0x40 ? true : false;

            //Beam
            check = s.Beam;
            rdb_ice.Checked = check == 1 ? true : false;
            rdb_wave.Checked = check == 2 ? true : false;
            rdb_spazer.Checked = check == 3 ? true : false;
            rdb_plasma.Checked = check == 4 ? true : false;

            //Misc
            num_energy.Value = (s.EnergyTanksFilled * 100) + s.StartEnegery;
            num_max_missiles.Value = s.MaxMissiles;
            num_missiles.Value = s.StartMissiles;
            num_metroid_count.Value = s.MetroidCount;
            txb_music.Text = Format.IntToString(s.Music);

            //Position
            txb_sam_screen_x.Text = Format.IntToString(s.SamusScreenX);
            txb_sam_screen_y.Text = Format.IntToString(s.SamusScreenY);
            txb_sam_x.Text = Format.IntToString(s.SamusX);
            txb_sam_y.Text = Format.IntToString(s.SamusY);

            txb_cam_screen_x.Text = Format.IntToString(s.CamScreenX);
            txb_cam_screen_y.Text = Format.IntToString(s.CamScreenY);
            txb_cam_x.Text = Format.IntToString(s.CamX);
            txb_cam_y.Text = Format.IntToString(s.CamY);

            //Graphics
            if (s.TilesetUsed != -1) tls_tileset_input.SetTileset(s.TilesetUsed);
            else
            {
                tls_tileset_input.SetGraphics(s.TileGraphics, s.MetatileTable);
            }

            //Collision and Sprites
            txb_sprite_graphics.Text = Format.IntToString(s.SpriteGraphics.bOffset);
            cbb_collision_table.SelectedIndex = s.CollisionTable;
            cbb_solidity.SelectedIndex = s.SolidityTable;
            cbb_area_bank.SelectedIndex = s.MapBank;
            txb_acid_damage.Text = Format.IntToString(s.AcidDamage);
            txb_spike_damage.Text = Format.IntToString(s.SpikeDamage);

            #endregion
        }

        //Fields
        private Save save;

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
        #endregion

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
    }
}
