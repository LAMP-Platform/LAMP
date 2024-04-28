namespace LAMP.FORMS
{
    partial class PaletteEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaletteEditor));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            splitContainer1 = new System.Windows.Forms.SplitContainer();
            grp_data = new System.Windows.Forms.GroupBox();
            btn_remove = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            cbb_palette = new System.Windows.Forms.ComboBox();
            txb_name = new System.Windows.Forms.TextBox();
            lbl_name = new System.Windows.Forms.Label();
            grp_palette = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            grp_data.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(800, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer1.Location = new System.Drawing.Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(grp_data);
            splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(grp_palette);
            splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            splitContainer1.Size = new System.Drawing.Size(800, 428);
            splitContainer1.SplitterDistance = 243;
            splitContainer1.TabIndex = 1;
            // 
            // grp_data
            // 
            grp_data.Controls.Add(btn_remove);
            grp_data.Controls.Add(btn_add);
            grp_data.Controls.Add(cbb_palette);
            grp_data.Controls.Add(txb_name);
            grp_data.Controls.Add(lbl_name);
            grp_data.Dock = System.Windows.Forms.DockStyle.Top;
            grp_data.Location = new System.Drawing.Point(6, 3);
            grp_data.Name = "grp_data";
            grp_data.Size = new System.Drawing.Size(234, 88);
            grp_data.TabIndex = 5;
            grp_data.TabStop = false;
            grp_data.Text = "Select";
            // 
            // btn_remove
            // 
            btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_remove.Image = Properties.Resources.Remove;
            btn_remove.Location = new System.Drawing.Point(205, 22);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(23, 23);
            btn_remove.TabIndex = 5;
            btn_remove.UseVisualStyleBackColor = true;
            // 
            // btn_add
            // 
            btn_add.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_add.Image = Properties.Resources.Add;
            btn_add.Location = new System.Drawing.Point(176, 22);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(23, 23);
            btn_add.TabIndex = 4;
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // cbb_palette
            // 
            cbb_palette.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_palette.FormattingEnabled = true;
            cbb_palette.Location = new System.Drawing.Point(6, 22);
            cbb_palette.Name = "cbb_palette";
            cbb_palette.Size = new System.Drawing.Size(164, 23);
            cbb_palette.TabIndex = 1;
            cbb_palette.SelectedIndexChanged += cbb_palette_SelectedIndexChanged;
            // 
            // txb_name
            // 
            txb_name.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_name.Location = new System.Drawing.Point(51, 51);
            txb_name.Name = "txb_name";
            txb_name.Size = new System.Drawing.Size(119, 23);
            txb_name.TabIndex = 3;
            txb_name.TextChanged += txb_name_TextChanged;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Location = new System.Drawing.Point(6, 54);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(39, 15);
            lbl_name.TabIndex = 2;
            lbl_name.Text = "Name";
            // 
            // grp_palette
            // 
            grp_palette.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_palette.Location = new System.Drawing.Point(3, 3);
            grp_palette.Name = "grp_palette";
            grp_palette.Size = new System.Drawing.Size(544, 422);
            grp_palette.TabIndex = 6;
            grp_palette.TabStop = false;
            grp_palette.Text = "Palette";
            // 
            // PaletteEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "PaletteEditor";
            Text = "Palette Editor";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            grp_data.ResumeLayout(false);
            grp_data.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.ComboBox cbb_palette;
        private System.Windows.Forms.TextBox txb_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.GroupBox grp_palette;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
    }
}