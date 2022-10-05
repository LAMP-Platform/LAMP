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
            this.grp_tileset_data = new System.Windows.Forms.GroupBox();
            this.txb_gfx_offset = new System.Windows.Forms.TextBox();
            this.btn_remove_tileset = new System.Windows.Forms.Button();
            this.btn_add_tileset = new System.Windows.Forms.Button();
            this.btn_save_tileset = new System.Windows.Forms.Button();
            this.cbb_solidity_table = new System.Windows.Forms.ComboBox();
            this.lbl_soliditiy_table = new System.Windows.Forms.Label();
            this.cbb_collision_table = new System.Windows.Forms.ComboBox();
            this.lbl_collision_table = new System.Windows.Forms.Label();
            this.txb_tileset_name = new System.Windows.Forms.TextBox();
            this.lbl_tileset_name = new System.Windows.Forms.Label();
            this.cbb_metatile_table = new System.Windows.Forms.ComboBox();
            this.lbl_metatile_table = new System.Windows.Forms.Label();
            this.cbb_tileset_id = new System.Windows.Forms.ComboBox();
            this.lbl_tileset_id = new System.Windows.Forms.Label();
            this.lbl_tileset_gfx_offset = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_tileset_preview = new System.Windows.Forms.GroupBox();
            this.grp_tileset_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tileset_data
            // 
            this.grp_tileset_data.Controls.Add(this.txb_gfx_offset);
            this.grp_tileset_data.Controls.Add(this.btn_remove_tileset);
            this.grp_tileset_data.Controls.Add(this.btn_add_tileset);
            this.grp_tileset_data.Controls.Add(this.btn_save_tileset);
            this.grp_tileset_data.Controls.Add(this.cbb_solidity_table);
            this.grp_tileset_data.Controls.Add(this.lbl_soliditiy_table);
            this.grp_tileset_data.Controls.Add(this.cbb_collision_table);
            this.grp_tileset_data.Controls.Add(this.lbl_collision_table);
            this.grp_tileset_data.Controls.Add(this.txb_tileset_name);
            this.grp_tileset_data.Controls.Add(this.lbl_tileset_name);
            this.grp_tileset_data.Controls.Add(this.cbb_metatile_table);
            this.grp_tileset_data.Controls.Add(this.lbl_metatile_table);
            this.grp_tileset_data.Controls.Add(this.cbb_tileset_id);
            this.grp_tileset_data.Controls.Add(this.lbl_tileset_id);
            this.grp_tileset_data.Controls.Add(this.lbl_tileset_gfx_offset);
            this.grp_tileset_data.Location = new System.Drawing.Point(12, 12);
            this.grp_tileset_data.Name = "grp_tileset_data";
            this.grp_tileset_data.Size = new System.Drawing.Size(336, 164);
            this.grp_tileset_data.TabIndex = 0;
            this.grp_tileset_data.TabStop = false;
            this.grp_tileset_data.Text = "Tileset Data";
            // 
            // txb_gfx_offset
            // 
            this.txb_gfx_offset.Location = new System.Drawing.Point(103, 44);
            this.txb_gfx_offset.Name = "txb_gfx_offset";
            this.txb_gfx_offset.Size = new System.Drawing.Size(55, 23);
            this.txb_gfx_offset.TabIndex = 0;
            // 
            // btn_remove_tileset
            // 
            this.btn_remove_tileset.Location = new System.Drawing.Point(255, 135);
            this.btn_remove_tileset.Name = "btn_remove_tileset";
            this.btn_remove_tileset.Size = new System.Drawing.Size(75, 23);
            this.btn_remove_tileset.TabIndex = 21;
            this.btn_remove_tileset.Text = "Remove";
            this.btn_remove_tileset.UseVisualStyleBackColor = true;
            this.btn_remove_tileset.Click += new System.EventHandler(this.btn_remove_tileset_Click);
            // 
            // btn_add_tileset
            // 
            this.btn_add_tileset.Location = new System.Drawing.Point(174, 135);
            this.btn_add_tileset.Name = "btn_add_tileset";
            this.btn_add_tileset.Size = new System.Drawing.Size(75, 23);
            this.btn_add_tileset.TabIndex = 20;
            this.btn_add_tileset.Text = "Add";
            this.btn_add_tileset.UseVisualStyleBackColor = true;
            this.btn_add_tileset.Click += new System.EventHandler(this.btn_add_tileset_Click);
            // 
            // btn_save_tileset
            // 
            this.btn_save_tileset.Enabled = false;
            this.btn_save_tileset.Location = new System.Drawing.Point(6, 135);
            this.btn_save_tileset.Name = "btn_save_tileset";
            this.btn_save_tileset.Size = new System.Drawing.Size(75, 23);
            this.btn_save_tileset.TabIndex = 19;
            this.btn_save_tileset.Text = "Apply";
            this.btn_save_tileset.UseVisualStyleBackColor = true;
            this.btn_save_tileset.Click += new System.EventHandler(this.btn_save_tileset_Click);
            // 
            // cbb_solidity_table
            // 
            this.cbb_solidity_table.FormattingEnabled = true;
            this.cbb_solidity_table.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbb_solidity_table.Location = new System.Drawing.Point(271, 74);
            this.cbb_solidity_table.Name = "cbb_solidity_table";
            this.cbb_solidity_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_solidity_table.TabIndex = 18;
            // 
            // lbl_soliditiy_table
            // 
            this.lbl_soliditiy_table.AutoSize = true;
            this.lbl_soliditiy_table.Location = new System.Drawing.Point(164, 77);
            this.lbl_soliditiy_table.Name = "lbl_soliditiy_table";
            this.lbl_soliditiy_table.Size = new System.Drawing.Size(89, 15);
            this.lbl_soliditiy_table.TabIndex = 17;
            this.lbl_soliditiy_table.Text = "Solidity Indices:";
            // 
            // cbb_collision_table
            // 
            this.cbb_collision_table.FormattingEnabled = true;
            this.cbb_collision_table.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cbb_collision_table.Location = new System.Drawing.Point(271, 45);
            this.cbb_collision_table.Name = "cbb_collision_table";
            this.cbb_collision_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_collision_table.TabIndex = 16;
            // 
            // lbl_collision_table
            // 
            this.lbl_collision_table.AutoSize = true;
            this.lbl_collision_table.Location = new System.Drawing.Point(164, 48);
            this.lbl_collision_table.Name = "lbl_collision_table";
            this.lbl_collision_table.Size = new System.Drawing.Size(86, 15);
            this.lbl_collision_table.TabIndex = 15;
            this.lbl_collision_table.Text = "Collision Table:";
            // 
            // txb_tileset_name
            // 
            this.txb_tileset_name.Location = new System.Drawing.Point(212, 16);
            this.txb_tileset_name.Name = "txb_tileset_name";
            this.txb_tileset_name.Size = new System.Drawing.Size(114, 23);
            this.txb_tileset_name.TabIndex = 14;
            // 
            // lbl_tileset_name
            // 
            this.lbl_tileset_name.AutoSize = true;
            this.lbl_tileset_name.Location = new System.Drawing.Point(164, 19);
            this.lbl_tileset_name.Name = "lbl_tileset_name";
            this.lbl_tileset_name.Size = new System.Drawing.Size(42, 15);
            this.lbl_tileset_name.TabIndex = 13;
            this.lbl_tileset_name.Text = "Name:";
            // 
            // cbb_metatile_table
            // 
            this.cbb_metatile_table.FormattingEnabled = true;
            this.cbb_metatile_table.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbb_metatile_table.Location = new System.Drawing.Point(103, 74);
            this.cbb_metatile_table.Name = "cbb_metatile_table";
            this.cbb_metatile_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_metatile_table.TabIndex = 12;
            this.cbb_metatile_table.SelectedIndexChanged += new System.EventHandler(this.cbb_metatile_table_SelectedIndexChanged);
            // 
            // lbl_metatile_table
            // 
            this.lbl_metatile_table.AutoSize = true;
            this.lbl_metatile_table.Location = new System.Drawing.Point(6, 77);
            this.lbl_metatile_table.Name = "lbl_metatile_table";
            this.lbl_metatile_table.Size = new System.Drawing.Size(83, 15);
            this.lbl_metatile_table.TabIndex = 11;
            this.lbl_metatile_table.Text = "Metatile Table:";
            // 
            // cbb_tileset_id
            // 
            this.cbb_tileset_id.FormattingEnabled = true;
            this.cbb_tileset_id.Location = new System.Drawing.Point(103, 16);
            this.cbb_tileset_id.Name = "cbb_tileset_id";
            this.cbb_tileset_id.Size = new System.Drawing.Size(55, 23);
            this.cbb_tileset_id.TabIndex = 10;
            this.cbb_tileset_id.SelectedIndexChanged += new System.EventHandler(this.cbb_tileset_id_SelectedIndexChanged);
            // 
            // lbl_tileset_id
            // 
            this.lbl_tileset_id.AutoSize = true;
            this.lbl_tileset_id.Location = new System.Drawing.Point(6, 19);
            this.lbl_tileset_id.Name = "lbl_tileset_id";
            this.lbl_tileset_id.Size = new System.Drawing.Size(43, 15);
            this.lbl_tileset_id.TabIndex = 9;
            this.lbl_tileset_id.Text = "Tileset:";
            // 
            // lbl_tileset_gfx_offset
            // 
            this.lbl_tileset_gfx_offset.AutoSize = true;
            this.lbl_tileset_gfx_offset.Location = new System.Drawing.Point(6, 47);
            this.lbl_tileset_gfx_offset.Name = "lbl_tileset_gfx_offset";
            this.lbl_tileset_gfx_offset.Size = new System.Drawing.Size(91, 15);
            this.lbl_tileset_gfx_offset.TabIndex = 0;
            this.lbl_tileset_gfx_offset.Text = "Graphics Offset:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_preview
            // 
            this.grp_tileset_preview.Location = new System.Drawing.Point(354, 12);
            this.grp_tileset_preview.Name = "grp_tileset_preview";
            this.grp_tileset_preview.Size = new System.Drawing.Size(286, 164);
            this.grp_tileset_preview.TabIndex = 2;
            this.grp_tileset_preview.TabStop = false;
            this.grp_tileset_preview.Text = "Preview";
            // 
            // TilesetDefinitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 207);
            this.Controls.Add(this.grp_tileset_preview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_tileset_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(665, 246);
            this.Name = "TilesetDefinitions";
            this.Text = "Tileset Editor";
            this.grp_tileset_data.ResumeLayout(false);
            this.grp_tileset_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}