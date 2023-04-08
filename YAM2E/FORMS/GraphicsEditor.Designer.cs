namespace LAMP.FORMS
{
    partial class GraphicsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphicsEditor));
            this.status_strip = new System.Windows.Forms.StatusStrip();
            this.grp_gfx_display = new System.Windows.Forms.GroupBox();
            this.grp_metatiles_display = new System.Windows.Forms.GroupBox();
            this.grp_data_selector = new System.Windows.Forms.GroupBox();
            this.lbl_offset = new System.Windows.Forms.Label();
            this.txb_offset = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.grp_data_selector.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // status_strip
            // 
            this.status_strip.Location = new System.Drawing.Point(0, 295);
            this.status_strip.Name = "status_strip";
            this.status_strip.Size = new System.Drawing.Size(498, 22);
            this.status_strip.TabIndex = 0;
            this.status_strip.Text = "statusStrip1";
            // 
            // grp_gfx_display
            // 
            this.grp_gfx_display.Location = new System.Drawing.Point(218, 12);
            this.grp_gfx_display.Name = "grp_gfx_display";
            this.grp_gfx_display.Size = new System.Drawing.Size(256, 128);
            this.grp_gfx_display.TabIndex = 1;
            this.grp_gfx_display.TabStop = false;
            this.grp_gfx_display.Text = "Graphics";
            // 
            // grp_metatiles_display
            // 
            this.grp_metatiles_display.Location = new System.Drawing.Point(218, 146);
            this.grp_metatiles_display.Name = "grp_metatiles_display";
            this.grp_metatiles_display.Size = new System.Drawing.Size(256, 128);
            this.grp_metatiles_display.TabIndex = 2;
            this.grp_metatiles_display.TabStop = false;
            this.grp_metatiles_display.Text = "Metatiles";
            // 
            // grp_data_selector
            // 
            this.grp_data_selector.Controls.Add(this.txb_offset);
            this.grp_data_selector.Controls.Add(this.lbl_offset);
            this.grp_data_selector.Location = new System.Drawing.Point(12, 12);
            this.grp_data_selector.Name = "grp_data_selector";
            this.grp_data_selector.Size = new System.Drawing.Size(200, 72);
            this.grp_data_selector.TabIndex = 3;
            this.grp_data_selector.TabStop = false;
            this.grp_data_selector.Text = "Data";
            // 
            // lbl_offset
            // 
            this.lbl_offset.AutoSize = true;
            this.lbl_offset.Location = new System.Drawing.Point(6, 25);
            this.lbl_offset.Name = "lbl_offset";
            this.lbl_offset.Size = new System.Drawing.Size(42, 15);
            this.lbl_offset.TabIndex = 4;
            this.lbl_offset.Text = "Offset:";
            // 
            // txb_offset
            // 
            this.txb_offset.Location = new System.Drawing.Point(54, 22);
            this.txb_offset.Name = "txb_offset";
            this.txb_offset.Size = new System.Drawing.Size(100, 23);
            this.txb_offset.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 50);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(12, 90);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(50, 50);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.panel3.Location = new System.Drawing.Point(50, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(50, 50);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.panel4.Location = new System.Drawing.Point(100, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(50, 50);
            this.panel4.TabIndex = 6;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(150, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(50, 50);
            this.panel5.TabIndex = 6;
            // 
            // GraphicsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 317);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grp_data_selector);
            this.Controls.Add(this.grp_metatiles_display);
            this.Controls.Add(this.grp_gfx_display);
            this.Controls.Add(this.status_strip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GraphicsEditor";
            this.Text = "Graphics Editor";
            this.grp_data_selector.ResumeLayout(false);
            this.grp_data_selector.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip status_strip;
        private System.Windows.Forms.GroupBox grp_gfx_display;
        private System.Windows.Forms.GroupBox grp_metatiles_display;
        private System.Windows.Forms.GroupBox grp_data_selector;
        private System.Windows.Forms.TextBox txb_offset;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
    }
}