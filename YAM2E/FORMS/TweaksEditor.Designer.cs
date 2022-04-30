
namespace YAM2E.FORMS
{
    partial class TweaksEditor
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
            this.tabc_tweaks_editor = new System.Windows.Forms.TabControl();
            this.tab_twed_samus = new System.Windows.Forms.TabPage();
            this.grp_twed_samus_values = new System.Windows.Forms.GroupBox();
            this.lbl_tweak_air_speed = new System.Windows.Forms.Label();
            this.num_tweak_air_speed = new System.Windows.Forms.NumericUpDown();
            this.lbl_tweak_morph_speed = new System.Windows.Forms.Label();
            this.num_tweak_morph_speed = new System.Windows.Forms.NumericUpDown();
            this.lbl_tweak_samus_speed = new System.Windows.Forms.Label();
            this.num_tweak_samus_speed = new System.Windows.Forms.NumericUpDown();
            this.grp_twed_samus_checks = new System.Windows.Forms.GroupBox();
            this.chb_tweak_disable_health_alarm = new System.Windows.Forms.CheckBox();
            this.chb_tweak_center_samus = new System.Windows.Forms.CheckBox();
            this.tab_twed_weapons = new System.Windows.Forms.TabPage();
            this.grp_twed_weapons_values = new System.Windows.Forms.GroupBox();
            this.lbl_tweak_bomb_timer = new System.Windows.Forms.Label();
            this.num_tweak_bomb_timer = new System.Windows.Forms.NumericUpDown();
            this.grp_twed_weapons_checks = new System.Windows.Forms.GroupBox();
            this.chb_tweak_smooth_missile = new System.Windows.Forms.CheckBox();
            this.tab_twed_drops = new System.Windows.Forms.TabPage();
            this.grp_twed_drops_values = new System.Windows.Forms.GroupBox();
            this.lbl_tweak_missile_restore = new System.Windows.Forms.Label();
            this.num_tweak_missile_restore = new System.Windows.Forms.NumericUpDown();
            this.lbl_tweak_small_energy_amount = new System.Windows.Forms.Label();
            this.num_tweak_small_energy_amount = new System.Windows.Forms.NumericUpDown();
            this.lbl_tweak_large_energy_amount = new System.Windows.Forms.Label();
            this.num_tweak_amount_large_energy = new System.Windows.Forms.NumericUpDown();
            this.grp_twed_drops_checks = new System.Windows.Forms.GroupBox();
            this.chb_tweak_fanfare = new System.Windows.Forms.CheckBox();
            this.tab_twed_misc = new System.Windows.Forms.TabPage();
            this.grp_twed_misc_values = new System.Windows.Forms.GroupBox();
            this.lbl_tweak_missiles_hatch = new System.Windows.Forms.Label();
            this.num_tweak_missiles_hatch = new System.Windows.Forms.NumericUpDown();
            this.grp_twed_misc_checks = new System.Windows.Forms.GroupBox();
            this.chb_tweak_hatches_beam = new System.Windows.Forms.CheckBox();
            this.chb_tweak_music_plays_pause = new System.Windows.Forms.CheckBox();
            this.chb_tweak_debug_menu = new System.Windows.Forms.CheckBox();
            this.chb_tweak_infinite_spin = new System.Windows.Forms.CheckBox();
            this.btn_apply_tweaks = new System.Windows.Forms.Button();
            this.btn_close_tweaks = new System.Windows.Forms.Button();
            this.tabc_tweaks_editor.SuspendLayout();
            this.tab_twed_samus.SuspendLayout();
            this.grp_twed_samus_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_air_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_morph_speed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_samus_speed)).BeginInit();
            this.grp_twed_samus_checks.SuspendLayout();
            this.tab_twed_weapons.SuspendLayout();
            this.grp_twed_weapons_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_bomb_timer)).BeginInit();
            this.grp_twed_weapons_checks.SuspendLayout();
            this.tab_twed_drops.SuspendLayout();
            this.grp_twed_drops_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_missile_restore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_small_energy_amount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_amount_large_energy)).BeginInit();
            this.grp_twed_drops_checks.SuspendLayout();
            this.tab_twed_misc.SuspendLayout();
            this.grp_twed_misc_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_missiles_hatch)).BeginInit();
            this.grp_twed_misc_checks.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabc_tweaks_editor
            // 
            this.tabc_tweaks_editor.Controls.Add(this.tab_twed_samus);
            this.tabc_tweaks_editor.Controls.Add(this.tab_twed_weapons);
            this.tabc_tweaks_editor.Controls.Add(this.tab_twed_drops);
            this.tabc_tweaks_editor.Controls.Add(this.tab_twed_misc);
            this.tabc_tweaks_editor.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabc_tweaks_editor.Location = new System.Drawing.Point(0, 0);
            this.tabc_tweaks_editor.Name = "tabc_tweaks_editor";
            this.tabc_tweaks_editor.SelectedIndex = 0;
            this.tabc_tweaks_editor.Size = new System.Drawing.Size(296, 423);
            this.tabc_tweaks_editor.TabIndex = 0;
            // 
            // tab_twed_samus
            // 
            this.tab_twed_samus.Controls.Add(this.grp_twed_samus_values);
            this.tab_twed_samus.Controls.Add(this.grp_twed_samus_checks);
            this.tab_twed_samus.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_samus.Name = "tab_twed_samus";
            this.tab_twed_samus.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_samus.Size = new System.Drawing.Size(288, 395);
            this.tab_twed_samus.TabIndex = 0;
            this.tab_twed_samus.Text = "Samus";
            this.tab_twed_samus.UseVisualStyleBackColor = true;
            // 
            // grp_twed_samus_values
            // 
            this.grp_twed_samus_values.Controls.Add(this.lbl_tweak_air_speed);
            this.grp_twed_samus_values.Controls.Add(this.num_tweak_air_speed);
            this.grp_twed_samus_values.Controls.Add(this.lbl_tweak_morph_speed);
            this.grp_twed_samus_values.Controls.Add(this.num_tweak_morph_speed);
            this.grp_twed_samus_values.Controls.Add(this.lbl_tweak_samus_speed);
            this.grp_twed_samus_values.Controls.Add(this.num_tweak_samus_speed);
            this.grp_twed_samus_values.Location = new System.Drawing.Point(9, 138);
            this.grp_twed_samus_values.Name = "grp_twed_samus_values";
            this.grp_twed_samus_values.Size = new System.Drawing.Size(250, 150);
            this.grp_twed_samus_values.TabIndex = 1;
            this.grp_twed_samus_values.TabStop = false;
            this.grp_twed_samus_values.Text = "Values";
            // 
            // lbl_tweak_air_speed
            // 
            this.lbl_tweak_air_speed.AutoSize = true;
            this.lbl_tweak_air_speed.Location = new System.Drawing.Point(68, 53);
            this.lbl_tweak_air_speed.Name = "lbl_tweak_air_speed";
            this.lbl_tweak_air_speed.Size = new System.Drawing.Size(95, 15);
            this.lbl_tweak_air_speed.TabIndex = 5;
            this.lbl_tweak_air_speed.Text = "Samus\' air speed";
            // 
            // num_tweak_air_speed
            // 
            this.num_tweak_air_speed.Hexadecimal = true;
            this.num_tweak_air_speed.Location = new System.Drawing.Point(6, 51);
            this.num_tweak_air_speed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_air_speed.Name = "num_tweak_air_speed";
            this.num_tweak_air_speed.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_air_speed.TabIndex = 4;
            this.num_tweak_air_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lbl_tweak_morph_speed
            // 
            this.lbl_tweak_morph_speed.AutoSize = true;
            this.lbl_tweak_morph_speed.Location = new System.Drawing.Point(68, 82);
            this.lbl_tweak_morph_speed.Name = "lbl_tweak_morph_speed";
            this.lbl_tweak_morph_speed.Size = new System.Drawing.Size(136, 15);
            this.lbl_tweak_morph_speed.TabIndex = 3;
            this.lbl_tweak_morph_speed.Text = "Morph Ball rolling speed";
            // 
            // num_tweak_morph_speed
            // 
            this.num_tweak_morph_speed.Hexadecimal = true;
            this.num_tweak_morph_speed.Location = new System.Drawing.Point(6, 80);
            this.num_tweak_morph_speed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_morph_speed.Name = "num_tweak_morph_speed";
            this.num_tweak_morph_speed.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_morph_speed.TabIndex = 2;
            this.num_tweak_morph_speed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // lbl_tweak_samus_speed
            // 
            this.lbl_tweak_samus_speed.AutoSize = true;
            this.lbl_tweak_samus_speed.Location = new System.Drawing.Point(68, 24);
            this.lbl_tweak_samus_speed.Name = "lbl_tweak_samus_speed";
            this.lbl_tweak_samus_speed.Size = new System.Drawing.Size(124, 15);
            this.lbl_tweak_samus_speed.TabIndex = 1;
            this.lbl_tweak_samus_speed.Text = "Samus\' running speed";
            // 
            // num_tweak_samus_speed
            // 
            this.num_tweak_samus_speed.Hexadecimal = true;
            this.num_tweak_samus_speed.Location = new System.Drawing.Point(6, 22);
            this.num_tweak_samus_speed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_samus_speed.Name = "num_tweak_samus_speed";
            this.num_tweak_samus_speed.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_samus_speed.TabIndex = 0;
            this.num_tweak_samus_speed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // grp_twed_samus_checks
            // 
            this.grp_twed_samus_checks.Controls.Add(this.chb_tweak_disable_health_alarm);
            this.grp_twed_samus_checks.Controls.Add(this.chb_tweak_center_samus);
            this.grp_twed_samus_checks.Location = new System.Drawing.Point(9, 7);
            this.grp_twed_samus_checks.Name = "grp_twed_samus_checks";
            this.grp_twed_samus_checks.Size = new System.Drawing.Size(250, 125);
            this.grp_twed_samus_checks.TabIndex = 0;
            this.grp_twed_samus_checks.TabStop = false;
            this.grp_twed_samus_checks.Text = "Checks";
            // 
            // chb_tweak_disable_health_alarm
            // 
            this.chb_tweak_disable_health_alarm.AutoSize = true;
            this.chb_tweak_disable_health_alarm.Location = new System.Drawing.Point(6, 47);
            this.chb_tweak_disable_health_alarm.Name = "chb_tweak_disable_health_alarm";
            this.chb_tweak_disable_health_alarm.Size = new System.Drawing.Size(155, 19);
            this.chb_tweak_disable_health_alarm.TabIndex = 2;
            this.chb_tweak_disable_health_alarm.Text = "Disable low health alarm";
            this.chb_tweak_disable_health_alarm.UseVisualStyleBackColor = true;
            // 
            // chb_tweak_center_samus
            // 
            this.chb_tweak_center_samus.AutoSize = true;
            this.chb_tweak_center_samus.Location = new System.Drawing.Point(6, 22);
            this.chb_tweak_center_samus.Name = "chb_tweak_center_samus";
            this.chb_tweak_center_samus.Size = new System.Drawing.Size(241, 19);
            this.chb_tweak_center_samus.TabIndex = 1;
            this.chb_tweak_center_samus.Text = "Center Samus during horizontal scrolling";
            this.chb_tweak_center_samus.UseVisualStyleBackColor = true;
            // 
            // tab_twed_weapons
            // 
            this.tab_twed_weapons.Controls.Add(this.grp_twed_weapons_values);
            this.tab_twed_weapons.Controls.Add(this.grp_twed_weapons_checks);
            this.tab_twed_weapons.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_weapons.Name = "tab_twed_weapons";
            this.tab_twed_weapons.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_weapons.Size = new System.Drawing.Size(288, 395);
            this.tab_twed_weapons.TabIndex = 1;
            this.tab_twed_weapons.Text = "Weapons";
            this.tab_twed_weapons.UseVisualStyleBackColor = true;
            // 
            // grp_twed_weapons_values
            // 
            this.grp_twed_weapons_values.Controls.Add(this.lbl_tweak_bomb_timer);
            this.grp_twed_weapons_values.Controls.Add(this.num_tweak_bomb_timer);
            this.grp_twed_weapons_values.Location = new System.Drawing.Point(9, 138);
            this.grp_twed_weapons_values.Name = "grp_twed_weapons_values";
            this.grp_twed_weapons_values.Size = new System.Drawing.Size(250, 150);
            this.grp_twed_weapons_values.TabIndex = 1;
            this.grp_twed_weapons_values.TabStop = false;
            this.grp_twed_weapons_values.Text = "Values";
            // 
            // lbl_tweak_bomb_timer
            // 
            this.lbl_tweak_bomb_timer.AutoSize = true;
            this.lbl_tweak_bomb_timer.Location = new System.Drawing.Point(68, 24);
            this.lbl_tweak_bomb_timer.Name = "lbl_tweak_bomb_timer";
            this.lbl_tweak_bomb_timer.Size = new System.Drawing.Size(124, 15);
            this.lbl_tweak_bomb_timer.TabIndex = 1;
            this.lbl_tweak_bomb_timer.Text = "Bomb explosion timer";
            // 
            // num_tweak_bomb_timer
            // 
            this.num_tweak_bomb_timer.Hexadecimal = true;
            this.num_tweak_bomb_timer.Location = new System.Drawing.Point(6, 22);
            this.num_tweak_bomb_timer.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_bomb_timer.Name = "num_tweak_bomb_timer";
            this.num_tweak_bomb_timer.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_bomb_timer.TabIndex = 0;
            this.num_tweak_bomb_timer.Value = new decimal(new int[] {
            96,
            0,
            0,
            0});
            // 
            // grp_twed_weapons_checks
            // 
            this.grp_twed_weapons_checks.Controls.Add(this.chb_tweak_smooth_missile);
            this.grp_twed_weapons_checks.Location = new System.Drawing.Point(9, 7);
            this.grp_twed_weapons_checks.Name = "grp_twed_weapons_checks";
            this.grp_twed_weapons_checks.Size = new System.Drawing.Size(250, 125);
            this.grp_twed_weapons_checks.TabIndex = 0;
            this.grp_twed_weapons_checks.TabStop = false;
            this.grp_twed_weapons_checks.Text = "Checks";
            // 
            // chb_tweak_smooth_missile
            // 
            this.chb_tweak_smooth_missile.AutoSize = true;
            this.chb_tweak_smooth_missile.Location = new System.Drawing.Point(6, 22);
            this.chb_tweak_smooth_missile.Name = "chb_tweak_smooth_missile";
            this.chb_tweak_smooth_missile.Size = new System.Drawing.Size(225, 19);
            this.chb_tweak_smooth_missile.TabIndex = 0;
            this.chb_tweak_smooth_missile.Text = "Missiles fly faster && more consistently";
            this.chb_tweak_smooth_missile.UseVisualStyleBackColor = true;
            // 
            // tab_twed_drops
            // 
            this.tab_twed_drops.Controls.Add(this.grp_twed_drops_values);
            this.tab_twed_drops.Controls.Add(this.grp_twed_drops_checks);
            this.tab_twed_drops.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_drops.Name = "tab_twed_drops";
            this.tab_twed_drops.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_drops.Size = new System.Drawing.Size(288, 395);
            this.tab_twed_drops.TabIndex = 2;
            this.tab_twed_drops.Text = "Drops & Items";
            this.tab_twed_drops.UseVisualStyleBackColor = true;
            // 
            // grp_twed_drops_values
            // 
            this.grp_twed_drops_values.Controls.Add(this.lbl_tweak_missile_restore);
            this.grp_twed_drops_values.Controls.Add(this.num_tweak_missile_restore);
            this.grp_twed_drops_values.Controls.Add(this.lbl_tweak_small_energy_amount);
            this.grp_twed_drops_values.Controls.Add(this.num_tweak_small_energy_amount);
            this.grp_twed_drops_values.Controls.Add(this.lbl_tweak_large_energy_amount);
            this.grp_twed_drops_values.Controls.Add(this.num_tweak_amount_large_energy);
            this.grp_twed_drops_values.Location = new System.Drawing.Point(9, 138);
            this.grp_twed_drops_values.Name = "grp_twed_drops_values";
            this.grp_twed_drops_values.Size = new System.Drawing.Size(250, 150);
            this.grp_twed_drops_values.TabIndex = 1;
            this.grp_twed_drops_values.TabStop = false;
            this.grp_twed_drops_values.Text = "Values";
            // 
            // lbl_tweak_missile_restore
            // 
            this.lbl_tweak_missile_restore.AutoSize = true;
            this.lbl_tweak_missile_restore.Location = new System.Drawing.Point(68, 84);
            this.lbl_tweak_missile_restore.Name = "lbl_tweak_missile_restore";
            this.lbl_tweak_missile_restore.Size = new System.Drawing.Size(162, 15);
            this.lbl_tweak_missile_restore.TabIndex = 5;
            this.lbl_tweak_missile_restore.Text = "Amount missile drops restore";
            // 
            // num_tweak_missile_restore
            // 
            this.num_tweak_missile_restore.Hexadecimal = true;
            this.num_tweak_missile_restore.Location = new System.Drawing.Point(6, 82);
            this.num_tweak_missile_restore.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_missile_restore.Name = "num_tweak_missile_restore";
            this.num_tweak_missile_restore.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_missile_restore.TabIndex = 4;
            this.num_tweak_missile_restore.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_tweak_small_energy_amount
            // 
            this.lbl_tweak_small_energy_amount.AutoSize = true;
            this.lbl_tweak_small_energy_amount.Location = new System.Drawing.Point(68, 54);
            this.lbl_tweak_small_energy_amount.Name = "lbl_tweak_small_energy_amount";
            this.lbl_tweak_small_energy_amount.Size = new System.Drawing.Size(154, 15);
            this.lbl_tweak_small_energy_amount.TabIndex = 3;
            this.lbl_tweak_small_energy_amount.Text = "Health large energy restores";
            // 
            // num_tweak_small_energy_amount
            // 
            this.num_tweak_small_energy_amount.Hexadecimal = true;
            this.num_tweak_small_energy_amount.Location = new System.Drawing.Point(6, 52);
            this.num_tweak_small_energy_amount.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_small_energy_amount.Name = "num_tweak_small_energy_amount";
            this.num_tweak_small_energy_amount.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_small_energy_amount.TabIndex = 2;
            this.num_tweak_small_energy_amount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lbl_tweak_large_energy_amount
            // 
            this.lbl_tweak_large_energy_amount.AutoSize = true;
            this.lbl_tweak_large_energy_amount.Location = new System.Drawing.Point(68, 24);
            this.lbl_tweak_large_energy_amount.Name = "lbl_tweak_large_energy_amount";
            this.lbl_tweak_large_energy_amount.Size = new System.Drawing.Size(154, 15);
            this.lbl_tweak_large_energy_amount.TabIndex = 1;
            this.lbl_tweak_large_energy_amount.Text = "Health large energy restores";
            // 
            // num_tweak_amount_large_energy
            // 
            this.num_tweak_amount_large_energy.Hexadecimal = true;
            this.num_tweak_amount_large_energy.Location = new System.Drawing.Point(6, 22);
            this.num_tweak_amount_large_energy.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_amount_large_energy.Name = "num_tweak_amount_large_energy";
            this.num_tweak_amount_large_energy.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_amount_large_energy.TabIndex = 0;
            this.num_tweak_amount_large_energy.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // grp_twed_drops_checks
            // 
            this.grp_twed_drops_checks.Controls.Add(this.chb_tweak_fanfare);
            this.grp_twed_drops_checks.Location = new System.Drawing.Point(9, 7);
            this.grp_twed_drops_checks.Name = "grp_twed_drops_checks";
            this.grp_twed_drops_checks.Size = new System.Drawing.Size(250, 125);
            this.grp_twed_drops_checks.TabIndex = 0;
            this.grp_twed_drops_checks.TabStop = false;
            this.grp_twed_drops_checks.Text = "Checks";
            // 
            // chb_tweak_fanfare
            // 
            this.chb_tweak_fanfare.AutoSize = true;
            this.chb_tweak_fanfare.Location = new System.Drawing.Point(6, 22);
            this.chb_tweak_fanfare.Name = "chb_tweak_fanfare";
            this.chb_tweak_fanfare.Size = new System.Drawing.Size(238, 19);
            this.chb_tweak_fanfare.TabIndex = 0;
            this.chb_tweak_fanfare.Text = "All items use the quick acquisition jingle";
            this.chb_tweak_fanfare.UseVisualStyleBackColor = true;
            // 
            // tab_twed_misc
            // 
            this.tab_twed_misc.Controls.Add(this.grp_twed_misc_values);
            this.tab_twed_misc.Controls.Add(this.grp_twed_misc_checks);
            this.tab_twed_misc.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_misc.Name = "tab_twed_misc";
            this.tab_twed_misc.Size = new System.Drawing.Size(288, 395);
            this.tab_twed_misc.TabIndex = 3;
            this.tab_twed_misc.Text = "Miscellaneous";
            this.tab_twed_misc.UseVisualStyleBackColor = true;
            // 
            // grp_twed_misc_values
            // 
            this.grp_twed_misc_values.Controls.Add(this.lbl_tweak_missiles_hatch);
            this.grp_twed_misc_values.Controls.Add(this.num_tweak_missiles_hatch);
            this.grp_twed_misc_values.Location = new System.Drawing.Point(9, 138);
            this.grp_twed_misc_values.Name = "grp_twed_misc_values";
            this.grp_twed_misc_values.Size = new System.Drawing.Size(250, 150);
            this.grp_twed_misc_values.TabIndex = 1;
            this.grp_twed_misc_values.TabStop = false;
            this.grp_twed_misc_values.Text = "Values";
            // 
            // lbl_tweak_missiles_hatch
            // 
            this.lbl_tweak_missiles_hatch.AutoSize = true;
            this.lbl_tweak_missiles_hatch.Location = new System.Drawing.Point(68, 24);
            this.lbl_tweak_missiles_hatch.Name = "lbl_tweak_missiles_hatch";
            this.lbl_tweak_missiles_hatch.Size = new System.Drawing.Size(101, 15);
            this.lbl_tweak_missiles_hatch.TabIndex = 1;
            this.lbl_tweak_missiles_hatch.Text = "Missiles per hatch";
            // 
            // num_tweak_missiles_hatch
            // 
            this.num_tweak_missiles_hatch.Hexadecimal = true;
            this.num_tweak_missiles_hatch.Location = new System.Drawing.Point(6, 22);
            this.num_tweak_missiles_hatch.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_tweak_missiles_hatch.Name = "num_tweak_missiles_hatch";
            this.num_tweak_missiles_hatch.Size = new System.Drawing.Size(56, 23);
            this.num_tweak_missiles_hatch.TabIndex = 0;
            this.num_tweak_missiles_hatch.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // grp_twed_misc_checks
            // 
            this.grp_twed_misc_checks.Controls.Add(this.chb_tweak_hatches_beam);
            this.grp_twed_misc_checks.Controls.Add(this.chb_tweak_music_plays_pause);
            this.grp_twed_misc_checks.Controls.Add(this.chb_tweak_debug_menu);
            this.grp_twed_misc_checks.Controls.Add(this.chb_tweak_infinite_spin);
            this.grp_twed_misc_checks.Location = new System.Drawing.Point(9, 7);
            this.grp_twed_misc_checks.Name = "grp_twed_misc_checks";
            this.grp_twed_misc_checks.Size = new System.Drawing.Size(250, 125);
            this.grp_twed_misc_checks.TabIndex = 0;
            this.grp_twed_misc_checks.TabStop = false;
            this.grp_twed_misc_checks.Text = "Checks";
            // 
            // chb_tweak_hatches_beam
            // 
            this.chb_tweak_hatches_beam.AutoSize = true;
            this.chb_tweak_hatches_beam.Location = new System.Drawing.Point(6, 97);
            this.chb_tweak_hatches_beam.Name = "chb_tweak_hatches_beam";
            this.chb_tweak_hatches_beam.Size = new System.Drawing.Size(226, 19);
            this.chb_tweak_hatches_beam.TabIndex = 3;
            this.chb_tweak_hatches_beam.Text = "Hatches can be destroyed with beams";
            this.chb_tweak_hatches_beam.UseVisualStyleBackColor = true;
            // 
            // chb_tweak_music_plays_pause
            // 
            this.chb_tweak_music_plays_pause.AutoSize = true;
            this.chb_tweak_music_plays_pause.Location = new System.Drawing.Point(6, 72);
            this.chb_tweak_music_plays_pause.Name = "chb_tweak_music_plays_pause";
            this.chb_tweak_music_plays_pause.Size = new System.Drawing.Size(206, 19);
            this.chb_tweak_music_plays_pause.TabIndex = 2;
            this.chb_tweak_music_plays_pause.Text = "Music keeps playing when paused";
            this.chb_tweak_music_plays_pause.UseVisualStyleBackColor = true;
            // 
            // chb_tweak_debug_menu
            // 
            this.chb_tweak_debug_menu.AutoSize = true;
            this.chb_tweak_debug_menu.Location = new System.Drawing.Point(6, 47);
            this.chb_tweak_debug_menu.Name = "chb_tweak_debug_menu";
            this.chb_tweak_debug_menu.Size = new System.Drawing.Size(240, 19);
            this.chb_tweak_debug_menu.TabIndex = 1;
            this.chb_tweak_debug_menu.Text = "Enable debug menu on the pause screen";
            this.chb_tweak_debug_menu.UseVisualStyleBackColor = true;
            // 
            // chb_tweak_infinite_spin
            // 
            this.chb_tweak_infinite_spin.AutoSize = true;
            this.chb_tweak_infinite_spin.Location = new System.Drawing.Point(6, 22);
            this.chb_tweak_infinite_spin.Name = "chb_tweak_infinite_spin";
            this.chb_tweak_infinite_spin.Size = new System.Drawing.Size(161, 19);
            this.chb_tweak_infinite_spin.TabIndex = 0;
            this.chb_tweak_infinite_spin.Text = "Spin jump flies up forever";
            this.chb_tweak_infinite_spin.UseVisualStyleBackColor = true;
            // 
            // btn_apply_tweaks
            // 
            this.btn_apply_tweaks.Location = new System.Drawing.Point(220, 425);
            this.btn_apply_tweaks.Name = "btn_apply_tweaks";
            this.btn_apply_tweaks.Size = new System.Drawing.Size(75, 23);
            this.btn_apply_tweaks.TabIndex = 1;
            this.btn_apply_tweaks.Text = "Apply";
            this.btn_apply_tweaks.UseVisualStyleBackColor = true;
            this.btn_apply_tweaks.Click += new System.EventHandler(this.btn_apply_tweaks_Click);
            // 
            // btn_close_tweaks
            // 
            this.btn_close_tweaks.Location = new System.Drawing.Point(142, 425);
            this.btn_close_tweaks.Name = "btn_close_tweaks";
            this.btn_close_tweaks.Size = new System.Drawing.Size(75, 23);
            this.btn_close_tweaks.TabIndex = 2;
            this.btn_close_tweaks.Text = "Close";
            this.btn_close_tweaks.UseVisualStyleBackColor = true;
            this.btn_close_tweaks.Click += new System.EventHandler(this.btn_close_tweaks_Click);
            // 
            // TweaksEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 450);
            this.Controls.Add(this.btn_close_tweaks);
            this.Controls.Add(this.btn_apply_tweaks);
            this.Controls.Add(this.tabc_tweaks_editor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TweaksEditor";
            this.Text = "Tweaks";
            this.tabc_tweaks_editor.ResumeLayout(false);
            this.tab_twed_samus.ResumeLayout(false);
            this.grp_twed_samus_values.ResumeLayout(false);
            this.grp_twed_samus_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_air_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_morph_speed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_samus_speed)).EndInit();
            this.grp_twed_samus_checks.ResumeLayout(false);
            this.grp_twed_samus_checks.PerformLayout();
            this.tab_twed_weapons.ResumeLayout(false);
            this.grp_twed_weapons_values.ResumeLayout(false);
            this.grp_twed_weapons_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_bomb_timer)).EndInit();
            this.grp_twed_weapons_checks.ResumeLayout(false);
            this.grp_twed_weapons_checks.PerformLayout();
            this.tab_twed_drops.ResumeLayout(false);
            this.grp_twed_drops_values.ResumeLayout(false);
            this.grp_twed_drops_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_missile_restore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_small_energy_amount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_amount_large_energy)).EndInit();
            this.grp_twed_drops_checks.ResumeLayout(false);
            this.grp_twed_drops_checks.PerformLayout();
            this.tab_twed_misc.ResumeLayout(false);
            this.grp_twed_misc_values.ResumeLayout(false);
            this.grp_twed_misc_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_missiles_hatch)).EndInit();
            this.grp_twed_misc_checks.ResumeLayout(false);
            this.grp_twed_misc_checks.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabc_tweaks_editor;
        private System.Windows.Forms.TabPage tab_twed_samus;
        private System.Windows.Forms.TabPage tab_twed_weapons;
        private System.Windows.Forms.TabPage tab_twed_drops;
        private System.Windows.Forms.TabPage tab_twed_misc;
        private System.Windows.Forms.GroupBox grp_twed_samus_values;
        private System.Windows.Forms.GroupBox grp_twed_samus_checks;
        private System.Windows.Forms.CheckBox chb_tweak_center_samus;
        private System.Windows.Forms.Label lbl_tweak_samus_speed;
        private System.Windows.Forms.NumericUpDown num_tweak_samus_speed;
        private System.Windows.Forms.Button btn_apply_tweaks;
        private System.Windows.Forms.Button btn_close_tweaks;
        private System.Windows.Forms.Label lbl_tweak_air_speed;
        private System.Windows.Forms.NumericUpDown num_tweak_air_speed;
        private System.Windows.Forms.Label lbl_tweak_morph_speed;
        private System.Windows.Forms.NumericUpDown num_tweak_morph_speed;
        private System.Windows.Forms.CheckBox chb_tweak_disable_health_alarm;
        private System.Windows.Forms.GroupBox grp_twed_weapons_values;
        private System.Windows.Forms.Label lbl_tweak_bomb_timer;
        private System.Windows.Forms.NumericUpDown num_tweak_bomb_timer;
        private System.Windows.Forms.GroupBox grp_twed_weapons_checks;
        private System.Windows.Forms.CheckBox chb_tweak_smooth_missile;
        private System.Windows.Forms.GroupBox grp_twed_drops_values;
        private System.Windows.Forms.Label lbl_tweak_missile_restore;
        private System.Windows.Forms.NumericUpDown num_tweak_missile_restore;
        private System.Windows.Forms.Label lbl_tweak_small_energy_amount;
        private System.Windows.Forms.NumericUpDown num_tweak_small_energy_amount;
        private System.Windows.Forms.Label lbl_tweak_large_energy_amount;
        private System.Windows.Forms.NumericUpDown num_tweak_amount_large_energy;
        private System.Windows.Forms.GroupBox grp_twed_drops_checks;
        private System.Windows.Forms.CheckBox chb_tweak_fanfare;
        private System.Windows.Forms.GroupBox grp_twed_misc_values;
        private System.Windows.Forms.Label lbl_tweak_missiles_hatch;
        private System.Windows.Forms.NumericUpDown num_tweak_missiles_hatch;
        private System.Windows.Forms.GroupBox grp_twed_misc_checks;
        private System.Windows.Forms.CheckBox chb_tweak_hatches_beam;
        private System.Windows.Forms.CheckBox chb_tweak_music_plays_pause;
        private System.Windows.Forms.CheckBox chb_tweak_debug_menu;
        private System.Windows.Forms.CheckBox chb_tweak_infinite_spin;
    }
}