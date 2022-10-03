namespace LAMP.FORMS
{
    partial class ProgramSettins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramSettins));
            this.lbl_rom_path = new System.Windows.Forms.Label();
            this.txb_rom_path = new System.Windows.Forms.TextBox();
            this.btn_select_rom = new System.Windows.Forms.Button();
            this.grp_rom_settings = new System.Windows.Forms.GroupBox();
            this.grp_hex_indicator = new System.Windows.Forms.GroupBox();
            this.rbt_h_suffix = new System.Windows.Forms.RadioButton();
            this.rbt_dollar_prefix = new System.Windows.Forms.RadioButton();
            this.rbt_0x_prefix = new System.Windows.Forms.RadioButton();
            this.rbt_no_indication = new System.Windows.Forms.RadioButton();
            this.grp_offset_style = new System.Windows.Forms.GroupBox();
            this.rbt_offset_style = new System.Windows.Forms.RadioButton();
            this.rbt_bank_style = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_rom_settings.SuspendLayout();
            this.grp_hex_indicator.SuspendLayout();
            this.grp_offset_style.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_rom_path
            // 
            this.lbl_rom_path.AutoSize = true;
            this.lbl_rom_path.Location = new System.Drawing.Point(6, 25);
            this.lbl_rom_path.Name = "lbl_rom_path";
            this.lbl_rom_path.Size = new System.Drawing.Size(64, 15);
            this.lbl_rom_path.TabIndex = 0;
            this.lbl_rom_path.Text = "ROM Path:";
            // 
            // txb_rom_path
            // 
            this.txb_rom_path.Location = new System.Drawing.Point(76, 22);
            this.txb_rom_path.Name = "txb_rom_path";
            this.txb_rom_path.Size = new System.Drawing.Size(234, 23);
            this.txb_rom_path.TabIndex = 1;
            this.txb_rom_path.TextChanged += new System.EventHandler(this.txb_rom_path_TextChanged);
            // 
            // btn_select_rom
            // 
            this.btn_select_rom.Image = ((System.Drawing.Image)(resources.GetObject("btn_select_rom.Image")));
            this.btn_select_rom.Location = new System.Drawing.Point(316, 22);
            this.btn_select_rom.Name = "btn_select_rom";
            this.btn_select_rom.Size = new System.Drawing.Size(23, 23);
            this.btn_select_rom.TabIndex = 2;
            this.btn_select_rom.UseVisualStyleBackColor = true;
            this.btn_select_rom.Click += new System.EventHandler(this.btn_select_rom_Click);
            // 
            // grp_rom_settings
            // 
            this.grp_rom_settings.Controls.Add(this.txb_rom_path);
            this.grp_rom_settings.Controls.Add(this.btn_select_rom);
            this.grp_rom_settings.Controls.Add(this.lbl_rom_path);
            this.grp_rom_settings.Location = new System.Drawing.Point(12, 12);
            this.grp_rom_settings.Name = "grp_rom_settings";
            this.grp_rom_settings.Size = new System.Drawing.Size(352, 60);
            this.grp_rom_settings.TabIndex = 3;
            this.grp_rom_settings.TabStop = false;
            this.grp_rom_settings.Text = "ROM";
            // 
            // grp_hex_indicator
            // 
            this.grp_hex_indicator.Controls.Add(this.rbt_h_suffix);
            this.grp_hex_indicator.Controls.Add(this.rbt_dollar_prefix);
            this.grp_hex_indicator.Controls.Add(this.rbt_0x_prefix);
            this.grp_hex_indicator.Controls.Add(this.rbt_no_indication);
            this.grp_hex_indicator.Location = new System.Drawing.Point(12, 78);
            this.grp_hex_indicator.Name = "grp_hex_indicator";
            this.grp_hex_indicator.Size = new System.Drawing.Size(163, 123);
            this.grp_hex_indicator.TabIndex = 4;
            this.grp_hex_indicator.TabStop = false;
            this.grp_hex_indicator.Text = "HEX Indicator";
            // 
            // rbt_h_suffix
            // 
            this.rbt_h_suffix.AutoSize = true;
            this.rbt_h_suffix.Location = new System.Drawing.Point(6, 97);
            this.rbt_h_suffix.Name = "rbt_h_suffix";
            this.rbt_h_suffix.Size = new System.Drawing.Size(81, 19);
            this.rbt_h_suffix.TabIndex = 3;
            this.rbt_h_suffix.Text = "\"h\"   Suffix";
            this.rbt_h_suffix.UseVisualStyleBackColor = true;
            this.rbt_h_suffix.CheckedChanged += new System.EventHandler(this.rbt_h_suffix_CheckedChanged);
            // 
            // rbt_dollar_prefix
            // 
            this.rbt_dollar_prefix.AutoSize = true;
            this.rbt_dollar_prefix.Location = new System.Drawing.Point(6, 72);
            this.rbt_dollar_prefix.Name = "rbt_dollar_prefix";
            this.rbt_dollar_prefix.Size = new System.Drawing.Size(80, 19);
            this.rbt_dollar_prefix.TabIndex = 2;
            this.rbt_dollar_prefix.Text = "\"$\"   Prefix";
            this.rbt_dollar_prefix.UseVisualStyleBackColor = true;
            this.rbt_dollar_prefix.CheckedChanged += new System.EventHandler(this.rbt_dollar_prefix_CheckedChanged);
            // 
            // rbt_0x_prefix
            // 
            this.rbt_0x_prefix.AutoSize = true;
            this.rbt_0x_prefix.Checked = true;
            this.rbt_0x_prefix.Location = new System.Drawing.Point(6, 47);
            this.rbt_0x_prefix.Name = "rbt_0x_prefix";
            this.rbt_0x_prefix.Size = new System.Drawing.Size(80, 19);
            this.rbt_0x_prefix.TabIndex = 1;
            this.rbt_0x_prefix.TabStop = true;
            this.rbt_0x_prefix.Text = "\"0x\" Prefix";
            this.rbt_0x_prefix.UseVisualStyleBackColor = true;
            this.rbt_0x_prefix.CheckedChanged += new System.EventHandler(this.rbt_0x_prefix_CheckedChanged);
            // 
            // rbt_no_indication
            // 
            this.rbt_no_indication.AutoSize = true;
            this.rbt_no_indication.Location = new System.Drawing.Point(6, 22);
            this.rbt_no_indication.Name = "rbt_no_indication";
            this.rbt_no_indication.Size = new System.Drawing.Size(97, 19);
            this.rbt_no_indication.TabIndex = 0;
            this.rbt_no_indication.Text = "No Indication";
            this.rbt_no_indication.UseVisualStyleBackColor = true;
            this.rbt_no_indication.CheckedChanged += new System.EventHandler(this.rbt_no_indication_CheckedChanged);
            // 
            // grp_offset_style
            // 
            this.grp_offset_style.Controls.Add(this.rbt_offset_style);
            this.grp_offset_style.Controls.Add(this.rbt_bank_style);
            this.grp_offset_style.Location = new System.Drawing.Point(181, 78);
            this.grp_offset_style.Name = "grp_offset_style";
            this.grp_offset_style.Size = new System.Drawing.Size(183, 123);
            this.grp_offset_style.TabIndex = 5;
            this.grp_offset_style.TabStop = false;
            this.grp_offset_style.Text = "Offset Style";
            // 
            // rbt_offset_style
            // 
            this.rbt_offset_style.AutoSize = true;
            this.rbt_offset_style.Location = new System.Drawing.Point(6, 47);
            this.rbt_offset_style.Name = "rbt_offset_style";
            this.rbt_offset_style.Size = new System.Drawing.Size(117, 19);
            this.rbt_offset_style.TabIndex = 2;
            this.rbt_offset_style.Text = "Use direct Offsets";
            this.rbt_offset_style.UseVisualStyleBackColor = true;
            this.rbt_offset_style.CheckedChanged += new System.EventHandler(this.rbt_offset_style_CheckedChanged);
            // 
            // rbt_bank_style
            // 
            this.rbt_bank_style.AutoSize = true;
            this.rbt_bank_style.Checked = true;
            this.rbt_bank_style.Location = new System.Drawing.Point(6, 22);
            this.rbt_bank_style.Name = "rbt_bank_style";
            this.rbt_bank_style.Size = new System.Drawing.Size(145, 19);
            this.rbt_bank_style.TabIndex = 1;
            this.rbt_bank_style.TabStop = true;
            this.rbt_bank_style.Text = "Split Banks and Offsets";
            this.rbt_bank_style.UseVisualStyleBackColor = true;
            this.rbt_bank_style.CheckedChanged += new System.EventHandler(this.rbt_bank_style_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 216);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(376, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgramSettins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 238);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_offset_style);
            this.Controls.Add(this.grp_hex_indicator);
            this.Controls.Add(this.grp_rom_settings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 75);
            this.Name = "ProgramSettins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Settings";
            this.grp_rom_settings.ResumeLayout(false);
            this.grp_rom_settings.PerformLayout();
            this.grp_hex_indicator.ResumeLayout(false);
            this.grp_hex_indicator.PerformLayout();
            this.grp_offset_style.ResumeLayout(false);
            this.grp_offset_style.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}