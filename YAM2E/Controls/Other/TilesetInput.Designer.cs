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
            this.txb_graphics_offset = new System.Windows.Forms.TextBox();
            this.cbb_metatile_table = new System.Windows.Forms.ComboBox();
            this.lbl_main_graphics_pointer = new System.Windows.Forms.Label();
            this.lbl_main_metatile = new System.Windows.Forms.Label();
            this.cbb_tileset_id = new System.Windows.Forms.ComboBox();
            this.lbl_tileset_id = new System.Windows.Forms.Label();
            this.pnl_offsets = new System.Windows.Forms.Panel();
            this.pnl_tilesets = new System.Windows.Forms.Panel();
            this.pnl_offsets.SuspendLayout();
            this.pnl_tilesets.SuspendLayout();
            this.SuspendLayout();
            // 
            // txb_graphics_offset
            // 
            this.txb_graphics_offset.Location = new System.Drawing.Point(101, 4);
            this.txb_graphics_offset.Name = "txb_graphics_offset";
            this.txb_graphics_offset.Size = new System.Drawing.Size(55, 23);
            this.txb_graphics_offset.TabIndex = 11;
            this.txb_graphics_offset.TextChanged += new System.EventHandler(this.txb_graphics_offset_TextChanged);
            this.txb_graphics_offset.Leave += new System.EventHandler(this.txb_graphics_offset_Leave);
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
            this.cbb_metatile_table.Location = new System.Drawing.Point(101, 34);
            this.cbb_metatile_table.Name = "cbb_metatile_table";
            this.cbb_metatile_table.Size = new System.Drawing.Size(55, 23);
            this.cbb_metatile_table.TabIndex = 9;
            this.cbb_metatile_table.SelectedIndexChanged += new System.EventHandler(this.cbb_metatile_table_SelectedIndexChanged);
            // 
            // lbl_main_graphics_pointer
            // 
            this.lbl_main_graphics_pointer.AutoSize = true;
            this.lbl_main_graphics_pointer.Location = new System.Drawing.Point(4, 7);
            this.lbl_main_graphics_pointer.Name = "lbl_main_graphics_pointer";
            this.lbl_main_graphics_pointer.Size = new System.Drawing.Size(91, 15);
            this.lbl_main_graphics_pointer.TabIndex = 0;
            this.lbl_main_graphics_pointer.Text = "Graphics Offset:";
            // 
            // lbl_main_metatile
            // 
            this.lbl_main_metatile.AutoSize = true;
            this.lbl_main_metatile.Location = new System.Drawing.Point(4, 37);
            this.lbl_main_metatile.Name = "lbl_main_metatile";
            this.lbl_main_metatile.Size = new System.Drawing.Size(83, 15);
            this.lbl_main_metatile.TabIndex = 8;
            this.lbl_main_metatile.Text = "Metatile Table:";
            // 
            // cbb_tileset_id
            // 
            this.cbb_tileset_id.FormattingEnabled = true;
            this.cbb_tileset_id.Location = new System.Drawing.Point(53, 4);
            this.cbb_tileset_id.Name = "cbb_tileset_id";
            this.cbb_tileset_id.Size = new System.Drawing.Size(103, 23);
            this.cbb_tileset_id.TabIndex = 1;
            this.cbb_tileset_id.SelectedIndexChanged += new System.EventHandler(this.cbb_tileset_id_SelectedIndexChanged);
            // 
            // lbl_tileset_id
            // 
            this.lbl_tileset_id.AutoSize = true;
            this.lbl_tileset_id.Location = new System.Drawing.Point(4, 7);
            this.lbl_tileset_id.Name = "lbl_tileset_id";
            this.lbl_tileset_id.Size = new System.Drawing.Size(43, 15);
            this.lbl_tileset_id.TabIndex = 0;
            this.lbl_tileset_id.Text = "Tileset:";
            // 
            // pnl_offsets
            // 
            this.pnl_offsets.AutoSize = true;
            this.pnl_offsets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_offsets.Controls.Add(this.lbl_main_graphics_pointer);
            this.pnl_offsets.Controls.Add(this.lbl_main_metatile);
            this.pnl_offsets.Controls.Add(this.cbb_metatile_table);
            this.pnl_offsets.Controls.Add(this.txb_graphics_offset);
            this.pnl_offsets.Location = new System.Drawing.Point(0, 0);
            this.pnl_offsets.Name = "pnl_offsets";
            this.pnl_offsets.Padding = new System.Windows.Forms.Padding(1);
            this.pnl_offsets.Size = new System.Drawing.Size(160, 61);
            this.pnl_offsets.TabIndex = 12;
            // 
            // pnl_tilesets
            // 
            this.pnl_tilesets.AutoSize = true;
            this.pnl_tilesets.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnl_tilesets.Controls.Add(this.lbl_tileset_id);
            this.pnl_tilesets.Controls.Add(this.cbb_tileset_id);
            this.pnl_tilesets.Location = new System.Drawing.Point(0, 0);
            this.pnl_tilesets.Name = "pnl_tilesets";
            this.pnl_tilesets.Padding = new System.Windows.Forms.Padding(1);
            this.pnl_tilesets.Size = new System.Drawing.Size(160, 31);
            this.pnl_tilesets.TabIndex = 13;
            // 
            // TilesetInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnl_tilesets);
            this.Controls.Add(this.pnl_offsets);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TilesetInput";
            this.Size = new System.Drawing.Size(163, 64);
            this.pnl_offsets.ResumeLayout(false);
            this.pnl_offsets.PerformLayout();
            this.pnl_tilesets.ResumeLayout(false);
            this.pnl_tilesets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txb_graphics_offset;
        private System.Windows.Forms.ComboBox cbb_metatile_table;
        private System.Windows.Forms.Label lbl_main_graphics_pointer;
        private System.Windows.Forms.Label lbl_main_metatile;
        private System.Windows.Forms.ComboBox cbb_tileset_id;
        private System.Windows.Forms.Label lbl_tileset_id;
        private System.Windows.Forms.Panel pnl_offsets;
        private System.Windows.Forms.Panel pnl_tilesets;
    }
}
