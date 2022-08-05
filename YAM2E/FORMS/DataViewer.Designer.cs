namespace YAM2E.FORMS
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
            this.grp_data_selection = new System.Windows.Forms.GroupBox();
            this.num_length = new System.Windows.Forms.NumericUpDown();
            this.lbl_length = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.num_bank = new System.Windows.Forms.NumericUpDown();
            this.lbl_bank = new System.Windows.Forms.Label();
            this.lbl_offset = new System.Windows.Forms.Label();
            this.num_offset = new System.Windows.Forms.NumericUpDown();
            this.chb_bank_offset = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txb_raw_data = new System.Windows.Forms.TextBox();
            this.grp_raw_data = new System.Windows.Forms.GroupBox();
            this.btn_rewrite = new System.Windows.Forms.Button();
            this.grp_data_selection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_length)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).BeginInit();
            this.grp_raw_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_data_selection
            // 
            this.grp_data_selection.Controls.Add(this.num_length);
            this.grp_data_selection.Controls.Add(this.lbl_length);
            this.grp_data_selection.Controls.Add(this.btn_go);
            this.grp_data_selection.Controls.Add(this.num_bank);
            this.grp_data_selection.Controls.Add(this.lbl_bank);
            this.grp_data_selection.Controls.Add(this.lbl_offset);
            this.grp_data_selection.Controls.Add(this.num_offset);
            this.grp_data_selection.Controls.Add(this.chb_bank_offset);
            this.grp_data_selection.Location = new System.Drawing.Point(12, 12);
            this.grp_data_selection.Name = "grp_data_selection";
            this.grp_data_selection.Size = new System.Drawing.Size(848, 109);
            this.grp_data_selection.TabIndex = 0;
            this.grp_data_selection.TabStop = false;
            this.grp_data_selection.Text = "Data Selection";
            // 
            // num_length
            // 
            this.num_length.Hexadecimal = true;
            this.num_length.Location = new System.Drawing.Point(65, 74);
            this.num_length.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.num_length.Name = "num_length";
            this.num_length.Size = new System.Drawing.Size(48, 23);
            this.num_length.TabIndex = 7;
            this.num_length.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(9, 76);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(50, 15);
            this.lbl_length.TabIndex = 6;
            this.lbl_length.Text = "Length: ";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(124, 74);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(75, 23);
            this.btn_go.TabIndex = 5;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_go_Click);
            // 
            // num_bank
            // 
            this.num_bank.Hexadecimal = true;
            this.num_bank.Location = new System.Drawing.Point(164, 17);
            this.num_bank.Maximum = new decimal(new int[] {
            96,
            0,
            0,
            0});
            this.num_bank.Name = "num_bank";
            this.num_bank.Size = new System.Drawing.Size(35, 23);
            this.num_bank.TabIndex = 4;
            this.num_bank.Visible = false;
            // 
            // lbl_bank
            // 
            this.lbl_bank.AutoSize = true;
            this.lbl_bank.Location = new System.Drawing.Point(119, 19);
            this.lbl_bank.Name = "lbl_bank";
            this.lbl_bank.Size = new System.Drawing.Size(39, 15);
            this.lbl_bank.TabIndex = 3;
            this.lbl_bank.Text = "Bank: ";
            this.lbl_bank.Visible = false;
            // 
            // lbl_offset
            // 
            this.lbl_offset.AutoSize = true;
            this.lbl_offset.Location = new System.Drawing.Point(6, 19);
            this.lbl_offset.Name = "lbl_offset";
            this.lbl_offset.Size = new System.Drawing.Size(42, 15);
            this.lbl_offset.TabIndex = 2;
            this.lbl_offset.Text = "Offset:";
            // 
            // num_offset
            // 
            this.num_offset.Hexadecimal = true;
            this.num_offset.Location = new System.Drawing.Point(54, 17);
            this.num_offset.Maximum = new decimal(new int[] {
            8000000,
            0,
            0,
            0});
            this.num_offset.Name = "num_offset";
            this.num_offset.Size = new System.Drawing.Size(59, 23);
            this.num_offset.TabIndex = 1;
            // 
            // chb_bank_offset
            // 
            this.chb_bank_offset.AutoSize = true;
            this.chb_bank_offset.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_bank_offset.Location = new System.Drawing.Point(6, 49);
            this.chb_bank_offset.Name = "chb_bank_offset";
            this.chb_bank_offset.Size = new System.Drawing.Size(79, 19);
            this.chb_bank_offset.TabIndex = 0;
            this.chb_bank_offset.Text = "Use Banks";
            this.chb_bank_offset.UseVisualStyleBackColor = true;
            this.chb_bank_offset.CheckedChanged += new System.EventHandler(this.chb_bank_offset_CheckedChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 632);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(868, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txb_raw_data
            // 
            this.txb_raw_data.BackColor = System.Drawing.SystemColors.Control;
            this.txb_raw_data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_raw_data.Location = new System.Drawing.Point(9, 22);
            this.txb_raw_data.Multiline = true;
            this.txb_raw_data.Name = "txb_raw_data";
            this.txb_raw_data.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_raw_data.Size = new System.Drawing.Size(833, 441);
            this.txb_raw_data.TabIndex = 2;
            // 
            // grp_raw_data
            // 
            this.grp_raw_data.Controls.Add(this.btn_rewrite);
            this.grp_raw_data.Controls.Add(this.txb_raw_data);
            this.grp_raw_data.Location = new System.Drawing.Point(12, 127);
            this.grp_raw_data.Name = "grp_raw_data";
            this.grp_raw_data.Size = new System.Drawing.Size(848, 498);
            this.grp_raw_data.TabIndex = 3;
            this.grp_raw_data.TabStop = false;
            this.grp_raw_data.Text = "Data";
            // 
            // btn_rewrite
            // 
            this.btn_rewrite.Location = new System.Drawing.Point(9, 469);
            this.btn_rewrite.Name = "btn_rewrite";
            this.btn_rewrite.Size = new System.Drawing.Size(833, 23);
            this.btn_rewrite.TabIndex = 4;
            this.btn_rewrite.Text = "Write data at selected offset";
            this.btn_rewrite.UseVisualStyleBackColor = true;
            this.btn_rewrite.Click += new System.EventHandler(this.btn_rewrite_Click);
            // 
            // DataViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 654);
            this.Controls.Add(this.grp_raw_data);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_data_selection);
            this.Name = "DataViewer";
            this.Text = "Data Viewer";
            this.grp_data_selection.ResumeLayout(false);
            this.grp_data_selection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_length)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_offset)).EndInit();
            this.grp_raw_data.ResumeLayout(false);
            this.grp_raw_data.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_data_selection;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Button btn_go;
        private System.Windows.Forms.NumericUpDown num_bank;
        private System.Windows.Forms.Label lbl_bank;
        private System.Windows.Forms.Label lbl_offset;
        private System.Windows.Forms.NumericUpDown num_offset;
        private System.Windows.Forms.CheckBox chb_bank_offset;
        private System.Windows.Forms.NumericUpDown num_length;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txb_raw_data;
        private System.Windows.Forms.GroupBox grp_raw_data;
        private System.Windows.Forms.Button btn_rewrite;
    }
}