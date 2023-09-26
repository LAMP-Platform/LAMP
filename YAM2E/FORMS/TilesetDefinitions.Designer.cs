namespace LAMP.FORMS
{
    partial class TilesetDefinitions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TilesetDefinitions));
            grp_tileset_data = new System.Windows.Forms.GroupBox();
            btn_edit_solidity = new System.Windows.Forms.Button();
            btn_edit_collision = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            txb_gfx_offset = new System.Windows.Forms.TextBox();
            btn_remove_tileset = new System.Windows.Forms.Button();
            btn_add_tileset = new System.Windows.Forms.Button();
            cbb_solidity_table = new System.Windows.Forms.ComboBox();
            txb_tileset_name = new System.Windows.Forms.TextBox();
            lbl_soliditiy_table = new System.Windows.Forms.Label();
            lbl_tileset_name = new System.Windows.Forms.Label();
            cbb_tileset_id = new System.Windows.Forms.ComboBox();
            lbl_tileset_id = new System.Windows.Forms.Label();
            cbb_collision_table = new System.Windows.Forms.ComboBox();
            lbl_collision_table = new System.Windows.Forms.Label();
            lbl_tileset_gfx_offset = new System.Windows.Forms.Label();
            cbb_metatile_table = new System.Windows.Forms.ComboBox();
            lbl_metatile_table = new System.Windows.Forms.Label();
            btn_save_tileset = new System.Windows.Forms.Button();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_tileset_preview = new System.Windows.Forms.GroupBox();
            pnl_preview = new System.Windows.Forms.Panel();
            Toolbar = new Controls.Room.ToolBar();
            splt_main = new System.Windows.Forms.SplitContainer();
            pnl_tileset_preview = new System.Windows.Forms.Panel();
            pnl_apply_button = new System.Windows.Forms.Panel();
            lbl_spring = new System.Windows.Forms.ToolStripStatusLabel();
            btn_import = new System.Windows.Forms.ToolStripDropDownButton();
            btn_export = new System.Windows.Forms.ToolStripDropDownButton();
            grp_tileset_data.SuspendLayout();
            statusStrip1.SuspendLayout();
            grp_tileset_preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splt_main).BeginInit();
            splt_main.Panel1.SuspendLayout();
            splt_main.Panel2.SuspendLayout();
            splt_main.SuspendLayout();
            pnl_tileset_preview.SuspendLayout();
            pnl_apply_button.SuspendLayout();
            SuspendLayout();
            // 
            // grp_tileset_data
            // 
            grp_tileset_data.Controls.Add(btn_edit_solidity);
            grp_tileset_data.Controls.Add(btn_edit_collision);
            grp_tileset_data.Controls.Add(btn_edit);
            grp_tileset_data.Controls.Add(txb_gfx_offset);
            grp_tileset_data.Controls.Add(btn_remove_tileset);
            grp_tileset_data.Controls.Add(btn_add_tileset);
            grp_tileset_data.Controls.Add(cbb_solidity_table);
            grp_tileset_data.Controls.Add(txb_tileset_name);
            grp_tileset_data.Controls.Add(lbl_soliditiy_table);
            grp_tileset_data.Controls.Add(lbl_tileset_name);
            grp_tileset_data.Controls.Add(cbb_tileset_id);
            grp_tileset_data.Controls.Add(lbl_tileset_id);
            grp_tileset_data.Controls.Add(cbb_collision_table);
            grp_tileset_data.Controls.Add(lbl_collision_table);
            grp_tileset_data.Controls.Add(lbl_tileset_gfx_offset);
            grp_tileset_data.Controls.Add(cbb_metatile_table);
            grp_tileset_data.Controls.Add(lbl_metatile_table);
            grp_tileset_data.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_tileset_data.Location = new System.Drawing.Point(6, 6);
            grp_tileset_data.Name = "grp_tileset_data";
            grp_tileset_data.Size = new System.Drawing.Size(277, 209);
            grp_tileset_data.TabIndex = 0;
            grp_tileset_data.TabStop = false;
            grp_tileset_data.Text = "Tileset Data";
            // 
            // btn_edit_solidity
            // 
            btn_edit_solidity.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_edit_solidity.Image = Properties.Resources.PenOneSelected;
            btn_edit_solidity.Location = new System.Drawing.Point(246, 161);
            btn_edit_solidity.Name = "btn_edit_solidity";
            btn_edit_solidity.Size = new System.Drawing.Size(23, 23);
            btn_edit_solidity.TabIndex = 24;
            btn_edit_solidity.UseVisualStyleBackColor = true;
            btn_edit_solidity.Click += btn_edit_solidity_Click;
            // 
            // btn_edit_collision
            // 
            btn_edit_collision.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_edit_collision.Image = Properties.Resources.PenOneSelected;
            btn_edit_collision.Location = new System.Drawing.Point(246, 132);
            btn_edit_collision.Name = "btn_edit_collision";
            btn_edit_collision.Size = new System.Drawing.Size(23, 23);
            btn_edit_collision.TabIndex = 23;
            btn_edit_collision.UseVisualStyleBackColor = true;
            btn_edit_collision.Click += btn_edit_collision_Click;
            // 
            // btn_edit
            // 
            btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_edit.Image = Properties.Resources.PenOneSelected;
            btn_edit.Location = new System.Drawing.Point(246, 103);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(23, 23);
            btn_edit.TabIndex = 22;
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // txb_gfx_offset
            // 
            txb_gfx_offset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_gfx_offset.Location = new System.Drawing.Point(103, 74);
            txb_gfx_offset.Name = "txb_gfx_offset";
            txb_gfx_offset.Size = new System.Drawing.Size(166, 23);
            txb_gfx_offset.TabIndex = 0;
            // 
            // btn_remove_tileset
            // 
            btn_remove_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_remove_tileset.Image = Properties.Resources.Remove;
            btn_remove_tileset.Location = new System.Drawing.Point(246, 16);
            btn_remove_tileset.Name = "btn_remove_tileset";
            btn_remove_tileset.Size = new System.Drawing.Size(23, 23);
            btn_remove_tileset.TabIndex = 21;
            btn_remove_tileset.UseVisualStyleBackColor = true;
            btn_remove_tileset.Click += btn_remove_tileset_Click;
            // 
            // btn_add_tileset
            // 
            btn_add_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_add_tileset.Image = Properties.Resources.Add;
            btn_add_tileset.Location = new System.Drawing.Point(217, 17);
            btn_add_tileset.Name = "btn_add_tileset";
            btn_add_tileset.Size = new System.Drawing.Size(23, 23);
            btn_add_tileset.TabIndex = 20;
            btn_add_tileset.UseVisualStyleBackColor = true;
            btn_add_tileset.Click += btn_add_tileset_Click;
            // 
            // cbb_solidity_table
            // 
            cbb_solidity_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_solidity_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_solidity_table.FormattingEnabled = true;
            cbb_solidity_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_solidity_table.Location = new System.Drawing.Point(103, 161);
            cbb_solidity_table.Name = "cbb_solidity_table";
            cbb_solidity_table.Size = new System.Drawing.Size(137, 23);
            cbb_solidity_table.TabIndex = 18;
            // 
            // txb_tileset_name
            // 
            txb_tileset_name.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_tileset_name.Location = new System.Drawing.Point(103, 45);
            txb_tileset_name.Name = "txb_tileset_name";
            txb_tileset_name.Size = new System.Drawing.Size(166, 23);
            txb_tileset_name.TabIndex = 14;
            // 
            // lbl_soliditiy_table
            // 
            lbl_soliditiy_table.AutoSize = true;
            lbl_soliditiy_table.Location = new System.Drawing.Point(6, 164);
            lbl_soliditiy_table.Name = "lbl_soliditiy_table";
            lbl_soliditiy_table.Size = new System.Drawing.Size(89, 15);
            lbl_soliditiy_table.TabIndex = 17;
            lbl_soliditiy_table.Text = "Solidity Indices:";
            // 
            // lbl_tileset_name
            // 
            lbl_tileset_name.AutoSize = true;
            lbl_tileset_name.Location = new System.Drawing.Point(6, 48);
            lbl_tileset_name.Name = "lbl_tileset_name";
            lbl_tileset_name.Size = new System.Drawing.Size(42, 15);
            lbl_tileset_name.TabIndex = 13;
            lbl_tileset_name.Text = "Name:";
            // 
            // cbb_tileset_id
            // 
            cbb_tileset_id.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_tileset_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_tileset_id.FormattingEnabled = true;
            cbb_tileset_id.Location = new System.Drawing.Point(103, 16);
            cbb_tileset_id.Name = "cbb_tileset_id";
            cbb_tileset_id.Size = new System.Drawing.Size(108, 23);
            cbb_tileset_id.TabIndex = 10;
            cbb_tileset_id.SelectedIndexChanged += cbb_tileset_id_SelectedIndexChanged;
            // 
            // lbl_tileset_id
            // 
            lbl_tileset_id.AutoSize = true;
            lbl_tileset_id.Location = new System.Drawing.Point(6, 19);
            lbl_tileset_id.Name = "lbl_tileset_id";
            lbl_tileset_id.Size = new System.Drawing.Size(43, 15);
            lbl_tileset_id.TabIndex = 9;
            lbl_tileset_id.Text = "Tileset:";
            // 
            // cbb_collision_table
            // 
            cbb_collision_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_collision_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_collision_table.FormattingEnabled = true;
            cbb_collision_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_collision_table.Location = new System.Drawing.Point(103, 132);
            cbb_collision_table.Name = "cbb_collision_table";
            cbb_collision_table.Size = new System.Drawing.Size(137, 23);
            cbb_collision_table.TabIndex = 16;
            // 
            // lbl_collision_table
            // 
            lbl_collision_table.AutoSize = true;
            lbl_collision_table.Location = new System.Drawing.Point(6, 135);
            lbl_collision_table.Name = "lbl_collision_table";
            lbl_collision_table.Size = new System.Drawing.Size(86, 15);
            lbl_collision_table.TabIndex = 15;
            lbl_collision_table.Text = "Collision Table:";
            // 
            // lbl_tileset_gfx_offset
            // 
            lbl_tileset_gfx_offset.AutoSize = true;
            lbl_tileset_gfx_offset.Location = new System.Drawing.Point(6, 77);
            lbl_tileset_gfx_offset.Name = "lbl_tileset_gfx_offset";
            lbl_tileset_gfx_offset.Size = new System.Drawing.Size(91, 15);
            lbl_tileset_gfx_offset.TabIndex = 0;
            lbl_tileset_gfx_offset.Text = "Graphics Offset:";
            // 
            // cbb_metatile_table
            // 
            cbb_metatile_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_metatile_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_metatile_table.FormattingEnabled = true;
            cbb_metatile_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbb_metatile_table.Location = new System.Drawing.Point(103, 103);
            cbb_metatile_table.Name = "cbb_metatile_table";
            cbb_metatile_table.Size = new System.Drawing.Size(137, 23);
            cbb_metatile_table.TabIndex = 12;
            cbb_metatile_table.SelectedIndexChanged += cbb_metatile_table_SelectedIndexChanged;
            // 
            // lbl_metatile_table
            // 
            lbl_metatile_table.AutoSize = true;
            lbl_metatile_table.Location = new System.Drawing.Point(6, 106);
            lbl_metatile_table.Name = "lbl_metatile_table";
            lbl_metatile_table.Size = new System.Drawing.Size(83, 15);
            lbl_metatile_table.TabIndex = 11;
            lbl_metatile_table.Text = "Metatile Table:";
            // 
            // btn_save_tileset
            // 
            btn_save_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_save_tileset.Enabled = false;
            btn_save_tileset.Image = Properties.Resources.Save;
            btn_save_tileset.Location = new System.Drawing.Point(204, 3);
            btn_save_tileset.Name = "btn_save_tileset";
            btn_save_tileset.Size = new System.Drawing.Size(64, 23);
            btn_save_tileset.TabIndex = 19;
            btn_save_tileset.Text = "Apply";
            btn_save_tileset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_save_tileset.UseVisualStyleBackColor = true;
            btn_save_tileset.Click += btn_save_tileset_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lbl_spring, btn_import, btn_export });
            statusStrip1.Location = new System.Drawing.Point(0, 221);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(567, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_preview
            // 
            grp_tileset_preview.Controls.Add(pnl_preview);
            grp_tileset_preview.Controls.Add(Toolbar);
            grp_tileset_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_tileset_preview.Location = new System.Drawing.Point(0, 0);
            grp_tileset_preview.Name = "grp_tileset_preview";
            grp_tileset_preview.Size = new System.Drawing.Size(268, 180);
            grp_tileset_preview.TabIndex = 2;
            grp_tileset_preview.TabStop = false;
            grp_tileset_preview.Text = "Preview";
            // 
            // pnl_preview
            // 
            pnl_preview.AutoScroll = true;
            pnl_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_preview.Location = new System.Drawing.Point(3, 43);
            pnl_preview.Name = "pnl_preview";
            pnl_preview.Size = new System.Drawing.Size(262, 134);
            pnl_preview.TabIndex = 1;
            // 
            // Toolbar
            // 
            Toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            Toolbar.Location = new System.Drawing.Point(3, 19);
            Toolbar.MaxZoom = 10;
            Toolbar.Name = "Toolbar";
            Toolbar.onToolCommandTriggered = null;
            Toolbar.onToolSwitched = null;
            Toolbar.SelectedTool = LampTool.Pen;
            Toolbar.Size = new System.Drawing.Size(262, 24);
            Toolbar.TabIndex = 0;
            Toolbar.ZoomLevel = 1;
            Toolbar.ToolCommandTriggered += Toolbar_ToolCommandTriggered;
            // 
            // splt_main
            // 
            splt_main.Dock = System.Windows.Forms.DockStyle.Fill;
            splt_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splt_main.Location = new System.Drawing.Point(0, 0);
            splt_main.Name = "splt_main";
            // 
            // splt_main.Panel1
            // 
            splt_main.Panel1.Controls.Add(grp_tileset_data);
            splt_main.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 3, 6);
            // 
            // splt_main.Panel2
            // 
            splt_main.Panel2.Controls.Add(pnl_tileset_preview);
            splt_main.Panel2.Controls.Add(pnl_apply_button);
            splt_main.Panel2.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            splt_main.Size = new System.Drawing.Size(567, 221);
            splt_main.SplitterDistance = 286;
            splt_main.TabIndex = 20;
            // 
            // pnl_tileset_preview
            // 
            pnl_tileset_preview.Controls.Add(grp_tileset_preview);
            pnl_tileset_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_tileset_preview.Location = new System.Drawing.Point(3, 6);
            pnl_tileset_preview.Name = "pnl_tileset_preview";
            pnl_tileset_preview.Size = new System.Drawing.Size(268, 180);
            pnl_tileset_preview.TabIndex = 1;
            // 
            // pnl_apply_button
            // 
            pnl_apply_button.Controls.Add(btn_save_tileset);
            pnl_apply_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_apply_button.Location = new System.Drawing.Point(3, 186);
            pnl_apply_button.Name = "pnl_apply_button";
            pnl_apply_button.Size = new System.Drawing.Size(268, 29);
            pnl_apply_button.TabIndex = 0;
            // 
            // lbl_spring
            // 
            lbl_spring.Name = "lbl_spring";
            lbl_spring.Size = new System.Drawing.Size(397, 17);
            lbl_spring.Spring = true;
            // 
            // btn_import
            // 
            btn_import.Image = Properties.Resources.Import;
            btn_import.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_import.Name = "btn_import";
            btn_import.ShowDropDownArrow = false;
            btn_import.Size = new System.Drawing.Size(63, 20);
            btn_import.Text = "Import";
            btn_import.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_import.Click += btn_import_Click;
            // 
            // btn_export
            // 
            btn_export.Image = Properties.Resources.Export;
            btn_export.ImageTransparentColor = System.Drawing.Color.Magenta;
            btn_export.Name = "btn_export";
            btn_export.ShowDropDownArrow = false;
            btn_export.Size = new System.Drawing.Size(61, 20);
            btn_export.Text = "Export";
            btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_export.Click += btn_export_Click;
            // 
            // TilesetDefinitions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(567, 243);
            Controls.Add(splt_main);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(583, 282);
            Name = "TilesetDefinitions";
            Text = "Tileset Editor";
            grp_tileset_data.ResumeLayout(false);
            grp_tileset_data.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            grp_tileset_preview.ResumeLayout(false);
            splt_main.Panel1.ResumeLayout(false);
            splt_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splt_main).EndInit();
            splt_main.ResumeLayout(false);
            pnl_tileset_preview.ResumeLayout(false);
            pnl_apply_button.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tileset_data;
        private System.Windows.Forms.Label lbl_tileset_gfx_offset;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ComboBox cbb_metatile_table;
        private System.Windows.Forms.Label lbl_metatile_table;
        private System.Windows.Forms.ComboBox cbb_tileset_id;
        private System.Windows.Forms.Label lbl_tileset_id;
        private System.Windows.Forms.ComboBox cbb_solidity_table;
        private System.Windows.Forms.Label lbl_soliditiy_table;
        private System.Windows.Forms.ComboBox cbb_collision_table;
        private System.Windows.Forms.Label lbl_collision_table;
        private System.Windows.Forms.TextBox txb_tileset_name;
        private System.Windows.Forms.Label lbl_tileset_name;
        private System.Windows.Forms.GroupBox grp_tileset_preview;
        private System.Windows.Forms.Button btn_save_tileset;
        private System.Windows.Forms.Button btn_remove_tileset;
        private System.Windows.Forms.Button btn_add_tileset;
        private System.Windows.Forms.TextBox txb_gfx_offset;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.SplitContainer splt_main;
        private System.Windows.Forms.Panel pnl_tileset_preview;
        private System.Windows.Forms.Panel pnl_apply_button;
        private System.Windows.Forms.Button btn_edit_solidity;
        private System.Windows.Forms.Button btn_edit_collision;
        private Controls.Room.ToolBar Toolbar;
        private System.Windows.Forms.Panel pnl_preview;
        private System.Windows.Forms.ToolStripStatusLabel lbl_spring;
        private System.Windows.Forms.ToolStripDropDownButton btn_import;
        private System.Windows.Forms.ToolStripDropDownButton btn_export;
    }
}