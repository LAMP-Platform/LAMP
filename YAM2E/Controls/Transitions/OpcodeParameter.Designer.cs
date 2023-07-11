namespace LAMP.Controls.Other
{
    partial class OpcodeParameter
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
            lbl_title = new System.Windows.Forms.Label();
            txb_parameter = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Location = new System.Drawing.Point(4, 7);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new System.Drawing.Size(29, 15);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Title";
            // 
            // txb_parameter
            // 
            txb_parameter.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_parameter.Location = new System.Drawing.Point(120, 4);
            txb_parameter.Name = "txb_parameter";
            txb_parameter.Size = new System.Drawing.Size(63, 23);
            txb_parameter.TabIndex = 1;
            // 
            // OpcodeParameter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(txb_parameter);
            Controls.Add(lbl_title);
            Name = "OpcodeParameter";
            Padding = new System.Windows.Forms.Padding(1);
            Size = new System.Drawing.Size(187, 31);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox txb_parameter;
    }
}
