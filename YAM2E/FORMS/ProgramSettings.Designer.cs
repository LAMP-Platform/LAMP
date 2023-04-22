namespace LAMP.FORMS
{
    partial class ProgramSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramSettings));
            lbl_rom_path = new System.Windows.Forms.Label();
            txb_rom_path = new System.Windows.Forms.TextBox();
            btn_select_rom = new System.Windows.Forms.Button();
            grp_rom_settings = new System.Windows.Forms.GroupBox();
            grp_hex_indicator = new System.Windows.Forms.GroupBox();
            rbt_h_suffix = new System.Windows.Forms.RadioButton();
            rbt_dollar_prefix = new System.Windows.Forms.RadioButton();
            rbt_0x_prefix = new System.Windows.Forms.RadioButton();
            rbt_no_indication = new System.Windows.Forms.RadioButton();
            grp_offset_style = new System.Windows.Forms.GroupBox();
            rbt_offset_style = new System.Windows.Forms.RadioButton();
            rbt_bank_style = new System.Windows.Forms.RadioButton();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_compilation = new System.Windows.Forms.GroupBox();
            chb_saves = new System.Windows.Forms.CheckBox();
            chb_transitions = new System.Windows.Forms.CheckBox();
            chb_objects = new System.Windows.Forms.CheckBox();
            chb_areas = new System.Windows.Forms.CheckBox();
            chb_screens = new System.Windows.Forms.CheckBox();
            grp_rom_settings.SuspendLayout();
            grp_hex_indicator.SuspendLayout();
            grp_offset_style.SuspendLayout();
            grp_compilation.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_rom_path
            // 
            lbl_rom_path.AutoSize = true;
            lbl_rom_path.Location = new System.Drawing.Point(6, 25);
            lbl_rom_path.Name = "lbl_rom_path";
            lbl_rom_path.Size = new System.Drawing.Size(64, 15);
            lbl_rom_path.TabIndex = 0;
            lbl_rom_path.Text = "ROM Path:";
            // 
            // txb_rom_path
            // 
            txb_rom_path.Location = new System.Drawing.Point(76, 22);
            txb_rom_path.Name = "txb_rom_path";
            txb_rom_path.Size = new System.Drawing.Size(234, 23);
            txb_rom_path.TabIndex = 1;
            txb_rom_path.TextChanged += txb_rom_path_TextChanged;
            // 
            // btn_select_rom
            // 
            btn_select_rom.Image = (System.Drawing.Image)resources.GetObject("btn_select_rom.Image");
            btn_select_rom.Location = new System.Drawing.Point(316, 22);
            btn_select_rom.Name = "btn_select_rom";
            btn_select_rom.Size = new System.Drawing.Size(23, 23);
            btn_select_rom.TabIndex = 2;
            btn_select_rom.UseVisualStyleBackColor = true;
            btn_select_rom.Click += btn_select_rom_Click;
            // 
            // grp_rom_settings
            // 
            grp_rom_settings.Controls.Add(txb_rom_path);
            grp_rom_settings.Controls.Add(btn_select_rom);
            grp_rom_settings.Controls.Add(lbl_rom_path);
            grp_rom_settings.Location = new System.Drawing.Point(12, 12);
            grp_rom_settings.Name = "grp_rom_settings";
            grp_rom_settings.Size = new System.Drawing.Size(352, 60);
            grp_rom_settings.TabIndex = 3;
            grp_rom_settings.TabStop = false;
            grp_rom_settings.Text = "ROM";
            // 
            // grp_hex_indicator
            // 
            grp_hex_indicator.Controls.Add(rbt_h_suffix);
            grp_hex_indicator.Controls.Add(rbt_dollar_prefix);
            grp_hex_indicator.Controls.Add(rbt_0x_prefix);
            grp_hex_indicator.Controls.Add(rbt_no_indication);
            grp_hex_indicator.Location = new System.Drawing.Point(12, 78);
            grp_hex_indicator.Name = "grp_hex_indicator";
            grp_hex_indicator.Size = new System.Drawing.Size(163, 123);
            grp_hex_indicator.TabIndex = 4;
            grp_hex_indicator.TabStop = false;
            grp_hex_indicator.Text = "HEX Indicator";
            // 
            // rbt_h_suffix
            // 
            rbt_h_suffix.AutoSize = true;
            rbt_h_suffix.Location = new System.Drawing.Point(6, 97);
            rbt_h_suffix.Name = "rbt_h_suffix";
            rbt_h_suffix.Size = new System.Drawing.Size(81, 19);
            rbt_h_suffix.TabIndex = 3;
            rbt_h_suffix.Text = "\"h\"   Suffix";
            rbt_h_suffix.UseVisualStyleBackColor = true;
            rbt_h_suffix.CheckedChanged += rbt_h_suffix_CheckedChanged;
            // 
            // rbt_dollar_prefix
            // 
            rbt_dollar_prefix.AutoSize = true;
            rbt_dollar_prefix.Location = new System.Drawing.Point(6, 72);
            rbt_dollar_prefix.Name = "rbt_dollar_prefix";
            rbt_dollar_prefix.Size = new System.Drawing.Size(80, 19);
            rbt_dollar_prefix.TabIndex = 2;
            rbt_dollar_prefix.Text = "\"$\"   Prefix";
            rbt_dollar_prefix.UseVisualStyleBackColor = true;
            rbt_dollar_prefix.CheckedChanged += rbt_dollar_prefix_CheckedChanged;
            // 
            // rbt_0x_prefix
            // 
            rbt_0x_prefix.AutoSize = true;
            rbt_0x_prefix.Checked = true;
            rbt_0x_prefix.Location = new System.Drawing.Point(6, 47);
            rbt_0x_prefix.Name = "rbt_0x_prefix";
            rbt_0x_prefix.Size = new System.Drawing.Size(80, 19);
            rbt_0x_prefix.TabIndex = 1;
            rbt_0x_prefix.TabStop = true;
            rbt_0x_prefix.Text = "\"0x\" Prefix";
            rbt_0x_prefix.UseVisualStyleBackColor = true;
            rbt_0x_prefix.CheckedChanged += rbt_0x_prefix_CheckedChanged;
            // 
            // rbt_no_indication
            // 
            rbt_no_indication.AutoSize = true;
            rbt_no_indication.Location = new System.Drawing.Point(6, 22);
            rbt_no_indication.Name = "rbt_no_indication";
            rbt_no_indication.Size = new System.Drawing.Size(97, 19);
            rbt_no_indication.TabIndex = 0;
            rbt_no_indication.Text = "No Indication";
            rbt_no_indication.UseVisualStyleBackColor = true;
            rbt_no_indication.CheckedChanged += rbt_no_indication_CheckedChanged;
            // 
            // grp_offset_style
            // 
            grp_offset_style.Controls.Add(rbt_offset_style);
            grp_offset_style.Controls.Add(rbt_bank_style);
            grp_offset_style.Location = new System.Drawing.Point(181, 78);
            grp_offset_style.Name = "grp_offset_style";
            grp_offset_style.Size = new System.Drawing.Size(183, 123);
            grp_offset_style.TabIndex = 5;
            grp_offset_style.TabStop = false;
            grp_offset_style.Text = "Offset Style";
            // 
            // rbt_offset_style
            // 
            rbt_offset_style.AutoSize = true;
            rbt_offset_style.Location = new System.Drawing.Point(6, 47);
            rbt_offset_style.Name = "rbt_offset_style";
            rbt_offset_style.Size = new System.Drawing.Size(117, 19);
            rbt_offset_style.TabIndex = 2;
            rbt_offset_style.Text = "Use direct Offsets";
            rbt_offset_style.UseVisualStyleBackColor = true;
            rbt_offset_style.CheckedChanged += rbt_offset_style_CheckedChanged;
            // 
            // rbt_bank_style
            // 
            rbt_bank_style.AutoSize = true;
            rbt_bank_style.Checked = true;
            rbt_bank_style.Location = new System.Drawing.Point(6, 22);
            rbt_bank_style.Name = "rbt_bank_style";
            rbt_bank_style.Size = new System.Drawing.Size(145, 19);
            rbt_bank_style.TabIndex = 1;
            rbt_bank_style.TabStop = true;
            rbt_bank_style.Text = "Split Banks and Offsets";
            rbt_bank_style.UseVisualStyleBackColor = true;
            rbt_bank_style.CheckedChanged += rbt_bank_style_CheckedChanged;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 370);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(376, 22);
            statusStrip1.TabIndex = 6;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_compilation
            // 
            grp_compilation.Controls.Add(chb_saves);
            grp_compilation.Controls.Add(chb_transitions);
            grp_compilation.Controls.Add(chb_objects);
            grp_compilation.Controls.Add(chb_areas);
            grp_compilation.Controls.Add(chb_screens);
            grp_compilation.Location = new System.Drawing.Point(12, 207);
            grp_compilation.Name = "grp_compilation";
            grp_compilation.Size = new System.Drawing.Size(352, 150);
            grp_compilation.TabIndex = 7;
            grp_compilation.TabStop = false;
            grp_compilation.Text = "Compilation";
            // 
            // chb_saves
            // 
            chb_saves.AutoSize = true;
            chb_saves.Checked = true;
            chb_saves.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_saves.Location = new System.Drawing.Point(6, 122);
            chb_saves.Name = "chb_saves";
            chb_saves.Size = new System.Drawing.Size(103, 19);
            chb_saves.TabIndex = 4;
            chb_saves.Tag = "Save";
            chb_saves.Text = "Compile Saves";
            chb_saves.UseVisualStyleBackColor = true;
            chb_saves.CheckedChanged += chb_compilation_itemsCheckedChanged;
            // 
            // chb_transitions
            // 
            chb_transitions.AutoSize = true;
            chb_transitions.Checked = true;
            chb_transitions.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_transitions.Location = new System.Drawing.Point(6, 97);
            chb_transitions.Name = "chb_transitions";
            chb_transitions.Size = new System.Drawing.Size(130, 19);
            chb_transitions.TabIndex = 3;
            chb_transitions.Tag = "Transitions";
            chb_transitions.Text = "Compile Transitions";
            chb_transitions.UseVisualStyleBackColor = true;
            chb_transitions.CheckedChanged += chb_compilation_itemsCheckedChanged;
            // 
            // chb_objects
            // 
            chb_objects.AutoSize = true;
            chb_objects.Checked = true;
            chb_objects.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_objects.Location = new System.Drawing.Point(6, 72);
            chb_objects.Name = "chb_objects";
            chb_objects.Size = new System.Drawing.Size(114, 19);
            chb_objects.TabIndex = 2;
            chb_objects.Tag = "Objects";
            chb_objects.Text = "Compile Objects";
            chb_objects.UseVisualStyleBackColor = true;
            chb_objects.CheckedChanged += chb_compilation_itemsCheckedChanged;
            // 
            // chb_areas
            // 
            chb_areas.AutoSize = true;
            chb_areas.Checked = true;
            chb_areas.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_areas.Location = new System.Drawing.Point(6, 47);
            chb_areas.Name = "chb_areas";
            chb_areas.Size = new System.Drawing.Size(103, 19);
            chb_areas.TabIndex = 1;
            chb_areas.Tag = "Areas";
            chb_areas.Text = "Compile Areas";
            chb_areas.UseVisualStyleBackColor = true;
            chb_areas.CheckedChanged += chb_compilation_itemsCheckedChanged;
            // 
            // chb_screens
            // 
            chb_screens.AutoSize = true;
            chb_screens.Checked = true;
            chb_screens.CheckState = System.Windows.Forms.CheckState.Checked;
            chb_screens.Location = new System.Drawing.Point(6, 22);
            chb_screens.Name = "chb_screens";
            chb_screens.Size = new System.Drawing.Size(114, 19);
            chb_screens.TabIndex = 0;
            chb_screens.Tag = "Screens";
            chb_screens.Text = "Compile Screens";
            chb_screens.UseVisualStyleBackColor = true;
            chb_screens.CheckedChanged += chb_compilation_itemsCheckedChanged;
            // 
            // ProgramSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(376, 392);
            Controls.Add(grp_compilation);
            Controls.Add(statusStrip1);
            Controls.Add(grp_offset_style);
            Controls.Add(grp_hex_indicator);
            Controls.Add(grp_rom_settings);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new System.Drawing.Size(392, 277);
            Name = "ProgramSettings";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Program Settings";
            grp_rom_settings.ResumeLayout(false);
            grp_rom_settings.PerformLayout();
            grp_hex_indicator.ResumeLayout(false);
            grp_hex_indicator.PerformLayout();
            grp_offset_style.ResumeLayout(false);
            grp_offset_style.PerformLayout();
            grp_compilation.ResumeLayout(false);
            grp_compilation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_rom_path;
        private System.Windows.Forms.TextBox txb_rom_path;
        private System.Windows.Forms.Button btn_select_rom;
        private System.Windows.Forms.GroupBox grp_rom_settings;
        private System.Windows.Forms.GroupBox grp_hex_indicator;
        private System.Windows.Forms.RadioButton rbt_h_suffix;
        private System.Windows.Forms.RadioButton rbt_dollar_prefix;
        private System.Windows.Forms.RadioButton rbt_0x_prefix;
        private System.Windows.Forms.RadioButton rbt_no_indication;
        private System.Windows.Forms.GroupBox grp_offset_style;
        private System.Windows.Forms.RadioButton rbt_offset_style;
        private System.Windows.Forms.RadioButton rbt_bank_style;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grp_compilation;
        private System.Windows.Forms.CheckBox chb_saves;
        private System.Windows.Forms.CheckBox chb_transitions;
        private System.Windows.Forms.CheckBox chb_objects;
        private System.Windows.Forms.CheckBox chb_areas;
        private System.Windows.Forms.CheckBox chb_screens;
    }
}