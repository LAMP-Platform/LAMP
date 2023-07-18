namespace LAMP.FORMS
{
    partial class SolidityEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SolidityEditor));
            pnl_main = new System.Windows.Forms.SplitContainer();
            grp_graphics_overlay = new System.Windows.Forms.GroupBox();
            txb_offset = new System.Windows.Forms.TextBox();
            lbl_offset = new System.Windows.Forms.Label();
            grp_solidity_data = new System.Windows.Forms.GroupBox();
            txb_projectiles = new System.Windows.Forms.TextBox();
            txb_samus = new System.Windows.Forms.TextBox();
            txb_objects = new System.Windows.Forms.TextBox();
            lbl_objects = new System.Windows.Forms.Label();
            lbl_projectiles = new System.Windows.Forms.Label();
            lbl_samus = new System.Windows.Forms.Label();
            cbb_solidity_table = new System.Windows.Forms.ComboBox();
            lbl_table = new System.Windows.Forms.Label();
            grp_preview = new System.Windows.Forms.GroupBox();
            pnl_apply_button = new System.Windows.Forms.Panel();
            btn_apply = new System.Windows.Forms.Button();
            btn_save_tileset = new System.Windows.Forms.Button();
            Statusstrip = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)pnl_main).BeginInit();
            pnl_main.Panel1.SuspendLayout();
            pnl_main.Panel2.SuspendLayout();
            pnl_main.SuspendLayout();
            grp_graphics_overlay.SuspendLayout();
            grp_solidity_data.SuspendLayout();
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
            pnl_main.Panel1.Controls.Add(grp_graphics_overlay);
            pnl_main.Panel1.Controls.Add(grp_solidity_data);
            pnl_main.Panel1.Padding = new System.Windows.Forms.Padding(6, 6, 3, 6);
            // 
            // pnl_main.Panel2
            // 
            pnl_main.Panel2.Controls.Add(grp_preview);
            pnl_main.Panel2.Controls.Add(pnl_apply_button);
            pnl_main.Panel2.Padding = new System.Windows.Forms.Padding(3, 6, 6, 6);
            pnl_main.Size = new System.Drawing.Size(490, 209);
            pnl_main.SplitterDistance = 187;
            pnl_main.TabIndex = 0;
            // 
            // grp_graphics_overlay
            // 
            grp_graphics_overlay.Controls.Add(txb_offset);
            grp_graphics_overlay.Controls.Add(lbl_offset);
            grp_graphics_overlay.Dock = System.Windows.Forms.DockStyle.Top;
            grp_graphics_overlay.Location = new System.Drawing.Point(6, 148);
            grp_graphics_overlay.Name = "grp_graphics_overlay";
            grp_graphics_overlay.Size = new System.Drawing.Size(178, 55);
            grp_graphics_overlay.TabIndex = 1;
            grp_graphics_overlay.TabStop = false;
            grp_graphics_overlay.Text = "Graphic Overlay";
            // 
            // txb_offset
            // 
            txb_offset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_offset.Location = new System.Drawing.Point(54, 22);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(118, 23);
            txb_offset.TabIndex = 26;
            // 
            // lbl_offset
            // 
            lbl_offset.AutoSize = true;
            lbl_offset.Location = new System.Drawing.Point(6, 25);
            lbl_offset.Name = "lbl_offset";
            lbl_offset.Size = new System.Drawing.Size(42, 15);
            lbl_offset.TabIndex = 0;
            lbl_offset.Text = "Offset:";
            // 
            // grp_solidity_data
            // 
            grp_solidity_data.Controls.Add(txb_projectiles);
            grp_solidity_data.Controls.Add(txb_samus);
            grp_solidity_data.Controls.Add(txb_objects);
            grp_solidity_data.Controls.Add(lbl_objects);
            grp_solidity_data.Controls.Add(lbl_projectiles);
            grp_solidity_data.Controls.Add(lbl_samus);
            grp_solidity_data.Controls.Add(cbb_solidity_table);
            grp_solidity_data.Controls.Add(lbl_table);
            grp_solidity_data.Dock = System.Windows.Forms.DockStyle.Top;
            grp_solidity_data.Location = new System.Drawing.Point(6, 6);
            grp_solidity_data.Name = "grp_solidity_data";
            grp_solidity_data.Size = new System.Drawing.Size(178, 142);
            grp_solidity_data.TabIndex = 0;
            grp_solidity_data.TabStop = false;
            grp_solidity_data.Text = "Solidity Data";
            // 
            // txb_projectiles
            // 
            txb_projectiles.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_projectiles.Location = new System.Drawing.Point(91, 109);
            txb_projectiles.Name = "txb_projectiles";
            txb_projectiles.Size = new System.Drawing.Size(81, 23);
            txb_projectiles.TabIndex = 25;
            // 
            // txb_samus
            // 
            txb_samus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_samus.Location = new System.Drawing.Point(91, 51);
            txb_samus.Name = "txb_samus";
            txb_samus.Size = new System.Drawing.Size(81, 23);
            txb_samus.TabIndex = 24;
            // 
            // txb_objects
            // 
            txb_objects.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_objects.Location = new System.Drawing.Point(91, 80);
            txb_objects.Name = "txb_objects";
            txb_objects.Size = new System.Drawing.Size(81, 23);
            txb_objects.TabIndex = 23;
            // 
            // lbl_objects
            // 
            lbl_objects.AutoSize = true;
            lbl_objects.Location = new System.Drawing.Point(6, 83);
            lbl_objects.Name = "lbl_objects";
            lbl_objects.Size = new System.Drawing.Size(50, 15);
            lbl_objects.TabIndex = 22;
            lbl_objects.Text = "Objects:";
            // 
            // lbl_projectiles
            // 
            lbl_projectiles.AutoSize = true;
            lbl_projectiles.Location = new System.Drawing.Point(6, 112);
            lbl_projectiles.Name = "lbl_projectiles";
            lbl_projectiles.Size = new System.Drawing.Size(59, 15);
            lbl_projectiles.TabIndex = 21;
            lbl_projectiles.Text = "Projectile:";
            // 
            // lbl_samus
            // 
            lbl_samus.AutoSize = true;
            lbl_samus.Location = new System.Drawing.Point(6, 54);
            lbl_samus.Name = "lbl_samus";
            lbl_samus.Size = new System.Drawing.Size(45, 15);
            lbl_samus.TabIndex = 20;
            lbl_samus.Text = "Samus:";
            // 
            // cbb_solidity_table
            // 
            cbb_solidity_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_solidity_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_solidity_table.FormattingEnabled = true;
            cbb_solidity_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_solidity_table.Location = new System.Drawing.Point(91, 22);
            cbb_solidity_table.Name = "cbb_solidity_table";
            cbb_solidity_table.Size = new System.Drawing.Size(81, 23);
            cbb_solidity_table.TabIndex = 19;
            cbb_solidity_table.SelectedIndexChanged += cbb_solidity_table_SelectedIndexChanged;
            // 
            // lbl_table
            // 
            lbl_table.AutoSize = true;
            lbl_table.Location = new System.Drawing.Point(6, 25);
            lbl_table.Name = "lbl_table";
            lbl_table.Size = new System.Drawing.Size(79, 15);
            lbl_table.TabIndex = 0;
            lbl_table.Text = "Solidity Table:";
            // 
            // grp_preview
            // 
            grp_preview.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_preview.Location = new System.Drawing.Point(3, 6);
            grp_preview.Name = "grp_preview";
            grp_preview.Size = new System.Drawing.Size(290, 168);
            grp_preview.TabIndex = 2;
            grp_preview.TabStop = false;
            grp_preview.Text = "Preview";
            // 
            // pnl_apply_button
            // 
            pnl_apply_button.Controls.Add(btn_apply);
            pnl_apply_button.Controls.Add(btn_save_tileset);
            pnl_apply_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_apply_button.Location = new System.Drawing.Point(3, 174);
            pnl_apply_button.Name = "pnl_apply_button";
            pnl_apply_button.Size = new System.Drawing.Size(290, 29);
            pnl_apply_button.TabIndex = 1;
            // 
            // btn_apply
            // 
            btn_apply.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_apply.Image = Properties.Resources.Save;
            btn_apply.Location = new System.Drawing.Point(226, 3);
            btn_apply.Name = "btn_apply";
            btn_apply.Size = new System.Drawing.Size(64, 23);
            btn_apply.TabIndex = 20;
            btn_apply.Text = "Apply";
            btn_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_apply.UseVisualStyleBackColor = true;
            btn_apply.Click += btn_apply_Click;
            // 
            // btn_save_tileset
            // 
            btn_save_tileset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_save_tileset.Enabled = false;
            btn_save_tileset.Image = Properties.Resources.Save;
            btn_save_tileset.Location = new System.Drawing.Point(316, 3);
            btn_save_tileset.Name = "btn_save_tileset";
            btn_save_tileset.Size = new System.Drawing.Size(64, 23);
            btn_save_tileset.TabIndex = 19;
            btn_save_tileset.Text = "Apply";
            btn_save_tileset.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            btn_save_tileset.UseVisualStyleBackColor = true;
            // 
            // Statusstrip
            // 
            Statusstrip.Location = new System.Drawing.Point(0, 209);
            Statusstrip.Name = "Statusstrip";
            Statusstrip.Size = new System.Drawing.Size(490, 22);
            Statusstrip.TabIndex = 1;
            Statusstrip.Text = "statusStrip1";
            // 
            // SolidityEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(490, 231);
            Controls.Add(pnl_main);
            Controls.Add(Statusstrip);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "SolidityEditor";
            Text = "Solidity Editor";
            pnl_main.Panel1.ResumeLayout(false);
            pnl_main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_main).EndInit();
            pnl_main.ResumeLayout(false);
            grp_graphics_overlay.ResumeLayout(false);
            grp_graphics_overlay.PerformLayout();
            grp_solidity_data.ResumeLayout(false);
            grp_solidity_data.PerformLayout();
            pnl_apply_button.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer pnl_main;
        private System.Windows.Forms.GroupBox grp_solidity_data;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.ComboBox cbb_solidity_table;
        private System.Windows.Forms.Label lbl_objects;
        private System.Windows.Forms.Label lbl_projectiles;
        private System.Windows.Forms.Label lbl_samus;
        private System.Windows.Forms.TextBox txb_samus;
        private System.Windows.Forms.TextBox txb_objects;
        private System.Windows.Forms.TextBox txb_projectiles;
        private System.Windows.Forms.Panel pnl_apply_button;
        private System.Windows.Forms.Button btn_save_tileset;
        private System.Windows.Forms.GroupBox grp_preview;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.GroupBox grp_graphics_overlay;
        private System.Windows.Forms.TextBox txb_offset;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.StatusStrip Statusstrip;
    }
}