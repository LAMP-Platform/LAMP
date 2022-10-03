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
            this.lbl_offset_test = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_offset_test
            // 
            this.lbl_offset_test.AutoSize = true;
            this.lbl_offset_test.Location = new System.Drawing.Point(12, 51);
            this.lbl_offset_test.Name = "lbl_offset_test";
            this.lbl_offset_test.Size = new System.Drawing.Size(76, 15);
            this.lbl_offset_test.TabIndex = 0;
            this.lbl_offset_test.Text = "Offset Value: ";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(12, 12);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(114, 23);
            this.txt_input.TabIndex = 1;
            // 
            // btn_apply
            // 
            this.btn_apply.Location = new System.Drawing.Point(132, 11);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 23);
            this.btn_apply.TabIndex = 2;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // Test_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(546, 288);
            this.Controls.Add(this.btn_apply);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_offset_test);
            this.Name = "Test_form";
            this.Text = "Test_form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_offset_test;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_apply;
    }
}