namespace LAMP.Controls
{
    partial class PaletteRow
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
            lbl_row = new System.Windows.Forms.Label();
            pnl_colors = new System.Windows.Forms.Panel();
            pnl_col3 = new System.Windows.Forms.Panel();
            pnl_col2 = new System.Windows.Forms.Panel();
            pnl_col1 = new System.Windows.Forms.Panel();
            pnl_col0 = new System.Windows.Forms.Panel();
            pnl_colors.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_row
            // 
            lbl_row.Anchor = System.Windows.Forms.AnchorStyles.Left;
            lbl_row.AutoSize = true;
            lbl_row.Location = new System.Drawing.Point(3, 16);
            lbl_row.Name = "lbl_row";
            lbl_row.Size = new System.Drawing.Size(42, 15);
            lbl_row.TabIndex = 0;
            lbl_row.Text = "Row 0:";
            // 
            // pnl_colors
            // 
            pnl_colors.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnl_colors.Controls.Add(pnl_col3);
            pnl_colors.Controls.Add(pnl_col2);
            pnl_colors.Controls.Add(pnl_col1);
            pnl_colors.Controls.Add(pnl_col0);
            pnl_colors.Location = new System.Drawing.Point(51, 0);
            pnl_colors.Name = "pnl_colors";
            pnl_colors.Size = new System.Drawing.Size(185, 47);
            pnl_colors.TabIndex = 1;
            // 
            // pnl_col3
            // 
            pnl_col3.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnl_col3.Location = new System.Drawing.Point(141, 3);
            pnl_col3.Name = "pnl_col3";
            pnl_col3.Size = new System.Drawing.Size(40, 40);
            pnl_col3.TabIndex = 3;
            pnl_col3.Click += pnl_col_Click;
            // 
            // pnl_col2
            // 
            pnl_col2.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnl_col2.Location = new System.Drawing.Point(95, 3);
            pnl_col2.Name = "pnl_col2";
            pnl_col2.Size = new System.Drawing.Size(40, 40);
            pnl_col2.TabIndex = 2;
            pnl_col2.Click += pnl_col_Click;
            // 
            // pnl_col1
            // 
            pnl_col1.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnl_col1.Location = new System.Drawing.Point(49, 3);
            pnl_col1.Name = "pnl_col1";
            pnl_col1.Size = new System.Drawing.Size(40, 40);
            pnl_col1.TabIndex = 1;
            pnl_col1.Click += pnl_col_Click;
            // 
            // pnl_col0
            // 
            pnl_col0.Anchor = System.Windows.Forms.AnchorStyles.None;
            pnl_col0.Location = new System.Drawing.Point(3, 3);
            pnl_col0.Name = "pnl_col0";
            pnl_col0.Size = new System.Drawing.Size(40, 40);
            pnl_col0.TabIndex = 0;
            pnl_col0.Click += pnl_col_Click;
            // 
            // PaletteRow
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(pnl_colors);
            Controls.Add(lbl_row);
            MinimumSize = new System.Drawing.Size(236, 47);
            Name = "PaletteRow";
            Size = new System.Drawing.Size(236, 47);
            pnl_colors.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_row;
        private System.Windows.Forms.Panel pnl_colors;
        private System.Windows.Forms.Panel pnl_col3;
        private System.Windows.Forms.Panel pnl_col2;
        private System.Windows.Forms.Panel pnl_col1;
        private System.Windows.Forms.Panel pnl_col0;
    }
}
