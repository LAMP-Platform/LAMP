namespace LAMP.Controls.Transitions
{
    partial class TransitionOperand
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
            this.lblOperandName = new System.Windows.Forms.Label();
            this.txbOperandValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOperandName
            // 
            this.lblOperandName.AutoSize = true;
            this.lblOperandName.Location = new System.Drawing.Point(12, 3);
            this.lblOperandName.Margin = new System.Windows.Forms.Padding(12, 0, 3, 0);
            this.lblOperandName.Name = "lblOperandName";
            this.lblOperandName.Size = new System.Drawing.Size(88, 15);
            this.lblOperandName.TabIndex = 0;
            this.lblOperandName.Text = "Operand Name";
            // 
            // txbOperandValue
            // 
            this.txbOperandValue.Location = new System.Drawing.Point(117, -2);
            this.txbOperandValue.Margin = new System.Windows.Forms.Padding(0);
            this.txbOperandValue.Name = "txbOperandValue";
            this.txbOperandValue.Size = new System.Drawing.Size(136, 23);
            this.txbOperandValue.TabIndex = 1;
            this.txbOperandValue.Leave += new System.EventHandler(this.txbOperandValue_Leave);
            // 
            // TransitionOperand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.txbOperandValue);
            this.Controls.Add(this.lblOperandName);
            this.Name = "TransitionOperand";
            this.Size = new System.Drawing.Size(253, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOperandName;
        private System.Windows.Forms.TextBox txbOperandValue;
    }
}
