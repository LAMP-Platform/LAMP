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
            txb_gfx_offset = new System.Windows.Forms.TextBox();
            btn_remove_tileset = new System.Windows.Forms.Button();
            btn_add_tileset = new System.Windows.Forms.Button();
            btn_save_tileset = new System.Windows.Forms.Button();
            cbb_solidity_table = new System.Windows.Forms.ComboBox();
            lbl_soliditiy_table = new System.Windows.Forms.Label();
            cbb_collision_table = new System.Windows.Forms.ComboBox();
            lbl_collision_table = new System.Windows.Forms.Label();
            txb_tileset_name = new System.Windows.Forms.TextBox();
            lbl_tileset_name = new System.Windows.Forms.Label();
            cbb_metatile_table = new System.Windows.Forms.ComboBox();
            lbl_metatile_table = new System.Windows.Forms.Label();
            cbb_tileset_id = new System.Windows.Forms.ComboBox();
            lbl_tileset_id = new System.Windows.Forms.Label();
            lbl_tileset_gfx_offset = new System.Windows.Forms.Label();
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_tileset_preview = new System.Windows.Forms.GroupBox();
            btn_edit = new System.Windows.Forms.Button();
            grp_tileset_data.SuspendLayout();
            SuspendLayout();
            // 
            // grp_tileset_data
            // 
            grp_tileset_data.Controls.Add(btn_edit);
            grp_tileset_data.Controls.Add(txb_gfx_offset);
            grp_tileset_data.Controls.Add(btn_remove_tileset);
            grp_tileset_data.Controls.Add(btn_add_tileset);
            grp_tileset_data.Controls.Add(btn_save_tileset);
            grp_tileset_data.Controls.Add(cbb_solidity_table);
            grp_tileset_data.Controls.Add(lbl_soliditiy_table);
            grp_tileset_data.Controls.Add(cbb_collision_table);
            grp_tileset_data.Controls.Add(lbl_collision_table);
            grp_tileset_data.Controls.Add(txb_tileset_name);
            grp_tileset_data.Controls.Add(lbl_tileset_name);
            grp_tileset_data.Controls.Add(cbb_metatile_table);
            grp_tileset_data.Controls.Add(lbl_metatile_table);
            grp_tileset_data.Controls.Add(cbb_tileset_id);
            grp_tileset_data.Controls.Add(lbl_tileset_id);
            grp_tileset_data.Controls.Add(lbl_tileset_gfx_offset);
            grp_tileset_data.Location = new System.Drawing.Point(12, 12);
            grp_tileset_data.Name = "grp_tileset_data";
            grp_tileset_data.Size = new System.Drawing.Size(336, 164);
            grp_tileset_data.TabIndex = 0;
            grp_tileset_data.TabStop = false;
            grp_tileset_data.Text = "Tileset Data";
            // 
            // txb_gfx_offset
            // 
            txb_gfx_offset.Location = new System.Drawing.Point(103, 44);
            txb_gfx_offset.Name = "txb_gfx_offset";
            txb_gfx_offset.Size = new System.Drawing.Size(55, 23);
            txb_gfx_offset.TabIndex = 0;
            // 
            // btn_remove_tileset
            // 
            btn_remove_tileset.Location = new System.Drawing.Point(255, 135);
            btn_remove_tileset.Name = "btn_remove_tileset";
            btn_remove_tileset.Size = new System.Drawing.Size(75, 23);
            btn_remove_tileset.TabIndex = 21;
            btn_remove_tileset.Text = "Remove";
            btn_remove_tileset.UseVisualStyleBackColor = true;
            btn_remove_tileset.Click += btn_remove_tileset_Click;
            // 
            // btn_add_tileset
            // 
            btn_add_tileset.Location = new System.Drawing.Point(174, 135);
            btn_add_tileset.Name = "btn_add_tileset";
            btn_add_tileset.Size = new System.Drawing.Size(75, 23);
            btn_add_tileset.TabIndex = 20;
            btn_add_tileset.Text = "Add";
            btn_add_tileset.UseVisualStyleBackColor = true;
            btn_add_tileset.Click += btn_add_tileset_Click;
            // 
            // btn_save_tileset
            // 
            btn_save_tileset.Enabled = false;
            btn_save_tileset.Location = new System.Drawing.Point(6, 135);
            btn_save_tileset.Name = "btn_save_tileset";
            btn_save_tileset.Size = new System.Drawing.Size(75, 23);
            btn_save_tileset.TabIndex = 19;
            btn_save_tileset.Text = "Apply";
            btn_save_tileset.UseVisualStyleBackColor = true;
            btn_save_tileset.Click += btn_save_tileset_Click;
            // 
            // cbb_solidity_table
            // 
            cbb_solidity_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_solidity_table.FormattingEnabled = true;
            cbb_solidity_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_solidity_table.Location = new System.Drawing.Point(271, 74);
            cbb_solidity_table.Name = "cbb_solidity_table";
            cbb_solidity_table.Size = new System.Drawing.Size(55, 23);
            cbb_solidity_table.TabIndex = 18;
            // 
            // lbl_soliditiy_table
            // 
            lbl_soliditiy_table.AutoSize = true;
            lbl_soliditiy_table.Location = new System.Drawing.Point(164, 77);
            lbl_soliditiy_table.Name = "lbl_soliditiy_table";
            lbl_soliditiy_table.Size = new System.Drawing.Size(89, 15);
            lbl_soliditiy_table.TabIndex = 17;
            lbl_soliditiy_table.Text = "Solidity Indices:";
            // 
            // cbb_collision_table
            // 
            cbb_collision_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_collision_table.FormattingEnabled = true;
            cbb_collision_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_collision_table.Location = new System.Drawing.Point(271, 45);
            cbb_collision_table.Name = "cbb_collision_table";
            cbb_collision_table.Size = new System.Drawing.Size(55, 23);
            cbb_collision_table.TabIndex = 16;
            // 
            // lbl_collision_table
            // 
            lbl_collision_table.AutoSize = true;
            lbl_collision_table.Location = new System.Drawing.Point(164, 48);
            lbl_collision_table.Name = "lbl_collision_table";
            lbl_collision_table.Size = new System.Drawing.Size(86, 15);
            lbl_collision_table.TabIndex = 15;
            lbl_collision_table.Text = "Collision Table:";
            // 
            // txb_tileset_name
            // 
            txb_tileset_name.Location = new System.Drawing.Point(212, 16);
            txb_tileset_name.Name = "txb_tileset_name";
            txb_tileset_name.Size = new System.Drawing.Size(114, 23);
            txb_tileset_name.TabIndex = 14;
            // 
            // lbl_tileset_name
            // 
            lbl_tileset_name.AutoSize = true;
            lbl_tileset_name.Location = new System.Drawing.Point(164, 19);
            lbl_tileset_name.Name = "lbl_tileset_name";
            lbl_tileset_name.Size = new System.Drawing.Size(42, 15);
            lbl_tileset_name.TabIndex = 13;
            lbl_tileset_name.Text = "Name:";
            // 
            // cbb_metatile_table
            // 
            cbb_metatile_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_metatile_table.FormattingEnabled = true;
            cbb_metatile_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            cbb_metatile_table.Location = new System.Drawing.Point(103, 74);
            cbb_metatile_table.Name = "cbb_metatile_table";
            cbb_metatile_table.Size = new System.Drawing.Size(55, 23);
            cbb_metatile_table.TabIndex = 12;
            cbb_metatile_table.SelectedIndexChanged += cbb_metatile_table_SelectedIndexChanged;
            // 
            // lbl_metatile_table
            // 
            lbl_metatile_table.AutoSize = true;
            lbl_metatile_table.Location = new System.Drawing.Point(6, 77);
            lbl_metatile_table.Name = "lbl_metatile_table";
            lbl_metatile_table.Size = new System.Drawing.Size(83, 15);
            lbl_metatile_table.TabIndex = 11;
            lbl_metatile_table.Text = "Metatile Table:";
            // 
            // cbb_tileset_id
            // 
            cbb_tileset_id.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_tileset_id.FormattingEnabled = true;
            cbb_tileset_id.Location = new System.Drawing.Point(103, 16);
            cbb_tileset_id.Name = "cbb_tileset_id";
            cbb_tileset_id.Size = new System.Drawing.Size(55, 23);
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
            // lbl_tileset_gfx_offset
            // 
            lbl_tileset_gfx_offset.AutoSize = true;
            lbl_tileset_gfx_offset.Location = new System.Drawing.Point(6, 47);
            lbl_tileset_gfx_offset.Name = "lbl_tileset_gfx_offset";
            lbl_tileset_gfx_offset.Size = new System.Drawing.Size(91, 15);
            lbl_tileset_gfx_offset.TabIndex = 0;
            lbl_tileset_gfx_offset.Text = "Graphics Offset:";
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 185);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(649, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_preview
            // 
            grp_tileset_preview.Location = new System.Drawing.Point(354, 12);
            grp_tileset_preview.Name = "grp_tileset_preview";
            grp_tileset_preview.Size = new System.Drawing.Size(286, 164);
            grp_tileset_preview.TabIndex = 2;
            grp_tileset_preview.TabStop = false;
            grp_tileset_preview.Text = "Preview";
            // 
            // btn_edit
            // 
            btn_edit.Location = new System.Drawing.Point(6, 106);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(75, 23);
            btn_edit.TabIndex = 22;
            btn_edit.Text = "Edit";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // TilesetDefinitions
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(649, 207);
            Controls.Add(grp_tileset_preview);
            Controls.Add(statusStrip1);
            Controls.Add(grp_tileset_data);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(665, 246);
            Name = "TilesetDefinitions";
            Text = "Tileset Editor";
            grp_tileset_data.ResumeLayout(false);
            grp_tileset_data.PerformLayout();
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
    }
}