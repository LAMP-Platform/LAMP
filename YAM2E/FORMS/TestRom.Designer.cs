namespace LAMP.FORMS
{
    partial class TestRom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestRom));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            pnl_main = new System.Windows.Forms.Panel();
            grp_testROM = new System.Windows.Forms.GroupBox();
            chb_debug_menu = new System.Windows.Forms.CheckBox();
            btn_set_savegame = new System.Windows.Forms.Button();
            btn_test = new System.Windows.Forms.Button();
            grp_position = new System.Windows.Forms.GroupBox();
            grp_cam = new System.Windows.Forms.GroupBox();
            txb_cam_y = new System.Windows.Forms.TextBox();
            txb_cam_x = new System.Windows.Forms.TextBox();
            txb_cam_screen_y = new System.Windows.Forms.TextBox();
            lbl_cam_y = new System.Windows.Forms.Label();
            lbl_cam_x = new System.Windows.Forms.Label();
            txb_cam_screen_x = new System.Windows.Forms.TextBox();
            lbl_cam_screen_x = new System.Windows.Forms.Label();
            lbl_cam_screen_y = new System.Windows.Forms.Label();
            grp_samus = new System.Windows.Forms.GroupBox();
            txb_sam_y = new System.Windows.Forms.TextBox();
            txb_sam_x = new System.Windows.Forms.TextBox();
            txb_sam_screen_y = new System.Windows.Forms.TextBox();
            lbl_samus_y = new System.Windows.Forms.Label();
            lbl_samus_x = new System.Windows.Forms.Label();
            txb_sam_screen_x = new System.Windows.Forms.TextBox();
            lbl_samus_screen_x = new System.Windows.Forms.Label();
            lbl_samus_screen_y = new System.Windows.Forms.Label();
            grp_level_data = new System.Windows.Forms.GroupBox();
            grp_graphics = new System.Windows.Forms.GroupBox();
            tls_tileset_input = new Controls.Other.TilesetInput();
            lbl_sprite_graphics = new System.Windows.Forms.Label();
            txb_sprite_graphics = new System.Windows.Forms.TextBox();
            grp_misc = new System.Windows.Forms.GroupBox();
            txb_spike_damage = new System.Windows.Forms.TextBox();
            lbl_spike_damage = new System.Windows.Forms.Label();
            txb_acid_damage = new System.Windows.Forms.TextBox();
            lbl_acid_damage = new System.Windows.Forms.Label();
            lbl_area = new System.Windows.Forms.Label();
            cbb_area_bank = new System.Windows.Forms.ComboBox();
            grp_more_data = new System.Windows.Forms.GroupBox();
            cbb_collision_table = new System.Windows.Forms.ComboBox();
            lbl_collision_table = new System.Windows.Forms.Label();
            cbb_solidity = new System.Windows.Forms.ComboBox();
            lbl_solidity_table = new System.Windows.Forms.Label();
            grp_misc_data = new System.Windows.Forms.GroupBox();
            txb_real_metroids = new System.Windows.Forms.TextBox();
            lbl_real_metroids = new System.Windows.Forms.Label();
            txb_metroids = new System.Windows.Forms.TextBox();
            txb_missiles = new System.Windows.Forms.TextBox();
            txb_max_missiles = new System.Windows.Forms.TextBox();
            txb_energy = new System.Windows.Forms.TextBox();
            txb_music = new System.Windows.Forms.TextBox();
            lbl_music = new System.Windows.Forms.Label();
            lbl_metroid_count = new System.Windows.Forms.Label();
            lbl_missiles = new System.Windows.Forms.Label();
            lbl_max_missiles = new System.Windows.Forms.Label();
            lbl_energy = new System.Windows.Forms.Label();
            grp_beams = new System.Windows.Forms.GroupBox();
            txb_beam_value = new System.Windows.Forms.TextBox();
            lbl_beam_value = new System.Windows.Forms.Label();
            rdb_power = new System.Windows.Forms.RadioButton();
            rdb_plasma = new System.Windows.Forms.RadioButton();
            rdb_spazer = new System.Windows.Forms.RadioButton();
            rdb_wave = new System.Windows.Forms.RadioButton();
            rdb_ice = new System.Windows.Forms.RadioButton();
            grp_items = new System.Windows.Forms.GroupBox();
            chb_undefined = new System.Windows.Forms.CheckBox();
            chb_screw = new System.Windows.Forms.CheckBox();
            chb_space_jump = new System.Windows.Forms.CheckBox();
            chb_varia = new System.Windows.Forms.CheckBox();
            chb_spring = new System.Windows.Forms.CheckBox();
            chb_hijump = new System.Windows.Forms.CheckBox();
            chb_spider = new System.Windows.Forms.CheckBox();
            chb_bombs = new System.Windows.Forms.CheckBox();
            menu = new System.Windows.Forms.ToolStrip();
            tls_advanced = new System.Windows.Forms.ToolStripDropDownButton();
            btn_advanced = new System.Windows.Forms.ToolStripMenuItem();
            tlt_bank_tip = new System.Windows.Forms.ToolTip(components);
            pnl_main.SuspendLayout();
            grp_testROM.SuspendLayout();
            grp_position.SuspendLayout();
            grp_cam.SuspendLayout();
            grp_samus.SuspendLayout();
            grp_level_data.SuspendLayout();
            grp_graphics.SuspendLayout();
            grp_misc.SuspendLayout();
            grp_more_data.SuspendLayout();
            grp_misc_data.SuspendLayout();
            grp_beams.SuspendLayout();
            grp_items.SuspendLayout();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 436);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(649, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // pnl_main
            // 
            pnl_main.AutoScroll = true;
            pnl_main.Controls.Add(grp_testROM);
            pnl_main.Controls.Add(menu);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(6);
            pnl_main.Size = new System.Drawing.Size(649, 436);
            pnl_main.TabIndex = 7;
            // 
            // grp_testROM
            // 
            grp_testROM.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            grp_testROM.Controls.Add(chb_debug_menu);
            grp_testROM.Controls.Add(btn_set_savegame);
            grp_testROM.Controls.Add(btn_test);
            grp_testROM.Controls.Add(grp_position);
            grp_testROM.Controls.Add(grp_level_data);
            grp_testROM.Controls.Add(grp_misc_data);
            grp_testROM.Controls.Add(grp_beams);
            grp_testROM.Controls.Add(grp_items);
            grp_testROM.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_testROM.Location = new System.Drawing.Point(6, 31);
            grp_testROM.Name = "grp_testROM";
            grp_testROM.Size = new System.Drawing.Size(637, 399);
            grp_testROM.TabIndex = 7;
            grp_testROM.TabStop = false;
            grp_testROM.Text = "Test ROM";
            // 
            // chb_debug_menu
            // 
            chb_debug_menu.AutoSize = true;
            chb_debug_menu.Location = new System.Drawing.Point(540, 297);
            chb_debug_menu.Name = "chb_debug_menu";
            chb_debug_menu.Size = new System.Drawing.Size(95, 34);
            chb_debug_menu.TabIndex = 8;
            chb_debug_menu.Text = "Include\r\nDebug Menu";
            chb_debug_menu.UseVisualStyleBackColor = true;
            chb_debug_menu.CheckedChanged += chb_debug_menu_CheckedChanged;
            // 
            // btn_set_savegame
            // 
            btn_set_savegame.Location = new System.Drawing.Point(540, 368);
            btn_set_savegame.Name = "btn_set_savegame";
            btn_set_savegame.Size = new System.Drawing.Size(89, 23);
            btn_set_savegame.TabIndex = 7;
            btn_set_savegame.Text = "Set as start";
            tlt_bank_tip.SetToolTip(btn_set_savegame, "This will save the current values onto\r\nthe initial save file!");
            btn_set_savegame.UseVisualStyleBackColor = true;
            btn_set_savegame.Click += btn_set_savegame_Click;
            // 
            // btn_test
            // 
            btn_test.Location = new System.Drawing.Point(540, 339);
            btn_test.Name = "btn_test";
            btn_test.Size = new System.Drawing.Size(89, 23);
            btn_test.TabIndex = 6;
            btn_test.Text = "Test ROM";
            btn_test.UseVisualStyleBackColor = true;
            btn_test.Click += btn_test_Click;
            // 
            // grp_position
            // 
            grp_position.Controls.Add(grp_cam);
            grp_position.Controls.Add(grp_samus);
            grp_position.Location = new System.Drawing.Point(382, 22);
            grp_position.Name = "grp_position";
            grp_position.Size = new System.Drawing.Size(247, 226);
            grp_position.TabIndex = 0;
            grp_position.TabStop = false;
            grp_position.Text = "Position";
            // 
            // grp_cam
            // 
            grp_cam.Controls.Add(txb_cam_y);
            grp_cam.Controls.Add(txb_cam_x);
            grp_cam.Controls.Add(txb_cam_screen_y);
            grp_cam.Controls.Add(lbl_cam_y);
            grp_cam.Controls.Add(lbl_cam_x);
            grp_cam.Controls.Add(txb_cam_screen_x);
            grp_cam.Controls.Add(lbl_cam_screen_x);
            grp_cam.Controls.Add(lbl_cam_screen_y);
            grp_cam.Location = new System.Drawing.Point(126, 22);
            grp_cam.Name = "grp_cam";
            grp_cam.Size = new System.Drawing.Size(114, 198);
            grp_cam.TabIndex = 8;
            grp_cam.TabStop = false;
            grp_cam.Text = "Camera";
            // 
            // txb_cam_y
            // 
            txb_cam_y.Location = new System.Drawing.Point(67, 112);
            txb_cam_y.Name = "txb_cam_y";
            txb_cam_y.Size = new System.Drawing.Size(40, 23);
            txb_cam_y.TabIndex = 7;
            txb_cam_y.TextChanged += txb_cam_y_TextChanged;
            txb_cam_y.Leave += txb_leave;
            // 
            // txb_cam_x
            // 
            txb_cam_x.Location = new System.Drawing.Point(67, 83);
            txb_cam_x.Name = "txb_cam_x";
            txb_cam_x.Size = new System.Drawing.Size(40, 23);
            txb_cam_x.TabIndex = 6;
            txb_cam_x.TextChanged += txb_cam_x_TextChanged;
            txb_cam_x.Leave += txb_leave;
            // 
            // txb_cam_screen_y
            // 
            txb_cam_screen_y.Location = new System.Drawing.Point(67, 54);
            txb_cam_screen_y.Name = "txb_cam_screen_y";
            txb_cam_screen_y.Size = new System.Drawing.Size(40, 23);
            txb_cam_screen_y.TabIndex = 5;
            txb_cam_screen_y.TextChanged += txb_cam_screen_y_TextChanged;
            txb_cam_screen_y.Leave += txb_leave;
            // 
            // lbl_cam_y
            // 
            lbl_cam_y.AutoSize = true;
            lbl_cam_y.Location = new System.Drawing.Point(6, 115);
            lbl_cam_y.Name = "lbl_cam_y";
            lbl_cam_y.Size = new System.Drawing.Size(17, 15);
            lbl_cam_y.TabIndex = 3;
            lbl_cam_y.Text = "Y:";
            // 
            // lbl_cam_x
            // 
            lbl_cam_x.AutoSize = true;
            lbl_cam_x.Location = new System.Drawing.Point(6, 86);
            lbl_cam_x.Name = "lbl_cam_x";
            lbl_cam_x.Size = new System.Drawing.Size(17, 15);
            lbl_cam_x.TabIndex = 2;
            lbl_cam_x.Text = "X:";
            // 
            // txb_cam_screen_x
            // 
            txb_cam_screen_x.Location = new System.Drawing.Point(67, 25);
            txb_cam_screen_x.Name = "txb_cam_screen_x";
            txb_cam_screen_x.Size = new System.Drawing.Size(40, 23);
            txb_cam_screen_x.TabIndex = 4;
            txb_cam_screen_x.TextChanged += txb_cam_screen_x_TextChanged;
            txb_cam_screen_x.Leave += txb_leave;
            // 
            // lbl_cam_screen_x
            // 
            lbl_cam_screen_x.AutoSize = true;
            lbl_cam_screen_x.Location = new System.Drawing.Point(6, 28);
            lbl_cam_screen_x.Name = "lbl_cam_screen_x";
            lbl_cam_screen_x.Size = new System.Drawing.Size(55, 15);
            lbl_cam_screen_x.TabIndex = 0;
            lbl_cam_screen_x.Text = "Screen X:";
            // 
            // lbl_cam_screen_y
            // 
            lbl_cam_screen_y.AutoSize = true;
            lbl_cam_screen_y.Location = new System.Drawing.Point(6, 57);
            lbl_cam_screen_y.Name = "lbl_cam_screen_y";
            lbl_cam_screen_y.Size = new System.Drawing.Size(55, 15);
            lbl_cam_screen_y.TabIndex = 1;
            lbl_cam_screen_y.Text = "Screen Y:";
            // 
            // grp_samus
            // 
            grp_samus.Controls.Add(txb_sam_y);
            grp_samus.Controls.Add(txb_sam_x);
            grp_samus.Controls.Add(txb_sam_screen_y);
            grp_samus.Controls.Add(lbl_samus_y);
            grp_samus.Controls.Add(lbl_samus_x);
            grp_samus.Controls.Add(txb_sam_screen_x);
            grp_samus.Controls.Add(lbl_samus_screen_x);
            grp_samus.Controls.Add(lbl_samus_screen_y);
            grp_samus.Location = new System.Drawing.Point(6, 22);
            grp_samus.Name = "grp_samus";
            grp_samus.Size = new System.Drawing.Size(114, 198);
            grp_samus.TabIndex = 0;
            grp_samus.TabStop = false;
            grp_samus.Text = "Samus";
            // 
            // txb_sam_y
            // 
            txb_sam_y.Location = new System.Drawing.Point(67, 112);
            txb_sam_y.Name = "txb_sam_y";
            txb_sam_y.Size = new System.Drawing.Size(40, 23);
            txb_sam_y.TabIndex = 7;
            txb_sam_y.TextChanged += txb_sam_y_TextChanged;
            txb_sam_y.Leave += txb_leave;
            // 
            // txb_sam_x
            // 
            txb_sam_x.Location = new System.Drawing.Point(67, 83);
            txb_sam_x.Name = "txb_sam_x";
            txb_sam_x.Size = new System.Drawing.Size(40, 23);
            txb_sam_x.TabIndex = 6;
            txb_sam_x.TextChanged += txb_sam_x_TextChanged;
            txb_sam_x.Leave += txb_leave;
            // 
            // txb_sam_screen_y
            // 
            txb_sam_screen_y.Location = new System.Drawing.Point(67, 54);
            txb_sam_screen_y.Name = "txb_sam_screen_y";
            txb_sam_screen_y.Size = new System.Drawing.Size(40, 23);
            txb_sam_screen_y.TabIndex = 5;
            txb_sam_screen_y.TextChanged += txb_sam_screen_y_TextChanged;
            txb_sam_screen_y.Leave += txb_leave;
            // 
            // lbl_samus_y
            // 
            lbl_samus_y.AutoSize = true;
            lbl_samus_y.Location = new System.Drawing.Point(6, 115);
            lbl_samus_y.Name = "lbl_samus_y";
            lbl_samus_y.Size = new System.Drawing.Size(17, 15);
            lbl_samus_y.TabIndex = 3;
            lbl_samus_y.Text = "Y:";
            // 
            // lbl_samus_x
            // 
            lbl_samus_x.AutoSize = true;
            lbl_samus_x.Location = new System.Drawing.Point(6, 86);
            lbl_samus_x.Name = "lbl_samus_x";
            lbl_samus_x.Size = new System.Drawing.Size(17, 15);
            lbl_samus_x.TabIndex = 2;
            lbl_samus_x.Text = "X:";
            // 
            // txb_sam_screen_x
            // 
            txb_sam_screen_x.Location = new System.Drawing.Point(67, 25);
            txb_sam_screen_x.Name = "txb_sam_screen_x";
            txb_sam_screen_x.Size = new System.Drawing.Size(40, 23);
            txb_sam_screen_x.TabIndex = 4;
            txb_sam_screen_x.TextChanged += txb_sam_screen_x_TextChanged;
            txb_sam_screen_x.Leave += txb_leave;
            // 
            // lbl_samus_screen_x
            // 
            lbl_samus_screen_x.AutoSize = true;
            lbl_samus_screen_x.Location = new System.Drawing.Point(6, 28);
            lbl_samus_screen_x.Name = "lbl_samus_screen_x";
            lbl_samus_screen_x.Size = new System.Drawing.Size(55, 15);
            lbl_samus_screen_x.TabIndex = 0;
            lbl_samus_screen_x.Text = "Screen X:";
            // 
            // lbl_samus_screen_y
            // 
            lbl_samus_screen_y.AutoSize = true;
            lbl_samus_screen_y.Location = new System.Drawing.Point(6, 57);
            lbl_samus_screen_y.Name = "lbl_samus_screen_y";
            lbl_samus_screen_y.Size = new System.Drawing.Size(55, 15);
            lbl_samus_screen_y.TabIndex = 1;
            lbl_samus_screen_y.Text = "Screen Y:";
            // 
            // grp_level_data
            // 
            grp_level_data.Controls.Add(grp_graphics);
            grp_level_data.Controls.Add(grp_misc);
            grp_level_data.Controls.Add(grp_more_data);
            grp_level_data.Location = new System.Drawing.Point(6, 254);
            grp_level_data.Name = "grp_level_data";
            grp_level_data.Size = new System.Drawing.Size(528, 137);
            grp_level_data.TabIndex = 5;
            grp_level_data.TabStop = false;
            grp_level_data.Text = "Advanced";
            // 
            // grp_graphics
            // 
            grp_graphics.Controls.Add(tls_tileset_input);
            grp_graphics.Controls.Add(lbl_sprite_graphics);
            grp_graphics.Controls.Add(txb_sprite_graphics);
            grp_graphics.Location = new System.Drawing.Point(6, 22);
            grp_graphics.Name = "grp_graphics";
            grp_graphics.Size = new System.Drawing.Size(198, 109);
            grp_graphics.TabIndex = 9;
            grp_graphics.TabStop = false;
            grp_graphics.Text = "Graphics";
            // 
            // tls_tileset_input
            // 
            tls_tileset_input.AutoSize = true;
            tls_tileset_input.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tls_tileset_input.BackColor = System.Drawing.SystemColors.Control;
            tls_tileset_input.ForceOffsets = false;
            tls_tileset_input.GraphicsOffset = null;
            tls_tileset_input.Location = new System.Drawing.Point(6, 50);
            tls_tileset_input.Margin = new System.Windows.Forms.Padding(0);
            tls_tileset_input.MetatilePointer = null;
            tls_tileset_input.MetatileTable = 0;
            tls_tileset_input.Name = "tls_tileset_input";
            tls_tileset_input.onDataChanged = null;
            tls_tileset_input.SelectedTileset = null;
            tls_tileset_input.Size = new System.Drawing.Size(186, 52);
            tls_tileset_input.TabIndex = 4;
            tls_tileset_input.DataChanged += tls_tileset_input_DataChanged;
            // 
            // lbl_sprite_graphics
            // 
            lbl_sprite_graphics.AutoSize = true;
            lbl_sprite_graphics.Location = new System.Drawing.Point(6, 24);
            lbl_sprite_graphics.Name = "lbl_sprite_graphics";
            lbl_sprite_graphics.Size = new System.Drawing.Size(124, 15);
            lbl_sprite_graphics.TabIndex = 0;
            lbl_sprite_graphics.Text = "Sprite Graphics Offset:";
            tlt_bank_tip.SetToolTip(lbl_sprite_graphics, "Sprite graphics will always get loaded from Bank 6.\r\nThe offset is the relative offset in Bank 6!");
            // 
            // txb_sprite_graphics
            // 
            txb_sprite_graphics.Anchor = System.Windows.Forms.AnchorStyles.Right;
            txb_sprite_graphics.Location = new System.Drawing.Point(137, 21);
            txb_sprite_graphics.Name = "txb_sprite_graphics";
            txb_sprite_graphics.Size = new System.Drawing.Size(55, 23);
            txb_sprite_graphics.TabIndex = 1;
            txb_sprite_graphics.Text = "0x7420";
            tlt_bank_tip.SetToolTip(txb_sprite_graphics, "Sprite Graphics will always be loaded from Bank 8!\r\n");
            txb_sprite_graphics.TextChanged += txb_sprite_graphics_TextChanged;
            txb_sprite_graphics.Leave += txb_leave;
            // 
            // grp_misc
            // 
            grp_misc.Controls.Add(txb_spike_damage);
            grp_misc.Controls.Add(lbl_spike_damage);
            grp_misc.Controls.Add(txb_acid_damage);
            grp_misc.Controls.Add(lbl_acid_damage);
            grp_misc.Controls.Add(lbl_area);
            grp_misc.Controls.Add(cbb_area_bank);
            grp_misc.Location = new System.Drawing.Point(375, 22);
            grp_misc.Name = "grp_misc";
            grp_misc.Size = new System.Drawing.Size(147, 109);
            grp_misc.TabIndex = 8;
            grp_misc.TabStop = false;
            grp_misc.Text = "Miscellaneous";
            // 
            // txb_spike_damage
            // 
            txb_spike_damage.Location = new System.Drawing.Point(98, 74);
            txb_spike_damage.Name = "txb_spike_damage";
            txb_spike_damage.Size = new System.Drawing.Size(42, 23);
            txb_spike_damage.TabIndex = 10;
            txb_spike_damage.TextChanged += txb_spike_damage_TextChanged;
            txb_spike_damage.Leave += txb_leave;
            // 
            // lbl_spike_damage
            // 
            lbl_spike_damage.AutoSize = true;
            lbl_spike_damage.Location = new System.Drawing.Point(7, 77);
            lbl_spike_damage.Name = "lbl_spike_damage";
            lbl_spike_damage.Size = new System.Drawing.Size(84, 15);
            lbl_spike_damage.TabIndex = 9;
            lbl_spike_damage.Text = "Spike damage:";
            // 
            // txb_acid_damage
            // 
            txb_acid_damage.Location = new System.Drawing.Point(98, 45);
            txb_acid_damage.Name = "txb_acid_damage";
            txb_acid_damage.Size = new System.Drawing.Size(42, 23);
            txb_acid_damage.TabIndex = 8;
            txb_acid_damage.TextChanged += txb_acid_damage_TextChanged;
            txb_acid_damage.Leave += txb_leave;
            // 
            // lbl_acid_damage
            // 
            lbl_acid_damage.AutoSize = true;
            lbl_acid_damage.Location = new System.Drawing.Point(6, 48);
            lbl_acid_damage.Name = "lbl_acid_damage";
            lbl_acid_damage.Size = new System.Drawing.Size(80, 15);
            lbl_acid_damage.TabIndex = 7;
            lbl_acid_damage.Text = "Acid damage:";
            // 
            // lbl_area
            // 
            lbl_area.AutoSize = true;
            lbl_area.Location = new System.Drawing.Point(6, 19);
            lbl_area.Name = "lbl_area";
            lbl_area.Size = new System.Drawing.Size(34, 15);
            lbl_area.TabIndex = 5;
            lbl_area.Text = "Area:";
            // 
            // cbb_area_bank
            // 
            cbb_area_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_area_bank.FormattingEnabled = true;
            cbb_area_bank.Items.AddRange(new object[] { "9", "A", "B", "C", "D", "E", "F" });
            cbb_area_bank.Location = new System.Drawing.Point(98, 16);
            cbb_area_bank.Name = "cbb_area_bank";
            cbb_area_bank.Size = new System.Drawing.Size(42, 23);
            cbb_area_bank.TabIndex = 6;
            cbb_area_bank.SelectedIndexChanged += cbb_area_bank_SelectedIndexChanged;
            // 
            // grp_more_data
            // 
            grp_more_data.Controls.Add(cbb_collision_table);
            grp_more_data.Controls.Add(lbl_collision_table);
            grp_more_data.Controls.Add(cbb_solidity);
            grp_more_data.Controls.Add(lbl_solidity_table);
            grp_more_data.Location = new System.Drawing.Point(210, 22);
            grp_more_data.Name = "grp_more_data";
            grp_more_data.Size = new System.Drawing.Size(159, 109);
            grp_more_data.TabIndex = 7;
            grp_more_data.TabStop = false;
            grp_more_data.Text = "Collision and Sprites";
            // 
            // cbb_collision_table
            // 
            cbb_collision_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_collision_table.FormattingEnabled = true;
            cbb_collision_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_collision_table.Location = new System.Drawing.Point(101, 21);
            cbb_collision_table.Name = "cbb_collision_table";
            cbb_collision_table.Size = new System.Drawing.Size(49, 23);
            cbb_collision_table.TabIndex = 9;
            cbb_collision_table.SelectedIndexChanged += cbb_collision_table_SelectedIndexChanged;
            // 
            // lbl_collision_table
            // 
            lbl_collision_table.AutoSize = true;
            lbl_collision_table.Location = new System.Drawing.Point(6, 24);
            lbl_collision_table.Name = "lbl_collision_table";
            lbl_collision_table.Size = new System.Drawing.Size(86, 15);
            lbl_collision_table.TabIndex = 8;
            lbl_collision_table.Text = "Collision Table:";
            tlt_bank_tip.SetToolTip(lbl_collision_table, "Sprite graphics will always get loaded from Bank 6.\r\nThe offset is the relative offset in Bank 6!");
            // 
            // cbb_solidity
            // 
            cbb_solidity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_solidity.FormattingEnabled = true;
            cbb_solidity.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_solidity.Location = new System.Drawing.Point(101, 50);
            cbb_solidity.Name = "cbb_solidity";
            cbb_solidity.Size = new System.Drawing.Size(49, 23);
            cbb_solidity.TabIndex = 7;
            cbb_solidity.SelectedIndexChanged += cbb_solidity_SelectedIndexChanged;
            // 
            // lbl_solidity_table
            // 
            lbl_solidity_table.AutoSize = true;
            lbl_solidity_table.Location = new System.Drawing.Point(6, 53);
            lbl_solidity_table.Name = "lbl_solidity_table";
            lbl_solidity_table.Size = new System.Drawing.Size(89, 15);
            lbl_solidity_table.TabIndex = 2;
            lbl_solidity_table.Text = "Solidity Indices:";
            tlt_bank_tip.SetToolTip(lbl_solidity_table, "Sprite graphics will always get loaded from Bank 6.\r\nThe offset is the relative offset in Bank 6!");
            // 
            // grp_misc_data
            // 
            grp_misc_data.Controls.Add(txb_real_metroids);
            grp_misc_data.Controls.Add(lbl_real_metroids);
            grp_misc_data.Controls.Add(txb_metroids);
            grp_misc_data.Controls.Add(txb_missiles);
            grp_misc_data.Controls.Add(txb_max_missiles);
            grp_misc_data.Controls.Add(txb_energy);
            grp_misc_data.Controls.Add(txb_music);
            grp_misc_data.Controls.Add(lbl_music);
            grp_misc_data.Controls.Add(lbl_metroid_count);
            grp_misc_data.Controls.Add(lbl_missiles);
            grp_misc_data.Controls.Add(lbl_max_missiles);
            grp_misc_data.Controls.Add(lbl_energy);
            grp_misc_data.Location = new System.Drawing.Point(234, 22);
            grp_misc_data.Name = "grp_misc_data";
            grp_misc_data.Size = new System.Drawing.Size(141, 226);
            grp_misc_data.TabIndex = 2;
            grp_misc_data.TabStop = false;
            grp_misc_data.Text = "Miscellaneous";
            // 
            // txb_real_metroids
            // 
            txb_real_metroids.Enabled = false;
            txb_real_metroids.Location = new System.Drawing.Point(92, 195);
            txb_real_metroids.Name = "txb_real_metroids";
            txb_real_metroids.Size = new System.Drawing.Size(40, 23);
            txb_real_metroids.TabIndex = 18;
            txb_real_metroids.TextChanged += txb_real_metroids_TextChanged;
            txb_real_metroids.Leave += txb_leave;
            // 
            // lbl_real_metroids
            // 
            lbl_real_metroids.AutoSize = true;
            lbl_real_metroids.Enabled = false;
            lbl_real_metroids.Location = new System.Drawing.Point(6, 198);
            lbl_real_metroids.Name = "lbl_real_metroids";
            lbl_real_metroids.Size = new System.Drawing.Size(82, 15);
            lbl_real_metroids.TabIndex = 17;
            lbl_real_metroids.Text = "Real Metroids:";
            // 
            // txb_metroids
            // 
            txb_metroids.Location = new System.Drawing.Point(92, 107);
            txb_metroids.Name = "txb_metroids";
            txb_metroids.Size = new System.Drawing.Size(40, 23);
            txb_metroids.TabIndex = 15;
            tlt_bank_tip.SetToolTip(txb_metroids, "These values are BCD (Binary Coded Decimal). \r\nThis Means that the values A-F dont have a \r\nproper value and 0x10=10.");
            txb_metroids.TextChanged += num_metroid_count_ValueChanged;
            txb_metroids.Leave += txb_leave;
            // 
            // txb_missiles
            // 
            txb_missiles.Location = new System.Drawing.Point(92, 78);
            txb_missiles.Name = "txb_missiles";
            txb_missiles.Size = new System.Drawing.Size(40, 23);
            txb_missiles.TabIndex = 14;
            tlt_bank_tip.SetToolTip(txb_missiles, "These values are BCD (Binary Coded Decimal). \r\nThis Means that the values A-F dont have a \r\nproper value and 0x10=10.\r\n");
            txb_missiles.TextChanged += num_missiles_ValueChanged;
            txb_missiles.Leave += txb_leave;
            // 
            // txb_max_missiles
            // 
            txb_max_missiles.Location = new System.Drawing.Point(92, 49);
            txb_max_missiles.Name = "txb_max_missiles";
            txb_max_missiles.Size = new System.Drawing.Size(40, 23);
            txb_max_missiles.TabIndex = 13;
            tlt_bank_tip.SetToolTip(txb_max_missiles, "These values are BCD (Binary Coded Decimal). \r\nThis Means that the values A-F dont have a \r\nproper value and 0x10=10.\r\n");
            txb_max_missiles.TextChanged += num_max_missiles_ValueChanged;
            txb_max_missiles.Leave += txb_leave;
            // 
            // txb_energy
            // 
            txb_energy.Location = new System.Drawing.Point(92, 20);
            txb_energy.Name = "txb_energy";
            txb_energy.Size = new System.Drawing.Size(40, 23);
            txb_energy.TabIndex = 12;
            tlt_bank_tip.SetToolTip(txb_energy, "These values are BCD (Binary Coded Decimal). \r\nThis Means that the values A-F dont have a \r\nproper value and 0x10=10.\r\n");
            txb_energy.TextChanged += num_energy_ValueChanged;
            txb_energy.Leave += txb_leave;
            // 
            // txb_music
            // 
            txb_music.Location = new System.Drawing.Point(92, 136);
            txb_music.Name = "txb_music";
            txb_music.Size = new System.Drawing.Size(40, 23);
            txb_music.TabIndex = 8;
            txb_music.TextChanged += txb_music_TextChanged;
            txb_music.Leave += txb_leave;
            // 
            // lbl_music
            // 
            lbl_music.AutoSize = true;
            lbl_music.Location = new System.Drawing.Point(6, 139);
            lbl_music.Name = "lbl_music";
            lbl_music.Size = new System.Drawing.Size(42, 15);
            lbl_music.TabIndex = 7;
            lbl_music.Text = "Music:";
            // 
            // lbl_metroid_count
            // 
            lbl_metroid_count.AutoSize = true;
            lbl_metroid_count.Location = new System.Drawing.Point(6, 110);
            lbl_metroid_count.Name = "lbl_metroid_count";
            lbl_metroid_count.Size = new System.Drawing.Size(57, 15);
            lbl_metroid_count.TabIndex = 11;
            lbl_metroid_count.Text = "Metroids:";
            // 
            // lbl_missiles
            // 
            lbl_missiles.AutoSize = true;
            lbl_missiles.Location = new System.Drawing.Point(6, 81);
            lbl_missiles.Name = "lbl_missiles";
            lbl_missiles.Size = new System.Drawing.Size(51, 15);
            lbl_missiles.TabIndex = 5;
            lbl_missiles.Text = "Missiles:";
            // 
            // lbl_max_missiles
            // 
            lbl_max_missiles.AutoSize = true;
            lbl_max_missiles.Location = new System.Drawing.Point(6, 52);
            lbl_max_missiles.Name = "lbl_max_missiles";
            lbl_max_missiles.Size = new System.Drawing.Size(80, 15);
            lbl_max_missiles.TabIndex = 3;
            lbl_max_missiles.Text = "Max. Missiles:";
            // 
            // lbl_energy
            // 
            lbl_energy.AutoSize = true;
            lbl_energy.Location = new System.Drawing.Point(6, 23);
            lbl_energy.Name = "lbl_energy";
            lbl_energy.Size = new System.Drawing.Size(46, 15);
            lbl_energy.TabIndex = 1;
            lbl_energy.Text = "Energy:";
            // 
            // grp_beams
            // 
            grp_beams.Controls.Add(txb_beam_value);
            grp_beams.Controls.Add(lbl_beam_value);
            grp_beams.Controls.Add(rdb_power);
            grp_beams.Controls.Add(rdb_plasma);
            grp_beams.Controls.Add(rdb_spazer);
            grp_beams.Controls.Add(rdb_wave);
            grp_beams.Controls.Add(rdb_ice);
            grp_beams.Location = new System.Drawing.Point(120, 22);
            grp_beams.Name = "grp_beams";
            grp_beams.Size = new System.Drawing.Size(108, 226);
            grp_beams.TabIndex = 1;
            grp_beams.TabStop = false;
            grp_beams.Text = "Beams";
            // 
            // txb_beam_value
            // 
            txb_beam_value.Enabled = false;
            txb_beam_value.Location = new System.Drawing.Point(57, 195);
            txb_beam_value.Name = "txb_beam_value";
            txb_beam_value.Size = new System.Drawing.Size(40, 23);
            txb_beam_value.TabIndex = 16;
            txb_beam_value.TextChanged += txb_beam_value_TextChanged;
            txb_beam_value.Leave += txb_leave;
            // 
            // lbl_beam_value
            // 
            lbl_beam_value.AutoSize = true;
            lbl_beam_value.Enabled = false;
            lbl_beam_value.Location = new System.Drawing.Point(6, 198);
            lbl_beam_value.Name = "lbl_beam_value";
            lbl_beam_value.Size = new System.Drawing.Size(38, 15);
            lbl_beam_value.TabIndex = 5;
            lbl_beam_value.Text = "Value:";
            // 
            // rdb_power
            // 
            rdb_power.AutoSize = true;
            rdb_power.Checked = true;
            rdb_power.Location = new System.Drawing.Point(6, 21);
            rdb_power.Name = "rdb_power";
            rdb_power.Size = new System.Drawing.Size(91, 19);
            rdb_power.TabIndex = 4;
            rdb_power.TabStop = true;
            rdb_power.Text = "Power Beam";
            rdb_power.UseVisualStyleBackColor = true;
            rdb_power.CheckedChanged += rdb_ice_CheckedChanged;
            // 
            // rdb_plasma
            // 
            rdb_plasma.AutoSize = true;
            rdb_plasma.Location = new System.Drawing.Point(6, 121);
            rdb_plasma.Name = "rdb_plasma";
            rdb_plasma.Size = new System.Drawing.Size(96, 19);
            rdb_plasma.TabIndex = 3;
            rdb_plasma.Text = "Plasma Beam";
            rdb_plasma.UseVisualStyleBackColor = true;
            rdb_plasma.CheckedChanged += rdb_ice_CheckedChanged;
            // 
            // rdb_spazer
            // 
            rdb_spazer.AutoSize = true;
            rdb_spazer.Location = new System.Drawing.Point(6, 96);
            rdb_spazer.Name = "rdb_spazer";
            rdb_spazer.Size = new System.Drawing.Size(92, 19);
            rdb_spazer.TabIndex = 2;
            rdb_spazer.Text = "Spazer Beam";
            rdb_spazer.UseVisualStyleBackColor = true;
            rdb_spazer.CheckedChanged += rdb_ice_CheckedChanged;
            // 
            // rdb_wave
            // 
            rdb_wave.AutoSize = true;
            rdb_wave.Location = new System.Drawing.Point(6, 71);
            rdb_wave.Name = "rdb_wave";
            rdb_wave.Size = new System.Drawing.Size(87, 19);
            rdb_wave.TabIndex = 1;
            rdb_wave.Text = "Wave Beam";
            rdb_wave.UseVisualStyleBackColor = true;
            rdb_wave.CheckedChanged += rdb_ice_CheckedChanged;
            // 
            // rdb_ice
            // 
            rdb_ice.AutoSize = true;
            rdb_ice.Location = new System.Drawing.Point(6, 46);
            rdb_ice.Name = "rdb_ice";
            rdb_ice.Size = new System.Drawing.Size(73, 19);
            rdb_ice.TabIndex = 0;
            rdb_ice.Text = "Ice Beam";
            rdb_ice.UseVisualStyleBackColor = true;
            rdb_ice.CheckedChanged += rdb_ice_CheckedChanged;
            // 
            // grp_items
            // 
            grp_items.Controls.Add(chb_undefined);
            grp_items.Controls.Add(chb_screw);
            grp_items.Controls.Add(chb_space_jump);
            grp_items.Controls.Add(chb_varia);
            grp_items.Controls.Add(chb_spring);
            grp_items.Controls.Add(chb_hijump);
            grp_items.Controls.Add(chb_spider);
            grp_items.Controls.Add(chb_bombs);
            grp_items.Location = new System.Drawing.Point(6, 22);
            grp_items.Name = "grp_items";
            grp_items.Size = new System.Drawing.Size(108, 226);
            grp_items.TabIndex = 0;
            grp_items.TabStop = false;
            grp_items.Text = "Items";
            // 
            // chb_undefined
            // 
            chb_undefined.AutoSize = true;
            chb_undefined.Enabled = false;
            chb_undefined.Location = new System.Drawing.Point(6, 197);
            chb_undefined.Name = "chb_undefined";
            chb_undefined.Size = new System.Drawing.Size(81, 19);
            chb_undefined.TabIndex = 7;
            chb_undefined.Text = "Undefined";
            chb_undefined.UseVisualStyleBackColor = true;
            chb_undefined.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_screw
            // 
            chb_screw.AutoSize = true;
            chb_screw.Location = new System.Drawing.Point(6, 172);
            chb_screw.Name = "chb_screw";
            chb_screw.Size = new System.Drawing.Size(94, 19);
            chb_screw.TabIndex = 6;
            chb_screw.Text = "Screw Attack";
            chb_screw.UseVisualStyleBackColor = true;
            chb_screw.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_space_jump
            // 
            chb_space_jump.AutoSize = true;
            chb_space_jump.Location = new System.Drawing.Point(6, 147);
            chb_space_jump.Name = "chb_space_jump";
            chb_space_jump.Size = new System.Drawing.Size(89, 19);
            chb_space_jump.TabIndex = 5;
            chb_space_jump.Text = "Space Jump";
            chb_space_jump.UseVisualStyleBackColor = true;
            chb_space_jump.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_varia
            // 
            chb_varia.AutoSize = true;
            chb_varia.Location = new System.Drawing.Point(6, 122);
            chb_varia.Name = "chb_varia";
            chb_varia.Size = new System.Drawing.Size(74, 19);
            chb_varia.TabIndex = 4;
            chb_varia.Text = "Varia Suit";
            chb_varia.UseVisualStyleBackColor = true;
            chb_varia.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_spring
            // 
            chb_spring.AutoSize = true;
            chb_spring.Location = new System.Drawing.Point(6, 72);
            chb_spring.Name = "chb_spring";
            chb_spring.Size = new System.Drawing.Size(82, 19);
            chb_spring.TabIndex = 3;
            chb_spring.Text = "Spring Ball";
            chb_spring.UseVisualStyleBackColor = true;
            chb_spring.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_hijump
            // 
            chb_hijump.AutoSize = true;
            chb_hijump.Location = new System.Drawing.Point(6, 97);
            chb_hijump.Name = "chb_hijump";
            chb_hijump.Size = new System.Drawing.Size(72, 19);
            chb_hijump.TabIndex = 2;
            chb_hijump.Text = "Hi-Jump";
            chb_hijump.UseVisualStyleBackColor = true;
            chb_hijump.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_spider
            // 
            chb_spider.AutoSize = true;
            chb_spider.Location = new System.Drawing.Point(6, 47);
            chb_spider.Name = "chb_spider";
            chb_spider.Size = new System.Drawing.Size(81, 19);
            chb_spider.TabIndex = 1;
            chb_spider.Text = "Spider Ball";
            chb_spider.UseVisualStyleBackColor = true;
            chb_spider.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // chb_bombs
            // 
            chb_bombs.AutoSize = true;
            chb_bombs.Location = new System.Drawing.Point(6, 22);
            chb_bombs.Name = "chb_bombs";
            chb_bombs.Size = new System.Drawing.Size(63, 19);
            chb_bombs.TabIndex = 0;
            chb_bombs.Text = "Bombs";
            chb_bombs.UseVisualStyleBackColor = true;
            chb_bombs.CheckedChanged += chb_bombs_CheckedChanged;
            // 
            // menu
            // 
            menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tls_advanced });
            menu.Location = new System.Drawing.Point(6, 6);
            menu.Name = "menu";
            menu.Size = new System.Drawing.Size(637, 25);
            menu.TabIndex = 8;
            menu.Text = "toolStrip1";
            // 
            // tls_advanced
            // 
            tls_advanced.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            tls_advanced.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_advanced });
            tls_advanced.Image = (System.Drawing.Image)resources.GetObject("tls_advanced.Image");
            tls_advanced.ImageTransparentColor = System.Drawing.Color.Magenta;
            tls_advanced.Name = "tls_advanced";
            tls_advanced.Size = new System.Drawing.Size(73, 22);
            tls_advanced.Text = "Advanced";
            // 
            // btn_advanced
            // 
            btn_advanced.Name = "btn_advanced";
            btn_advanced.Size = new System.Drawing.Size(194, 22);
            btn_advanced.Text = "Enable Special Settings";
            btn_advanced.CheckedChanged += btn_advanced_CheckedChanged;
            btn_advanced.Click += btn_advanced_Click;
            // 
            // tlt_bank_tip
            // 
            tlt_bank_tip.AutoPopDelay = 0;
            tlt_bank_tip.InitialDelay = 550;
            tlt_bank_tip.ReshowDelay = 110;
            tlt_bank_tip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            tlt_bank_tip.ToolTipTitle = "INFO";
            tlt_bank_tip.UseFading = false;
            // 
            // TestRom
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(649, 458);
            Controls.Add(pnl_main);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "TestRom";
            Text = "Test ROM Settings";
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            grp_testROM.ResumeLayout(false);
            grp_testROM.PerformLayout();
            grp_position.ResumeLayout(false);
            grp_cam.ResumeLayout(false);
            grp_cam.PerformLayout();
            grp_samus.ResumeLayout(false);
            grp_samus.PerformLayout();
            grp_level_data.ResumeLayout(false);
            grp_graphics.ResumeLayout(false);
            grp_graphics.PerformLayout();
            grp_misc.ResumeLayout(false);
            grp_misc.PerformLayout();
            grp_more_data.ResumeLayout(false);
            grp_more_data.PerformLayout();
            grp_misc_data.ResumeLayout(false);
            grp_misc_data.PerformLayout();
            grp_beams.ResumeLayout(false);
            grp_beams.PerformLayout();
            grp_items.ResumeLayout(false);
            grp_items.PerformLayout();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.GroupBox grp_testROM;
        private System.Windows.Forms.GroupBox grp_items;
        private System.Windows.Forms.CheckBox chb_hijump;
        private System.Windows.Forms.CheckBox chb_spider;
        private System.Windows.Forms.CheckBox chb_bombs;
        private System.Windows.Forms.GroupBox grp_beams;
        private System.Windows.Forms.RadioButton rdb_plasma;
        private System.Windows.Forms.RadioButton rdb_spazer;
        private System.Windows.Forms.RadioButton rdb_wave;
        private System.Windows.Forms.RadioButton rdb_ice;
        private System.Windows.Forms.CheckBox chb_screw;
        private System.Windows.Forms.CheckBox chb_space_jump;
        private System.Windows.Forms.CheckBox chb_varia;
        private System.Windows.Forms.CheckBox chb_spring;
        private System.Windows.Forms.GroupBox grp_misc_data;
        private System.Windows.Forms.Label lbl_missiles;
        private System.Windows.Forms.Label lbl_max_missiles;
        private System.Windows.Forms.Label lbl_energy;
        private System.Windows.Forms.GroupBox grp_position;
        private System.Windows.Forms.GroupBox grp_cam;
        private System.Windows.Forms.TextBox txb_cam_y;
        private System.Windows.Forms.TextBox txb_cam_x;
        private System.Windows.Forms.TextBox txb_cam_screen_y;
        private System.Windows.Forms.Label lbl_cam_y;
        private System.Windows.Forms.Label lbl_cam_x;
        private System.Windows.Forms.TextBox txb_cam_screen_x;
        private System.Windows.Forms.Label lbl_cam_screen_x;
        private System.Windows.Forms.Label lbl_cam_screen_y;
        private System.Windows.Forms.GroupBox grp_samus;
        private System.Windows.Forms.TextBox txb_sam_y;
        private System.Windows.Forms.TextBox txb_sam_x;
        private System.Windows.Forms.TextBox txb_sam_screen_y;
        private System.Windows.Forms.Label lbl_samus_y;
        private System.Windows.Forms.Label lbl_samus_x;
        private System.Windows.Forms.TextBox txb_sam_screen_x;
        private System.Windows.Forms.Label lbl_samus_screen_x;
        private System.Windows.Forms.Label lbl_samus_screen_y;
        private System.Windows.Forms.GroupBox grp_level_data;
        private Controls.Other.TilesetInput tls_tileset_input;
        private System.Windows.Forms.GroupBox grp_more_data;
        private System.Windows.Forms.Label lbl_solidity_table;
        private System.Windows.Forms.ToolTip tlt_bank_tip;
        private System.Windows.Forms.TextBox txb_sprite_graphics;
        private System.Windows.Forms.Label lbl_sprite_graphics;
        private System.Windows.Forms.ComboBox cbb_area_bank;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.ComboBox cbb_solidity;
        private System.Windows.Forms.ComboBox cbb_collision_table;
        private System.Windows.Forms.Label lbl_collision_table;
        private System.Windows.Forms.GroupBox grp_misc;
        private System.Windows.Forms.TextBox txb_music;
        private System.Windows.Forms.Label lbl_music;
        private System.Windows.Forms.TextBox txb_spike_damage;
        private System.Windows.Forms.Label lbl_spike_damage;
        private System.Windows.Forms.TextBox txb_acid_damage;
        private System.Windows.Forms.Label lbl_acid_damage;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label lbl_metroid_count;
        private System.Windows.Forms.RadioButton rdb_power;
        private System.Windows.Forms.Button btn_set_savegame;
        private System.Windows.Forms.TextBox txb_metroids;
        private System.Windows.Forms.TextBox txb_missiles;
        private System.Windows.Forms.TextBox txb_max_missiles;
        private System.Windows.Forms.TextBox txb_energy;
        private System.Windows.Forms.GroupBox grp_graphics;
        private System.Windows.Forms.CheckBox chb_debug_menu;
        private System.Windows.Forms.ToolStrip menu;
        private System.Windows.Forms.ToolStripDropDownButton tls_advanced;
        private System.Windows.Forms.ToolStripMenuItem btn_advanced;
        private System.Windows.Forms.CheckBox chb_undefined;
        private System.Windows.Forms.TextBox txb_real_metroids;
        private System.Windows.Forms.Label lbl_real_metroids;
        private System.Windows.Forms.TextBox txb_beam_value;
        private System.Windows.Forms.Label lbl_beam_value;
    }
}