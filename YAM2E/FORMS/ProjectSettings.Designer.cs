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
            sep_writeOffsetsSeperator = new Controls.Other.Seperator();
            pnl_offsets = new System.Windows.Forms.Panel();
            chb_assemble_compile = new System.Windows.Forms.CheckBox();
            chb_fix_object_loading = new System.Windows.Forms.CheckBox();
            chb_rmv_mt_o_list = new System.Windows.Forms.CheckBox();
            tlt_info = new System.Windows.Forms.ToolTip(components);
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_tileset_usage = new System.Windows.Forms.GroupBox();
            txb_default_tile = new System.Windows.Forms.TextBox();
            lbl_default_tile = new System.Windows.Forms.Label();
            rbt_use_tilesets = new System.Windows.Forms.RadioButton();
            rbt_use_offsets = new System.Windows.Forms.RadioButton();
            txb_rom_path = new System.Windows.Forms.TextBox();
            btn_select_rom = new System.Windows.Forms.Button();
            lbl_specific_rom_path = new System.Windows.Forms.Label();
            grp_project_specific_rom = new System.Windows.Forms.GroupBox();
            lbl_disassembly_path = new System.Windows.Forms.Label();
            btn_select_disassembly = new System.Windows.Forms.Button();
            txb_disassembly_path = new System.Windows.Forms.TextBox();
            pnl_main = new System.Windows.Forms.Panel();
            grp_compiler.SuspendLayout();
            grp_tileset_usage.SuspendLayout();
            grp_project_specific_rom.SuspendLayout();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // grp_compiler
            // 
            grp_compiler.Controls.Add(sep_writeOffsetsSeperator);
            grp_compiler.Controls.Add(pnl_offsets);
            grp_compiler.Controls.Add(chb_assemble_compile);
            grp_compiler.Controls.Add(chb_fix_object_loading);
            grp_compiler.Controls.Add(chb_rmv_mt_o_list);
            grp_compiler.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_compiler.Location = new System.Drawing.Point(6, 221);
            grp_compiler.Name = "grp_compiler";
            grp_compiler.Padding = new System.Windows.Forms.Padding(6);
            grp_compiler.Size = new System.Drawing.Size(398, 364);
            grp_compiler.TabIndex = 0;
            grp_compiler.TabStop = false;
            grp_compiler.Text = "Compiling";
            // 
            // sep_writeOffsetsSeperator
            // 
            sep_writeOffsetsSeperator.BackColor = System.Drawing.SystemColors.ControlDark;
            sep_writeOffsetsSeperator.Dock = System.Windows.Forms.DockStyle.Top;
            sep_writeOffsetsSeperator.Location = new System.Drawing.Point(6, 79);
            sep_writeOffsetsSeperator.MaximumSize = new System.Drawing.Size(0, 1);
            sep_writeOffsetsSeperator.Name = "sep_writeOffsetsSeperator";
            sep_writeOffsetsSeperator.Size = new System.Drawing.Size(386, 1);
            sep_writeOffsetsSeperator.TabIndex = 2;
            // 
            // pnl_offsets
            // 
            pnl_offsets.AutoScroll = true;
            pnl_offsets.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_offsets.Location = new System.Drawing.Point(6, 79);
            pnl_offsets.Name = "pnl_offsets";
            pnl_offsets.Size = new System.Drawing.Size(386, 279);
            pnl_offsets.TabIndex = 1;
            // 
            // chb_assemble_compile
            // 
            chb_assemble_compile.AutoSize = true;
            chb_assemble_compile.Dock = System.Windows.Forms.DockStyle.Top;
            chb_assemble_compile.Enabled = false;
            chb_assemble_compile.Location = new System.Drawing.Point(6, 60);
            chb_assemble_compile.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            chb_assemble_compile.Name = "chb_assemble_compile";
            chb_assemble_compile.Size = new System.Drawing.Size(386, 19);
            chb_assemble_compile.TabIndex = 9;
            chb_assemble_compile.Text = "Build assembly before compilation";
            tlt_info.SetToolTip(chb_assemble_compile, "If the object data gets optimised, it is reccommended\r\nto use the HEX tweak that changes vertical object\r\nloading!");
            chb_assemble_compile.UseVisualStyleBackColor = true;
            chb_assemble_compile.CheckedChanged += btn_assemble_compile_CheckedChanged;
            // 
            // chb_fix_object_loading
            // 
            chb_fix_object_loading.AutoSize = true;
            chb_fix_object_loading.Dock = System.Windows.Forms.DockStyle.Top;
            chb_fix_object_loading.Location = new System.Drawing.Point(6, 41);
            chb_fix_object_loading.Name = "chb_fix_object_loading";
            chb_fix_object_loading.Size = new System.Drawing.Size(386, 19);
            chb_fix_object_loading.TabIndex = 3;
            chb_fix_object_loading.Text = "Fix vertical Object loading";
            chb_fix_object_loading.UseVisualStyleBackColor = true;
            chb_fix_object_loading.CheckedChanged += chb_fix_object_loading_CheckedChanged;
            // 
            // chb_rmv_mt_o_list
            // 
            chb_rmv_mt_o_list.AutoSize = true;
            chb_rmv_mt_o_list.Dock = System.Windows.Forms.DockStyle.Top;
            chb_rmv_mt_o_list.Location = new System.Drawing.Point(6, 22);
            chb_rmv_mt_o_list.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            chb_rmv_mt_o_list.Name = "chb_rmv_mt_o_list";
            chb_rmv_mt_o_list.Size = new System.Drawing.Size(386, 19);
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
            statusStrip1.Location = new System.Drawing.Point(0, 591);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(410, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_usage
            // 
            grp_tileset_usage.Controls.Add(txb_default_tile);
            grp_tileset_usage.Controls.Add(lbl_default_tile);
            grp_tileset_usage.Controls.Add(rbt_use_tilesets);
            grp_tileset_usage.Controls.Add(rbt_use_offsets);
            grp_tileset_usage.Dock = System.Windows.Forms.DockStyle.Top;
            grp_tileset_usage.Location = new System.Drawing.Point(6, 118);
            grp_tileset_usage.Name = "grp_tileset_usage";
            grp_tileset_usage.Size = new System.Drawing.Size(398, 103);
            grp_tileset_usage.TabIndex = 2;
            grp_tileset_usage.TabStop = false;
            grp_tileset_usage.Text = "Tileset Usage";
            // 
            // txb_default_tile
            // 
            txb_default_tile.Location = new System.Drawing.Point(81, 71);
            txb_default_tile.Name = "txb_default_tile";
            txb_default_tile.Size = new System.Drawing.Size(32, 23);
            txb_default_tile.TabIndex = 3;
            txb_default_tile.TextChanged += txb_default_tile_TextChanged;
            // 
            // lbl_default_tile
            // 
            lbl_default_tile.AutoSize = true;
            lbl_default_tile.Location = new System.Drawing.Point(6, 74);
            lbl_default_tile.Name = "lbl_default_tile";
            lbl_default_tile.Size = new System.Drawing.Size(69, 15);
            lbl_default_tile.TabIndex = 2;
            lbl_default_tile.Text = "Default Tile:";
            // 
            // rbt_use_tilesets
            // 
            rbt_use_tilesets.AutoSize = true;
            rbt_use_tilesets.Location = new System.Drawing.Point(6, 48);
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
            txb_rom_path.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_rom_path.Location = new System.Drawing.Point(6, 37);
            txb_rom_path.Name = "txb_rom_path";
            txb_rom_path.Size = new System.Drawing.Size(357, 23);
            txb_rom_path.TabIndex = 4;
            txb_rom_path.TextChanged += txb_rom_path_TextChanged;
            // 
            // btn_select_rom
            // 
            btn_select_rom.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_select_rom.Image = (System.Drawing.Image)resources.GetObject("btn_select_rom.Image");
            btn_select_rom.Location = new System.Drawing.Point(369, 37);
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
            lbl_specific_rom_path.Size = new System.Drawing.Size(148, 15);
            lbl_specific_rom_path.TabIndex = 3;
            lbl_specific_rom_path.Text = "Project specifig ROM Path:";
            // 
            // grp_project_specific_rom
            // 
            grp_project_specific_rom.Controls.Add(lbl_disassembly_path);
            grp_project_specific_rom.Controls.Add(btn_select_disassembly);
            grp_project_specific_rom.Controls.Add(txb_disassembly_path);
            grp_project_specific_rom.Controls.Add(lbl_specific_rom_path);
            grp_project_specific_rom.Controls.Add(btn_select_rom);
            grp_project_specific_rom.Controls.Add(txb_rom_path);
            grp_project_specific_rom.Dock = System.Windows.Forms.DockStyle.Top;
            grp_project_specific_rom.Location = new System.Drawing.Point(6, 3);
            grp_project_specific_rom.Name = "grp_project_specific_rom";
            grp_project_specific_rom.Size = new System.Drawing.Size(398, 115);
            grp_project_specific_rom.TabIndex = 6;
            grp_project_specific_rom.TabStop = false;
            grp_project_specific_rom.Text = "Paths";
            // 
            // lbl_disassembly_path
            // 
            lbl_disassembly_path.AutoSize = true;
            lbl_disassembly_path.Location = new System.Drawing.Point(6, 63);
            lbl_disassembly_path.Name = "lbl_disassembly_path";
            lbl_disassembly_path.Size = new System.Drawing.Size(102, 15);
            lbl_disassembly_path.TabIndex = 6;
            lbl_disassembly_path.Text = "Disassembly Path:";
            // 
            // btn_select_disassembly
            // 
            btn_select_disassembly.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_select_disassembly.Image = (System.Drawing.Image)resources.GetObject("btn_select_disassembly.Image");
            btn_select_disassembly.Location = new System.Drawing.Point(369, 81);
            btn_select_disassembly.Name = "btn_select_disassembly";
            btn_select_disassembly.Size = new System.Drawing.Size(23, 23);
            btn_select_disassembly.TabIndex = 8;
            btn_select_disassembly.UseVisualStyleBackColor = true;
            btn_select_disassembly.Click += btn_select_disassembly_Click;
            // 
            // txb_disassembly_path
            // 
            txb_disassembly_path.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_disassembly_path.Location = new System.Drawing.Point(6, 81);
            txb_disassembly_path.Name = "txb_disassembly_path";
            txb_disassembly_path.Size = new System.Drawing.Size(357, 23);
            txb_disassembly_path.TabIndex = 7;
            txb_disassembly_path.TextChanged += txb_disassembly_path_TextChanged;
            // 
            // pnl_main
            // 
            pnl_main.Controls.Add(grp_compiler);
            pnl_main.Controls.Add(grp_tileset_usage);
            pnl_main.Controls.Add(grp_project_specific_rom);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(6, 3, 6, 6);
            pnl_main.Size = new System.Drawing.Size(410, 591);
            pnl_main.TabIndex = 7;
            // 
            // ProjectSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(410, 613);
            Controls.Add(pnl_main);
            Controls.Add(statusStrip1);
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
            pnl_main.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_offsets;
        private Controls.Other.Seperator sep_writeOffsetsSeperator;
        private System.Windows.Forms.CheckBox chb_fix_object_loading;
        private System.Windows.Forms.Label lbl_default_tile;
        private System.Windows.Forms.TextBox txb_default_tile;
        private System.Windows.Forms.Label lbl_disassembly_path;
        private System.Windows.Forms.Button btn_select_disassembly;
        private System.Windows.Forms.TextBox txb_disassembly_path;
        private System.Windows.Forms.CheckBox chb_assemble_compile;
    }
}