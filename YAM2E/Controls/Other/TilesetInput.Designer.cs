namespace LAMP.Controls.Other
{
    partial class TilesetInput
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grp_tileset_offset = new System.Windows.Forms.GroupBox();
            this.grp_tileset_tilesets = new System.Windows.Forms.GroupBox();
            this.cbb_tileset_id = new System.Windows.Forms.ComboBox();
            this.lbl_tileset_id = new System.Windows.Forms.Label();
            this.txb_graphics_offset = new System.Windows.Forms.TextBox();
            this.btn_apply_graphics = new System.Windows.Forms.Button();
            this.cbb_metatile_table = new System.Windows.Forms.ComboBox();
            this.lbl_main_graphics_pointer = new System.Windows.Forms.Label();
            this.lbl_main_metatile = new System.Windows.Forms.Label();
            this.grp_tileset_offset.SuspendLayout();
            this.grp_tileset_tilesets.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_tileset_offset
            // 
            this.grp_tileset_offset.Controls.Add(this.txb_graphics_offset);
            this.grp_tileset_offset.Controls.Add(this.btn_apply_graphics);
            this.grp_tileset_offset.Controls.Add(this.cbb_metatile_table);
            this.grp_tileset_offset.Controls.Add(this.lbl_main_graphics_pointer);
            this.grp_tileset_offset.Controls.Add(this.lbl_main_metatile);
            this.grp_tileset_offset.Location = new System.Drawing.Point(3, 3);
            this.grp_tileset_offset.Margin = new System.Windows.Forms.Padding(0);
            this.grp_tileset_offset.Name = "grp_tileset_offset";
            this.grp_tileset_offset.Size = new System.Drawing.Size(166, 109);
            this.grp_tileset_offset.TabIndex = 4;
            this.grp_tileset_offset.TabStop = false;
            this.grp_tileset_offset.Text = "Tileset Data";
            // 
            // grp_tileset_tilesets
            // 
            this.grp_tileset_tilesets.Controls.Add(this.cbb_tileset_id);
            this.grp_tileset_tilesets.Controls.Add(this.lbl_tileset_id);
            this.grp_tileset_tilesets.Location = new System.Drawing.Point(0, 0);
            this.grp_tileset_tilesets.Margin = new System.Windows.Forms.Padding(0);
            this.grp_tileset_tilesets.Name = "grp_tileset_tilesets";
            this.grp_tileset_tilesets.Size = new System.Drawing.Size(166, 109);
            this.grp_tileset_tilesets.TabIndex = 9;
            this.grp_tileset_tilesets.TabStop = false;
            this.grp_tileset_tilesets.Text = "Tileset Data";
            this.grp_tileset_tilesets.Visible = false;
            // 
            // cbb_tileset_id
            // 
            this.cbb_tileset_id.FormattingEnabled = true;
            this.cbb_tileset_id.Location = new System.Drawing.Point(55, 22);
            this.cbb_tileset_id.Name = "cbb_tileset_id";
            this.cbb_tileset_id.Size = new System.Drawing.Size(103, 23);
            this.cbb_tileset_id.TabIndex = 1;
            this.cbb_tileset_id.SelectedIndexChanged += new System.EventHandler(this.cbb_tileset_id_SelectedIndexChanged);
            // 
            // lbl_tileset_id
            // 
            this.lbl_tileset_id.AutoSize = true;
            this.lbl_tileset_id.Location = new System.Drawing.Point(6, 25);
            this.lbl_tileset_id.Name = "lbl_tileset_id";
            this.lbl_tileset_id.Size = new System.Drawing.Size(43, 15);
            this.lbl_tileset_id.TabIndex = 0;
            this.lbl_tileset_id.Text = "Tileset:";
            // 
            // txb_graphics_offset
            // 
            this.txb_graphics_offset.Location = new System.Drawing.Point(103, 16);
            this.txb_graphics_offset.Name = "txb_graphics_offset";
            this.txb_graphics_offset.Size = new System.Drawing.Size(55, 23);
            this.txb_graphics_offset.TabIndex = 11;
            // 
            // btn_apply_graphics
            // 
            this.btn_apply_graphics.Location = new System.Drawing.Point(103, 75);
            this.btn_apply_graphics.Name = "btn_apply_graphics";
            this.btn_apply_graphics.Size = new System.Drawing.Size(55, 23);
            this.btn_apply_graphics.TabIndex = 10;
            this.btn_apply_graphics.Text = "Apply";
            this.btn_apply_graphics.UseVisualStyleBackColor = true;
            this.btn_apply_graphics.Click += new System.EventHandler(this.btn_apply_graphics_Click);
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
            this.cbb_metatile_table.Location = new System.Drawing.Point(103, 46);
            this.cbb_metatile_table.Name = "cbb_metatile_table";
            this.cbb_metatile_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_metatile_table.TabIndex = 9;
            // 
            // lbl_main_graphics_pointer
            // 
            this.lbl_main_graphics_pointer.AutoSize = true;
            this.lbl_main_graphics_pointer.Location = new System.Drawing.Point(6, 19);
            this.lbl_main_graphics_pointer.Name = "lbl_main_graphics_pointer";
            this.lbl_main_graphics_pointer.Size = new System.Drawing.Size(91, 15);
            this.lbl_main_graphics_pointer.TabIndex = 0;
            this.lbl_main_graphics_pointer.Text = "Graphics Offset:";
            // 
            // lbl_main_metatile
            // 
            this.lbl_main_metatile.AutoSize = true;
            this.lbl_main_metatile.Location = new System.Drawing.Point(6, 49);
            this.lbl_main_metatile.Name = "lbl_main_metatile";
            this.lbl_main_metatile.Size = new System.Drawing.Size(83, 15);
            this.lbl_main_metatile.TabIndex = 8;
            this.lbl_main_metatile.Text = "Metatile Table:";
            // 
            // TilesetInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.grp_tileset_offset);
            this.Controls.Add(this.grp_tileset_tilesets);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TilesetInput";
            this.Size = new System.Drawing.Size(169, 112);
            this.grp_tileset_offset.ResumeLayout(false);
            this.grp_tileset_offset.PerformLayout();
            this.grp_tileset_tilesets.ResumeLayout(false);
            this.grp_tileset_tilesets.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_tileset_offset;
        private System.Windows.Forms.TextBox txb_graphics_offset;
        private System.Windows.Forms.Button btn_apply_graphics;
        private System.Windows.Forms.ComboBox cbb_metatile_table;
        private System.Windows.Forms.Label lbl_main_graphics_pointer;
        private System.Windows.Forms.Label lbl_main_metatile;
        private System.Windows.Forms.GroupBox grp_tileset_tilesets;
        private System.Windows.Forms.ComboBox cbb_tileset_id;
        private System.Windows.Forms.Label lbl_tileset_id;
    }
}
