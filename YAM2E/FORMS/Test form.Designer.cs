namespace LAMP.FORMS
{
    partial class Test_form
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
            grp1 = new System.Windows.Forms.GroupBox();
            lbl = new System.Windows.Forms.Label();
            grp2 = new System.Windows.Forms.GroupBox();
            grp1.SuspendLayout();
            SuspendLayout();
            // 
            // grp1
            // 
            grp1.Controls.Add(lbl);
            grp1.Location = new System.Drawing.Point(28, 28);
            grp1.Name = "grp1";
            grp1.Size = new System.Drawing.Size(359, 205);
            grp1.TabIndex = 0;
            grp1.TabStop = false;
            grp1.Text = "Panel 1";
            grp1.DragLeave += grp1_DragLeave;
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new System.Drawing.Point(114, 92);
            lbl.Name = "lbl";
            lbl.Size = new System.Drawing.Size(60, 15);
            lbl.TabIndex = 0;
            lbl.Text = "MOVE ME";
            lbl.MouseDown += lbl_MouseDown;
            lbl.MouseLeave += lbl_MouseLeave;
            lbl.MouseMove += lbl_MouseMove;
            lbl.MouseUp += lbl_MouseUp;
            // 
            // grp2
            // 
            grp2.Location = new System.Drawing.Point(28, 239);
            grp2.Name = "grp2";
            grp2.Size = new System.Drawing.Size(359, 205);
            grp2.TabIndex = 1;
            grp2.TabStop = false;
            grp2.Text = "Panel 2";
            // 
            // Test_form
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = System.Drawing.SystemColors.Control;
            ClientSize = new System.Drawing.Size(444, 497);
            Controls.Add(grp2);
            Controls.Add(grp1);
            Name = "Test_form";
            RightToLeft = System.Windows.Forms.RightToLeft.No;
            Text = "Test_form";
            grp1.ResumeLayout(false);
            grp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp1;
        private System.Windows.Forms.GroupBox grp2;
        private System.Windows.Forms.Label lbl;
    }
}