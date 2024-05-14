namespace LAMP.Dialogs
{
    partial class DontShowAgainDialog
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
            chb_dontshowagain = new System.Windows.Forms.CheckBox();
            btn_ok = new System.Windows.Forms.Button();
            txb_text = new System.Windows.Forms.TextBox();
            SuspendLayout();
            // 
            // chb_dontshowagain
            // 
            chb_dontshowagain.AutoSize = true;
            chb_dontshowagain.Location = new System.Drawing.Point(12, 129);
            chb_dontshowagain.Name = "chb_dontshowagain";
            chb_dontshowagain.Size = new System.Drawing.Size(125, 19);
            chb_dontshowagain.TabIndex = 1;
            chb_dontshowagain.Text = "Do not show again";
            chb_dontshowagain.UseVisualStyleBackColor = true;
            // 
            // btn_ok
            // 
            btn_ok.Location = new System.Drawing.Point(347, 126);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new System.Drawing.Size(70, 23);
            btn_ok.TabIndex = 2;
            btn_ok.Text = "Ok";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // txb_text
            // 
            txb_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txb_text.Location = new System.Drawing.Point(12, 12);
            txb_text.Multiline = true;
            txb_text.Name = "txb_text";
            txb_text.ReadOnly = true;
            txb_text.Size = new System.Drawing.Size(405, 108);
            txb_text.TabIndex = 3;
            // 
            // DontShowAgainDialog
            // 
            AcceptButton = btn_ok;
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(429, 161);
            Controls.Add(txb_text);
            Controls.Add(btn_ok);
            Controls.Add(chb_dontshowagain);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DontShowAgainDialog";
            Text = "Warning";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.CheckBox chb_dontshowagain;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.TextBox txb_text;
    }
}