namespace LAMP.Controls
{
    partial class DataChunkView
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
            this.lblDataStart = new System.Windows.Forms.Label();
            this.txbStartOffset = new System.Windows.Forms.TextBox();
            this.lblDataLength = new System.Windows.Forms.Label();
            this.txbChunkLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDataStart
            // 
            this.lblDataStart.AutoSize = true;
            this.lblDataStart.Location = new System.Drawing.Point(3, 6);
            this.lblDataStart.Name = "lblDataStart";
            this.lblDataStart.Size = new System.Drawing.Size(107, 15);
            this.lblDataStart.TabIndex = 0;
            this.lblDataStart.Text = "Chunk Start Offset:";
            // 
            // txbStartOffset
            // 
            this.txbStartOffset.Location = new System.Drawing.Point(116, 3);
            this.txbStartOffset.Name = "txbStartOffset";
            this.txbStartOffset.Size = new System.Drawing.Size(100, 23);
            this.txbStartOffset.TabIndex = 1;
            // 
            // lblDataLength
            // 
            this.lblDataLength.AutoSize = true;
            this.lblDataLength.Location = new System.Drawing.Point(3, 35);
            this.lblDataLength.Name = "lblDataLength";
            this.lblDataLength.Size = new System.Drawing.Size(85, 15);
            this.lblDataLength.TabIndex = 2;
            this.lblDataLength.Text = "Chunk Length:";
            // 
            // txbChunkLength
            // 
            this.txbChunkLength.Location = new System.Drawing.Point(116, 32);
            this.txbChunkLength.Name = "txbChunkLength";
            this.txbChunkLength.Size = new System.Drawing.Size(100, 23);
            this.txbChunkLength.TabIndex = 3;
            // 
            // DataChunkView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.txbChunkLength);
            this.Controls.Add(this.lblDataLength);
            this.Controls.Add(this.txbStartOffset);
            this.Controls.Add(this.lblDataStart);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataChunkView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(219, 58);
            this.MouseLeave += new System.EventHandler(this.DataChunkView_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DataChunkView_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataStart;
        private System.Windows.Forms.TextBox txbStartOffset;
        private System.Windows.Forms.Label lblDataLength;
        private System.Windows.Forms.TextBox txbChunkLength;
    }
}
