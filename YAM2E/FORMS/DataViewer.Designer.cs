namespace LAMP.FORMS
{
    partial class DataViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewer));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_data_selection = new System.Windows.Forms.GroupBox();
            this.btn_view = new System.Windows.Forms.Button();
            this.txb_length = new System.Windows.Forms.TextBox();
            this.lbl_length = new System.Windows.Forms.Label();
            this.txb_offset = new System.Windows.Forms.TextBox();
            this.lbl_offset = new System.Windows.Forms.Label();
            this.grp_data = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.grp_data_selection.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grp_data_selection
            // 
            this.grp_data_selection.Controls.Add(this.btn_view);
            this.grp_data_selection.Controls.Add(this.txb_length);
            this.grp_data_selection.Controls.Add(this.lbl_length);
            this.grp_data_selection.Controls.Add(this.txb_offset);
            this.grp_data_selection.Controls.Add(this.lbl_offset);
            this.grp_data_selection.Location = new System.Drawing.Point(12, 12);
            this.grp_data_selection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            this.grp_data_selection.Name = "grp_data_selection";
            this.grp_data_selection.Size = new System.Drawing.Size(165, 110);
            this.grp_data_selection.TabIndex = 2;
            this.grp_data_selection.TabStop = false;
            this.grp_data_selection.Text = "Data Selector";
            // 
            // btn_view
            // 
            this.btn_view.Location = new System.Drawing.Point(84, 80);
            this.btn_view.Name = "btn_view";
            this.btn_view.Size = new System.Drawing.Size(75, 23);
            this.btn_view.TabIndex = 6;
            this.btn_view.Text = "View";
            this.btn_view.UseVisualStyleBackColor = true;
            this.btn_view.Click += new System.EventHandler(this.btn_view_Click);
            // 
            // txb_length
            // 
            this.txb_length.Location = new System.Drawing.Point(59, 51);
            this.txb_length.Name = "txb_length";
            this.txb_length.Size = new System.Drawing.Size(100, 23);
            this.txb_length.TabIndex = 5;
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(6, 54);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(47, 15);
            this.lbl_length.TabIndex = 4;
            this.lbl_length.Text = "Length:";
            // 
            // txb_offset
            // 
            this.txb_offset.Location = new System.Drawing.Point(59, 22);
            this.txb_offset.Name = "txb_offset";
            this.txb_offset.Size = new System.Drawing.Size(100, 23);
            this.txb_offset.TabIndex = 3;
            // 
            // lbl_offset
            // 
            this.lbl_offset.AutoSize = true;
            this.lbl_offset.Location = new System.Drawing.Point(6, 25);
            this.lbl_offset.Name = "lbl_offset";
            this.lbl_offset.Size = new System.Drawing.Size(42, 15);
            this.lbl_offset.TabIndex = 0;
            this.lbl_offset.Text = "Offset:";
            // 
            // grp_data
            // 
            this.grp_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_data.Location = new System.Drawing.Point(0, 0);
            this.grp_data.Name = "grp_data";
            this.grp_data.Size = new System.Drawing.Size(868, 509);
            this.grp_data.TabIndex = 3;
            this.grp_data.TabStop = false;
            this.grp_data.Text = "Data";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.grp_data_selection);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 123);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.grp_data);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 123);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 509);
            this.panel2.TabIndex = 5;
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 654);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(884, 693);
            this.Name = "DataViewer";
            this.Text = "Data Viewer";
            this.grp_data_selection.ResumeLayout(false);
            this.grp_data_selection.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grp_data_selection;
        private System.Windows.Forms.Button btn_view;
        private System.Windows.Forms.TextBox txb_length;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.TextBox txb_offset;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}