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
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            grp_data_selection = new System.Windows.Forms.GroupBox();
            btn_view = new System.Windows.Forms.Button();
            txb_length = new System.Windows.Forms.TextBox();
            lbl_length = new System.Windows.Forms.Label();
            txb_offset = new System.Windows.Forms.TextBox();
            lbl_offset = new System.Windows.Forms.Label();
            grp_data = new System.Windows.Forms.GroupBox();
            panel1 = new System.Windows.Forms.Panel();
            panel2 = new System.Windows.Forms.Panel();
            grp_data_selection.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 632);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(868, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // grp_data_selection
            // 
            grp_data_selection.Controls.Add(btn_view);
            grp_data_selection.Controls.Add(txb_length);
            grp_data_selection.Controls.Add(lbl_length);
            grp_data_selection.Controls.Add(txb_offset);
            grp_data_selection.Controls.Add(lbl_offset);
            grp_data_selection.Location = new System.Drawing.Point(12, 12);
            grp_data_selection.Margin = new System.Windows.Forms.Padding(3, 3, 3, 1);
            grp_data_selection.Name = "grp_data_selection";
            grp_data_selection.Size = new System.Drawing.Size(165, 110);
            grp_data_selection.TabIndex = 2;
            grp_data_selection.TabStop = false;
            grp_data_selection.Text = "Data Selector";
            // 
            // btn_view
            // 
            btn_view.Location = new System.Drawing.Point(84, 80);
            btn_view.Name = "btn_view";
            btn_view.Size = new System.Drawing.Size(75, 23);
            btn_view.TabIndex = 6;
            btn_view.Text = "View";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // txb_length
            // 
            txb_length.Location = new System.Drawing.Point(59, 51);
            txb_length.Name = "txb_length";
            txb_length.Size = new System.Drawing.Size(100, 23);
            txb_length.TabIndex = 5;
            // 
            // lbl_length
            // 
            lbl_length.AutoSize = true;
            lbl_length.Location = new System.Drawing.Point(6, 54);
            lbl_length.Name = "lbl_length";
            lbl_length.Size = new System.Drawing.Size(47, 15);
            lbl_length.TabIndex = 4;
            lbl_length.Text = "Length:";
            // 
            // txb_offset
            // 
            txb_offset.Location = new System.Drawing.Point(59, 22);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(100, 23);
            txb_offset.TabIndex = 3;
            // 
            // lbl_offset
            // 
            lbl_offset.AutoSize = true;
            lbl_offset.Location = new System.Drawing.Point(6, 25);
            lbl_offset.Name = "lbl_offset";
            lbl_offset.Size = new System.Drawing.Size(42, 15);
            lbl_offset.TabIndex = 0;
            lbl_offset.Text = "Offset:";
            // 
            // grp_data
            // 
            grp_data.Dock = System.Windows.Forms.DockStyle.Fill;
            grp_data.Location = new System.Drawing.Point(0, 0);
            grp_data.Name = "grp_data";
            grp_data.Size = new System.Drawing.Size(868, 509);
            grp_data.TabIndex = 3;
            grp_data.TabStop = false;
            grp_data.Text = "Data";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(grp_data_selection);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(868, 123);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(grp_data);
            panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            panel2.Location = new System.Drawing.Point(0, 123);
            panel2.Margin = new System.Windows.Forms.Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(868, 509);
            panel2.TabIndex = 5;
            // 
            // DataViewer
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(868, 654);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MinimumSize = new System.Drawing.Size(884, 693);
            Name = "DataViewer";
            Text = "Data Viewer";
            grp_data_selection.ResumeLayout(false);
            grp_data_selection.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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