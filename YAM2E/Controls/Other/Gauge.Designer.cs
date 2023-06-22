namespace LAMP.Controls.Other
{
    partial class Gauge
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
            pnlBackground = new System.Windows.Forms.Panel();
            pnlBar = new System.Windows.Forms.Panel();
            pnlBackground.SuspendLayout();
            SuspendLayout();
            // 
            // pnlBackground
            // 
            pnlBackground.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            pnlBackground.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            pnlBackground.Controls.Add(pnlBar);
            pnlBackground.Location = new System.Drawing.Point(1, 1);
            pnlBackground.Margin = new System.Windows.Forms.Padding(1);
            pnlBackground.Name = "pnlBackground";
            pnlBackground.Size = new System.Drawing.Size(369, 37);
            pnlBackground.TabIndex = 0;
            // 
            // pnlBar
            // 
            pnlBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            pnlBar.BackColor = System.Drawing.Color.FromArgb(0, 192, 192);
            pnlBar.Location = new System.Drawing.Point(0, 0);
            pnlBar.Margin = new System.Windows.Forms.Padding(0);
            pnlBar.Name = "pnlBar";
            pnlBar.Size = new System.Drawing.Size(0, 37);
            pnlBar.TabIndex = 0;
            // 
            // Gauge
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(188, 188, 188);
            Controls.Add(pnlBackground);
            Name = "Gauge";
            Size = new System.Drawing.Size(371, 39);
            SizeChanged += Gauge_SizeChanged;
            pnlBackground.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlBackground;
        private System.Windows.Forms.Panel pnlBar;
    }
}
