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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Transition = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gauge1 = new LAMP.Controls.Other.Gauge();
            this.Transition.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 22);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flowLayoutPanel1.Size = new System.Drawing.Size(315, 473);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // Transition
            // 
            this.Transition.AutoSize = true;
            this.Transition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Transition.Controls.Add(this.flowLayoutPanel1);
            this.Transition.Location = new System.Drawing.Point(12, 12);
            this.Transition.Name = "Transition";
            this.Transition.Size = new System.Drawing.Size(327, 517);
            this.Transition.TabIndex = 1;
            this.Transition.TabStop = false;
            this.Transition.Text = "Transition";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 552);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(351, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gauge1
            // 
            this.gauge1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(188)))), ((int)(((byte)(188)))), ((int)(((byte)(188)))));
            this.gauge1.Location = new System.Drawing.Point(12, 535);
            this.gauge1.Name = "gauge1";
            this.gauge1.Size = new System.Drawing.Size(327, 10);
            this.gauge1.TabIndex = 3;
            // 
            // Test_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(351, 574);
            this.Controls.Add(this.gauge1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.Transition);
            this.Name = "Test_form";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Test_form";
            this.Transition.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox Transition;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Controls.Other.Gauge gauge1;
    }
}