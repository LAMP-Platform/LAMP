
namespace YAM2E.FORMS
{
    partial class tweaks_editor
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
            this.lbl_tweak_samus_speed = new System.Windows.Forms.Label();
            this.num_tweak_samus_speed = new System.Windows.Forms.NumericUpDown();
            this.grp_twed_samus_checks = new System.Windows.Forms.GroupBox();
            this.chb_tweak_center_samus = new System.Windows.Forms.CheckBox();
            this.tab_twed_weapons = new System.Windows.Forms.TabPage();
            this.tab_twed_drops = new System.Windows.Forms.TabPage();
            this.tab_twed_misc = new System.Windows.Forms.TabPage();
            this.btn_apply_tweaks = new System.Windows.Forms.Button();
            this.btn_close_tweaks = new System.Windows.Forms.Button();
            this.tabc_tweaks_editor.SuspendLayout();
            this.tab_twed_samus.SuspendLayout();
            this.grp_twed_samus_values.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_samus_speed)).BeginInit();
            this.grp_twed_samus_checks.SuspendLayout();
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
            this.tabc_tweaks_editor.Size = new System.Drawing.Size(665, 423);
            this.tabc_tweaks_editor.TabIndex = 0;
            // 
            // tab_twed_samus
            // 
            this.tab_twed_samus.Controls.Add(this.grp_twed_samus_values);
            this.tab_twed_samus.Controls.Add(this.grp_twed_samus_checks);
            this.tab_twed_samus.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_samus.Name = "tab_twed_samus";
            this.tab_twed_samus.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_samus.Size = new System.Drawing.Size(657, 395);
            this.tab_twed_samus.TabIndex = 0;
            this.tab_twed_samus.Text = "Samus";
            this.tab_twed_samus.UseVisualStyleBackColor = true;
            // 
            // grp_twed_samus_values
            // 
            this.grp_twed_samus_values.Controls.Add(this.lbl_tweak_samus_speed);
            this.grp_twed_samus_values.Controls.Add(this.num_tweak_samus_speed);
            this.grp_twed_samus_values.Location = new System.Drawing.Point(9, 192);
            this.grp_twed_samus_values.Name = "grp_twed_samus_values";
            this.grp_twed_samus_values.Size = new System.Drawing.Size(249, 188);
            this.grp_twed_samus_values.TabIndex = 1;
            this.grp_twed_samus_values.TabStop = false;
            this.grp_twed_samus_values.Text = "Values";
            // 
            // lbl_tweak_samus_speed
            // 
            this.lbl_tweak_samus_speed.AutoSize = true;
            this.lbl_tweak_samus_speed.Location = new System.Drawing.Point(69, 25);
            this.lbl_tweak_samus_speed.Name = "lbl_tweak_samus_speed";
            this.lbl_tweak_samus_speed.Size = new System.Drawing.Size(124, 15);
            this.lbl_tweak_samus_speed.TabIndex = 1;
            this.lbl_tweak_samus_speed.Text = "Samus\' running speed";
            // 
            // num_tweak_samus_speed
            // 
            this.num_tweak_samus_speed.Hexadecimal = true;
            this.num_tweak_samus_speed.Location = new System.Drawing.Point(7, 23);
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
            this.grp_twed_samus_checks.Controls.Add(this.chb_tweak_center_samus);
            this.grp_twed_samus_checks.Location = new System.Drawing.Point(9, 7);
            this.grp_twed_samus_checks.Name = "grp_twed_samus_checks";
            this.grp_twed_samus_checks.Size = new System.Drawing.Size(249, 178);
            this.grp_twed_samus_checks.TabIndex = 0;
            this.grp_twed_samus_checks.TabStop = false;
            this.grp_twed_samus_checks.Text = "Checks";
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
            this.tab_twed_weapons.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_weapons.Name = "tab_twed_weapons";
            this.tab_twed_weapons.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_weapons.Size = new System.Drawing.Size(602, 439);
            this.tab_twed_weapons.TabIndex = 1;
            this.tab_twed_weapons.Text = "Weapons";
            this.tab_twed_weapons.UseVisualStyleBackColor = true;
            // 
            // tab_twed_drops
            // 
            this.tab_twed_drops.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_drops.Name = "tab_twed_drops";
            this.tab_twed_drops.Padding = new System.Windows.Forms.Padding(3);
            this.tab_twed_drops.Size = new System.Drawing.Size(602, 439);
            this.tab_twed_drops.TabIndex = 2;
            this.tab_twed_drops.Text = "Drops & Items";
            this.tab_twed_drops.UseVisualStyleBackColor = true;
            // 
            // tab_twed_misc
            // 
            this.tab_twed_misc.Location = new System.Drawing.Point(4, 24);
            this.tab_twed_misc.Name = "tab_twed_misc";
            this.tab_twed_misc.Size = new System.Drawing.Size(602, 439);
            this.tab_twed_misc.TabIndex = 3;
            this.tab_twed_misc.Text = "Miscellaneous";
            this.tab_twed_misc.UseVisualStyleBackColor = true;
            // 
            // btn_apply_tweaks
            // 
            this.btn_apply_tweaks.Location = new System.Drawing.Point(578, 429);
            this.btn_apply_tweaks.Name = "btn_apply_tweaks";
            this.btn_apply_tweaks.Size = new System.Drawing.Size(75, 23);
            this.btn_apply_tweaks.TabIndex = 1;
            this.btn_apply_tweaks.Text = "Apply";
            this.btn_apply_tweaks.UseVisualStyleBackColor = true;
            // 
            // btn_close_tweaks
            // 
            this.btn_close_tweaks.Location = new System.Drawing.Point(497, 429);
            this.btn_close_tweaks.Name = "btn_close_tweaks";
            this.btn_close_tweaks.Size = new System.Drawing.Size(75, 23);
            this.btn_close_tweaks.TabIndex = 2;
            this.btn_close_tweaks.Text = "Close";
            this.btn_close_tweaks.UseVisualStyleBackColor = true;
            this.btn_close_tweaks.Click += new System.EventHandler(this.btn_close_tweaks_Click);
            // 
            // tweaks_editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 464);
            this.Controls.Add(this.btn_close_tweaks);
            this.Controls.Add(this.btn_apply_tweaks);
            this.Controls.Add(this.tabc_tweaks_editor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "tweaks_editor";
            this.Text = "Tweaks";
            this.tabc_tweaks_editor.ResumeLayout(false);
            this.tab_twed_samus.ResumeLayout(false);
            this.grp_twed_samus_values.ResumeLayout(false);
            this.grp_twed_samus_values.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_tweak_samus_speed)).EndInit();
            this.grp_twed_samus_checks.ResumeLayout(false);
            this.grp_twed_samus_checks.PerformLayout();
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
    }
}