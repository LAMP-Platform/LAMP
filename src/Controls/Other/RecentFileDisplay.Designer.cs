namespace LAMP.Controls.Other
{
    partial class RecentFileDisplay
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
            pnl_main = new System.Windows.Forms.Panel();
            lbl_path = new System.Windows.Forms.Label();
            lbl_title = new System.Windows.Forms.Label();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = System.Drawing.SystemColors.Control;
            pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_main.Controls.Add(lbl_path);
            pnl_main.Controls.Add(lbl_title);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new System.Drawing.Size(472, 60);
            pnl_main.TabIndex = 0;
            pnl_main.Click += lbl_title_Click;
            pnl_main.MouseEnter += pnl_main_MouseEnter;
            pnl_main.MouseLeave += pnl_main_MouseLeave;
            // 
            // lbl_path
            // 
            lbl_path.AutoSize = true;
            lbl_path.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_path.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lbl_path.Location = new System.Drawing.Point(7, 32);
            lbl_path.Name = "lbl_path";
            lbl_path.Size = new System.Drawing.Size(263, 17);
            lbl_path.TabIndex = 1;
            lbl_path.Text = "E:\\METROID\\Metroid 2 RoS\\April Fools hack";
            lbl_path.Click += lbl_title_Click;
            lbl_path.MouseEnter += pnl_main_MouseEnter;
            lbl_path.MouseLeave += pnl_main_MouseLeave;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_title.Location = new System.Drawing.Point(3, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new System.Drawing.Size(76, 32);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Sm 2\r\n";
            lbl_title.Click += lbl_title_Click;
            lbl_title.MouseEnter += pnl_main_MouseEnter;
            lbl_title.MouseLeave += pnl_main_MouseLeave;
            // 
            // RecentFileDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(pnl_main);
            Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            Name = "RecentFileDisplay";
            Size = new System.Drawing.Size(472, 60);
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_title;
    }
}
