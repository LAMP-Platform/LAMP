namespace LAMP.FORMS
{
    partial class ProjectSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettings));
            grp_compiler = new System.Windows.Forms.GroupBox();
            chb_rmv_mt_o_list = new System.Windows.Forms.CheckBox();
            tlt_info = new System.Windows.Forms.ToolTip(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_tileset_usage = new System.Windows.Forms.GroupBox();
            rbt_use_tilesets = new System.Windows.Forms.RadioButton();
            rbt_use_offsets = new System.Windows.Forms.RadioButton();
            txb_rom_path = new System.Windows.Forms.TextBox();
            btn_select_rom = new System.Windows.Forms.Button();
            lbl_specific_rom_path = new System.Windows.Forms.Label();
            grp_project_specific_rom = new System.Windows.Forms.GroupBox();
            grp_compiler.SuspendLayout();
            grp_tileset_usage.SuspendLayout();
            grp_project_specific_rom.SuspendLayout();
            SuspendLayout();
            // 
            // grp_compiler
            // 
            grp_compiler.Controls.Add(chb_rmv_mt_o_list);
            grp_compiler.Location = new System.Drawing.Point(12, 90);
            grp_compiler.Name = "grp_compiler";
            grp_compiler.Size = new System.Drawing.Size(262, 50);
            grp_compiler.TabIndex = 0;
            grp_compiler.TabStop = false;
            grp_compiler.Text = "Compiling";
            // 
            // chb_rmv_mt_o_list
            // 
            chb_rmv_mt_o_list.AutoSize = true;
            chb_rmv_mt_o_list.Location = new System.Drawing.Point(6, 22);
            chb_rmv_mt_o_list.Name = "chb_rmv_mt_o_list";
            chb_rmv_mt_o_list.Size = new System.Drawing.Size(139, 19);
            chb_rmv_mt_o_list.TabIndex = 0;
            chb_rmv_mt_o_list.Text = "Optimise Object Data";
            tlt_info.SetToolTip(chb_rmv_mt_o_list, "If the object data gets optimised, it is reccommended\r\nto use the HEX tweak that changes vertical object\r\nloading!");
            chb_rmv_mt_o_list.UseVisualStyleBackColor = true;
            chb_rmv_mt_o_list.CheckedChanged += chb_rmv_mt_o_list_CheckedChanged;
            // 
            // tlt_info
            // 
            tlt_info.AutoPopDelay = 5000;
            tlt_info.InitialDelay = 300;
            tlt_info.ReshowDelay = 100;
            tlt_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            tlt_info.ToolTipTitle = "Info";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 234);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(284, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_usage
            // 
            grp_tileset_usage.Controls.Add(rbt_use_tilesets);
            grp_tileset_usage.Controls.Add(rbt_use_offsets);
            grp_tileset_usage.Location = new System.Drawing.Point(12, 146);
            grp_tileset_usage.Name = "grp_tileset_usage";
            grp_tileset_usage.Size = new System.Drawing.Size(262, 77);
            grp_tileset_usage.TabIndex = 2;
            grp_tileset_usage.TabStop = false;
            grp_tileset_usage.Text = "Tileset Usage";
            // 
            // rbt_use_tilesets
            // 
            rbt_use_tilesets.AutoSize = true;
            rbt_use_tilesets.Location = new System.Drawing.Point(6, 47);
            rbt_use_tilesets.Name = "rbt_use_tilesets";
            rbt_use_tilesets.Size = new System.Drawing.Size(141, 19);
            rbt_use_tilesets.TabIndex = 1;
            rbt_use_tilesets.Text = "Use Tilesets if possible";
            rbt_use_tilesets.UseVisualStyleBackColor = true;
            rbt_use_tilesets.CheckedChanged += rbt_use_tilesets_CheckedChanged;
            // 
            // rbt_use_offsets
            // 
            rbt_use_offsets.AutoSize = true;
            rbt_use_offsets.Checked = true;
            rbt_use_offsets.Location = new System.Drawing.Point(6, 22);
            rbt_use_offsets.Name = "rbt_use_offsets";
            rbt_use_offsets.Size = new System.Drawing.Size(225, 19);
            rbt_use_offsets.TabIndex = 0;
            rbt_use_offsets.TabStop = true;
            rbt_use_offsets.Text = "Use direct graphical Offsets if possible";
            rbt_use_offsets.UseVisualStyleBackColor = true;
            rbt_use_offsets.CheckedChanged += rbt_use_offsets_CheckedChanged;
            // 
            // txb_rom_path
            // 
            txb_rom_path.Location = new System.Drawing.Point(6, 37);
            txb_rom_path.Name = "txb_rom_path";
            txb_rom_path.Size = new System.Drawing.Size(221, 23);
            txb_rom_path.TabIndex = 4;
            txb_rom_path.TextChanged += txb_rom_path_TextChanged;
            // 
            // btn_select_rom
            // 
            btn_select_rom.Image = (System.Drawing.Image)resources.GetObject("btn_select_rom.Image");
            btn_select_rom.Location = new System.Drawing.Point(233, 37);
            btn_select_rom.Name = "btn_select_rom";
            btn_select_rom.Size = new System.Drawing.Size(23, 23);
            btn_select_rom.TabIndex = 5;
            btn_select_rom.UseVisualStyleBackColor = true;
            btn_select_rom.Click += btn_select_rom_Click;
            // 
            // lbl_specific_rom_path
            // 
            lbl_specific_rom_path.AutoSize = true;
            lbl_specific_rom_path.Location = new System.Drawing.Point(6, 19);
            lbl_specific_rom_path.Name = "lbl_specific_rom_path";
            lbl_specific_rom_path.Size = new System.Drawing.Size(64, 15);
            lbl_specific_rom_path.TabIndex = 3;
            lbl_specific_rom_path.Text = "ROM Path:";
            // 
            // grp_project_specific_rom
            // 
            grp_project_specific_rom.Controls.Add(lbl_specific_rom_path);
            grp_project_specific_rom.Controls.Add(btn_select_rom);
            grp_project_specific_rom.Controls.Add(txb_rom_path);
            grp_project_specific_rom.Location = new System.Drawing.Point(12, 12);
            grp_project_specific_rom.Name = "grp_project_specific_rom";
            grp_project_specific_rom.Size = new System.Drawing.Size(262, 72);
            grp_project_specific_rom.TabIndex = 6;
            grp_project_specific_rom.TabStop = false;
            grp_project_specific_rom.Text = "Project specific ROM";
            // 
            // ProjectSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(284, 256);
            Controls.Add(grp_project_specific_rom);
            Controls.Add(grp_tileset_usage);
            Controls.Add(statusStrip1);
            Controls.Add(grp_compiler);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(300, 295);
            Name = "ProjectSettings";
            Text = "Project Settings";
            grp_compiler.ResumeLayout(false);
            grp_compiler.PerformLayout();
            grp_tileset_usage.ResumeLayout(false);
            grp_tileset_usage.PerformLayout();
            grp_project_specific_rom.ResumeLayout(false);
            grp_project_specific_rom.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_compiler;
        private System.Windows.Forms.CheckBox chb_rmv_mt_o_list;
        private System.Windows.Forms.ToolTip tlt_info;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grp_tileset_usage;
        private System.Windows.Forms.RadioButton rbt_use_tilesets;
        private System.Windows.Forms.RadioButton rbt_use_offsets;
        private System.Windows.Forms.TextBox txb_rom_path;
        private System.Windows.Forms.Button btn_select_rom;
        private System.Windows.Forms.Label lbl_specific_rom_path;
        private System.Windows.Forms.GroupBox grp_project_specific_rom;
    }
}