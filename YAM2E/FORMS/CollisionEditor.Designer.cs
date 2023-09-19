namespace LAMP.FORMS
{
    partial class CollisionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionEditor));
            pnl_main = new System.Windows.Forms.SplitContainer();
            grp_collision = new System.Windows.Forms.GroupBox();
            chb_save = new System.Windows.Forms.CheckBox();
            chb_bomb_block = new System.Windows.Forms.CheckBox();
            chb_shot_block = new System.Windows.Forms.CheckBox();
            chb_acid = new System.Windows.Forms.CheckBox();
            chb_spike = new System.Windows.Forms.CheckBox();
            chb_pass_through_ceiling = new System.Windows.Forms.CheckBox();
            chb_pass_through_bottom = new System.Windows.Forms.CheckBox();
            chb_water = new System.Windows.Forms.CheckBox();
            grp_data = new System.Windows.Forms.GroupBox();
            lbl_table = new System.Windows.Forms.Label();
            txb_offset = new System.Windows.Forms.TextBox();
            lbl_gfx = new System.Windows.Forms.Label();
            cbb_collision_table = new System.Windows.Forms.ComboBox();
            grp_preview = new System.Windows.Forms.GroupBox();
            pnl_preview = new System.Windows.Forms.Panel();
            Tileset = new Controls.TileViewer();
            toolbar = new Controls.Room.ToolBar();
            pnl_apply_button = new System.Windows.Forms.Panel();
            btn_apply = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pnl_main).BeginInit();
            pnl_main.Panel1.SuspendLayout();
            pnl_main.Panel2.SuspendLayout();
            pnl_main.SuspendLayout();
            grp_collision.SuspendLayout();
            grp_data.SuspendLayout();
            grp_preview.SuspendLayout();
            pnl_preview.SuspendLayout();
            pnl_apply_button.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            // 
            // pnl_main.Panel1
            // 
            pnl_main.Panel1.Controls.Add(grp_collision);
            pnl_main.Panel1.Controls.Add(grp_data);
            pnl_main.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 3, 6);
            // 
            // pnl_main.Panel2
            // 
            pnl_main.Panel2.Controls.Add(grp_preview);
            pnl_main.Panel2.Controls.Add(pnl_apply_button);
            pnl_main.Panel2.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            pnl_main.Size = new System.Drawing.Size(473, 321);
            pnl_main.SplitterDistance = 190;
            pnl_main.TabIndex = 0;
            // 
            // grp_collision
            // 
            grp_collision.Controls.Add(chb_save);
            grp_collision.Controls.Add(chb_bomb_block);
            grp_collision.Controls.Add(chb_shot_block);
            grp_collision.Controls.Add(chb_acid);
            grp_collision.Controls.Add(chb_spike);
            grp_collision.Controls.Add(chb_pass_through_ceiling);
            grp_collision.Controls.Add(chb_pass_through_bottom);
            grp_collision.Controls.Add(chb_water);
            grp_collision.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_collision.Location = new System.Drawing.Point(6, 90);
            grp_collision.Name = "grp_collision";
            grp_collision.Size = new System.Drawing.Size(181, 225);
            grp_collision.TabIndex = 29;
            grp_collision.TabStop = false;
            grp_collision.Text = "Collision";
            // 
            // chb_save
            // 
            chb_save.AutoSize = true;
            chb_save.Location = new System.Drawing.Point(6, 197);
            chb_save.Name = "chb_save";
            chb_save.Size = new System.Drawing.Size(79, 19);
            chb_save.TabIndex = 7;
            chb_save.Text = "Save Pillar";
            chb_save.UseVisualStyleBackColor = true;
            chb_save.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_bomb_block
            // 
            chb_bomb_block.AutoSize = true;
            chb_bomb_block.Location = new System.Drawing.Point(6, 172);
            chb_bomb_block.Name = "chb_bomb_block";
            chb_bomb_block.Size = new System.Drawing.Size(90, 19);
            chb_bomb_block.TabIndex = 6;
            chb_bomb_block.Text = "Bomb Block";
            chb_bomb_block.UseVisualStyleBackColor = true;
            chb_bomb_block.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_shot_block
            // 
            chb_shot_block.AutoSize = true;
            chb_shot_block.Location = new System.Drawing.Point(6, 147);
            chb_shot_block.Name = "chb_shot_block";
            chb_shot_block.Size = new System.Drawing.Size(82, 19);
            chb_shot_block.TabIndex = 5;
            chb_shot_block.Text = "Shot Block";
            chb_shot_block.UseVisualStyleBackColor = true;
            chb_shot_block.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_acid
            // 
            chb_acid.AutoSize = true;
            chb_acid.Location = new System.Drawing.Point(6, 122);
            chb_acid.Name = "chb_acid";
            chb_acid.Size = new System.Drawing.Size(50, 19);
            chb_acid.TabIndex = 4;
            chb_acid.Text = "Acid";
            chb_acid.UseVisualStyleBackColor = true;
            chb_acid.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_spike
            // 
            chb_spike.AutoSize = true;
            chb_spike.Location = new System.Drawing.Point(6, 97);
            chb_spike.Name = "chb_spike";
            chb_spike.Size = new System.Drawing.Size(54, 19);
            chb_spike.TabIndex = 3;
            chb_spike.Text = "Spike";
            chb_spike.UseVisualStyleBackColor = true;
            chb_spike.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_pass_through_ceiling
            // 
            chb_pass_through_ceiling.AutoSize = true;
            chb_pass_through_ceiling.Location = new System.Drawing.Point(6, 72);
            chb_pass_through_ceiling.Name = "chb_pass_through_ceiling";
            chb_pass_through_ceiling.Size = new System.Drawing.Size(135, 19);
            chb_pass_through_ceiling.TabIndex = 2;
            chb_pass_through_ceiling.Text = "Pass through Ceiling";
            chb_pass_through_ceiling.UseVisualStyleBackColor = true;
            chb_pass_through_ceiling.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_pass_through_bottom
            // 
            chb_pass_through_bottom.AutoSize = true;
            chb_pass_through_bottom.Location = new System.Drawing.Point(6, 47);
            chb_pass_through_bottom.Name = "chb_pass_through_bottom";
            chb_pass_through_bottom.Size = new System.Drawing.Size(125, 19);
            chb_pass_through_bottom.TabIndex = 1;
            chb_pass_through_bottom.Text = "Pass through Floor";
            chb_pass_through_bottom.UseVisualStyleBackColor = true;
            chb_pass_through_bottom.CheckedChanged += chb_water_CheckedChanged;
            // 
            // chb_water
            // 
            chb_water.AutoSize = true;
            chb_water.Location = new System.Drawing.Point(6, 22);
            chb_water.Name = "chb_water";
            chb_water.Size = new System.Drawing.Size(57, 19);
            chb_water.TabIndex = 0;
            chb_water.Text = "Water";
            chb_water.UseVisualStyleBackColor = true;
            chb_water.CheckedChanged += chb_water_CheckedChanged;
            // 
            // grp_data
            // 
            grp_data.Controls.Add(lbl_table);
            grp_data.Controls.Add(txb_offset);
            grp_data.Controls.Add(lbl_gfx);
            grp_data.Controls.Add(cbb_collision_table);
            grp_data.Dock = System.Windows.Forms.DockStyle.Top;
            grp_data.Location = new System.Drawing.Point(6, 6);
            grp_data.Name = "grp_data";
            grp_data.Size = new System.Drawing.Size(181, 84);
            grp_data.TabIndex = 28;
            grp_data.TabStop = false;
            grp_data.Text = "Data Selector";
            // 
            // lbl_table
            // 
            lbl_table.AutoSize = true;
            lbl_table.Location = new System.Drawing.Point(6, 25);
            lbl_table.Name = "lbl_table";
            lbl_table.Size = new System.Drawing.Size(86, 15);
            lbl_table.TabIndex = 0;
            lbl_table.Text = "Collision Table:";
            // 
            // txb_offset
            // 
            txb_offset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_offset.Location = new System.Drawing.Point(106, 51);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(69, 23);
            txb_offset.TabIndex = 27;
            txb_offset.TextChanged += txb_offset_TextChanged;
            // 
            // lbl_gfx
            // 
            lbl_gfx.AutoSize = true;
            lbl_gfx.Location = new System.Drawing.Point(6, 54);
            lbl_gfx.Name = "lbl_gfx";
            lbl_gfx.Size = new System.Drawing.Size(94, 15);
            lbl_gfx.TabIndex = 1;
            lbl_gfx.Text = "Graphic Overlay:";
            // 
            // cbb_collision_table
            // 
            cbb_collision_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_collision_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_collision_table.FormattingEnabled = true;
            cbb_collision_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_collision_table.Location = new System.Drawing.Point(106, 22);
            cbb_collision_table.Name = "cbb_collision_table";
            cbb_collision_table.Size = new System.Drawing.Size(69, 23);
            cbb_collision_table.TabIndex = 20;
            cbb_collision_table.SelectedIndexChanged += cbb_collision_table_SelectedIndexChanged;
            // 
            // grp_preview
            // 
            grp_preview.Controls.Add(pnl_preview);
            grp_preview.Controls.Add(toolbar);
            grp_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_preview.Location = new System.Drawing.Point(3, 6);
            grp_preview.Name = "grp_preview";
            grp_preview.Size = new System.Drawing.Size(270, 280);
            grp_preview.TabIndex = 0;
            grp_preview.TabStop = false;
            grp_preview.Text = "Preview";
            // 
            // pnl_preview
            // 
            pnl_preview.Controls.Add(Tileset);
            pnl_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_preview.Location = new System.Drawing.Point(3, 43);
            pnl_preview.Name = "pnl_preview";
            pnl_preview.Size = new System.Drawing.Size(264, 234);
            pnl_preview.TabIndex = 1;
            // 
            // Tileset
            // 
            Tileset.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            Tileset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            Tileset.Location = new System.Drawing.Point(3, 3);
            Tileset.Name = "Tileset";
            Tileset.PixelTileSize = 8;
            Tileset.RedRect = new System.Drawing.Rectangle(-1, -1, 0, 0);
            Tileset.SelectedTool = LampTool.Select;
            Tileset.SelRect = new System.Drawing.Rectangle(-1, -1, 0, 0);
            Tileset.Size = new System.Drawing.Size(256, 59);
            Tileset.TabIndex = 0;
            Tileset.Text = "tileViewer1";
            Tileset.Zoom = 2;
            Tileset.MouseDown += Tileset_MouseDown;
            Tileset.MouseMove += Tileset_MouseMove;
            // 
            // toolbar
            // 
            toolbar.Dock = System.Windows.Forms.DockStyle.Top;
            toolbar.Location = new System.Drawing.Point(3, 19);
            toolbar.MaxZoom = 10;
            toolbar.Name = "toolbar";
            toolbar.onToolCommandTriggered = null;
            toolbar.onToolSwitched = null;
            toolbar.SelectedTool = LampTool.Pen;
            toolbar.Size = new System.Drawing.Size(264, 24);
            toolbar.TabIndex = 0;
            toolbar.ZoomLevel = 2;
            toolbar.ToolCommandTriggered += toolbar_ToolCommandTriggered;
            // 
            // pnl_apply_button
            // 
            pnl_apply_button.Controls.Add(btn_apply);
            pnl_apply_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_apply_button.Location = new System.Drawing.Point(3, 286);
            pnl_apply_button.Name = "pnl_apply_button";
            pnl_apply_button.Size = new System.Drawing.Size(270, 29);
            pnl_apply_button.TabIndex = 2;
            // 
            // btn_apply
            // 
            btn_apply.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_apply.Image = Properties.Resources.Save;
            btn_apply.Location = new System.Drawing.Point(206, 3);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new System.Drawing.Size(64, 23);
            btn_apply.TabIndex = 20;
            btn_apply.Text = "Apply";
            btn_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // CollisionEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(473, 321);
            Controls.Add(pnl_main);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "CollisionEditor";
            Text = "Collision Editor";
            pnl_main.Panel1.ResumeLayout(false);
            pnl_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_main).EndInit();
            pnl_main.ResumeLayout(false);
            grp_collision.ResumeLayout(false);
            grp_collision.PerformLayout();
            grp_data.ResumeLayout(false);
            grp_data.PerformLayout();
            grp_preview.ResumeLayout(false);
            pnl_preview.ResumeLayout(false);
            pnl_apply_button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer pnl_main;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Label lbl_gfx;
        private System.Windows.Forms.ComboBox cbb_collision_table;
        private System.Windows.Forms.TextBox txb_offset;
        private System.Windows.Forms.GroupBox grp_preview;
        private System.Windows.Forms.Panel pnl_apply_button;
        private System.Windows.Forms.Button btn_apply;
        private Controls.Room.ToolBar toolbar;
        private System.Windows.Forms.Panel pnl_preview;
        private Controls.TileViewer Tileset;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.GroupBox grp_collision;
        private System.Windows.Forms.CheckBox chb_water;
        private System.Windows.Forms.CheckBox chb_save;
        private System.Windows.Forms.CheckBox chb_bomb_block;
        private System.Windows.Forms.CheckBox chb_shot_block;
        private System.Windows.Forms.CheckBox chb_acid;
        private System.Windows.Forms.CheckBox chb_spike;
        private System.Windows.Forms.CheckBox chb_pass_through_ceiling;
        private System.Windows.Forms.CheckBox chb_pass_through_bottom;
    }
}