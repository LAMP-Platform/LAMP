namespace LAMP.FORMS
{
    partial class Converter
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
            grp_hex = new System.Windows.Forms.GroupBox();
            lbl_decimal = new System.Windows.Forms.Label();
            txb_hex_result = new System.Windows.Forms.TextBox();
            lbl_hex = new System.Windows.Forms.Label();
            lbl_hex_result = new System.Windows.Forms.Label();
            txb_hex_input = new System.Windows.Forms.TextBox();
            grp_hex.SuspendLayout();
            SuspendLayout();
            // 
            // grp_hex
            // 
            grp_hex.Controls.Add(lbl_decimal);
            grp_hex.Controls.Add(txb_hex_result);
            grp_hex.Controls.Add(lbl_hex);
            grp_hex.Controls.Add(lbl_hex_result);
            grp_hex.Controls.Add(txb_hex_input);
            grp_hex.Location = new System.Drawing.Point(12, 12);
            grp_hex.Name = "grp_hex";
            grp_hex.Size = new System.Drawing.Size(240, 69);
            grp_hex.TabIndex = 0;
            grp_hex.TabStop = false;
            grp_hex.Text = "Hexadecimal";
            // 
            // lbl_decimal
            // 
            lbl_decimal.AutoSize = true;
            lbl_decimal.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_decimal.Location = new System.Drawing.Point(133, 48);
            lbl_decimal.Name = "lbl_decimal";
            lbl_decimal.Size = new System.Drawing.Size(43, 13);
            lbl_decimal.TabIndex = 4;
            lbl_decimal.Text = "Decimal";
            // 
            // txb_hex_result
            // 
            txb_hex_result.Location = new System.Drawing.Point(133, 22);
            txb_hex_result.Name = "txb_hex_result";
            txb_hex_result.Size = new System.Drawing.Size(100, 23);
            txb_hex_result.TabIndex = 3;
            txb_hex_result.TextChanged += txb_hex_result_TextChanged;
            // 
            // lbl_hex
            // 
            lbl_hex.AutoSize = true;
            lbl_hex.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_hex.Location = new System.Drawing.Point(6, 48);
            lbl_hex.Name = "lbl_hex";
            lbl_hex.Size = new System.Drawing.Size(65, 13);
            lbl_hex.TabIndex = 2;
            lbl_hex.Text = "Hexadecimal";
            // 
            // lbl_hex_result
            // 
            lbl_hex_result.AutoSize = true;
            lbl_hex_result.Location = new System.Drawing.Point(112, 25);
            lbl_hex_result.Name = "lbl_hex_result";
            lbl_hex_result.Size = new System.Drawing.Size(15, 15);
            lbl_hex_result.TabIndex = 1;
            lbl_hex_result.Text = "=";
            // 
            // txb_hex_input
            // 
            txb_hex_input.Location = new System.Drawing.Point(6, 22);
            txb_hex_input.Name = "txb_hex_input";
            txb_hex_input.Size = new System.Drawing.Size(100, 23);
            txb_hex_input.TabIndex = 0;
            txb_hex_input.TextChanged += txb_hex_input_TextChanged;
            // 
            // Converter
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(269, 96);
            Controls.Add(grp_hex);
            MinimumSize = new System.Drawing.Size(285, 135);
            Name = "Converter";
            Text = "Converter";
            grp_hex.ResumeLayout(false);
            grp_hex.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_hex;
        private System.Windows.Forms.Label lbl_decimal;
        private System.Windows.Forms.TextBox txb_hex_result;
        private System.Windows.Forms.Label lbl_hex;
        private System.Windows.Forms.Label lbl_hex_result;
        private System.Windows.Forms.TextBox txb_hex_input;
    }
}