namespace LAMP.FORMS
{
    partial class ObjectSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ObjectSettings));
            this.num_obj_number = new System.Windows.Forms.NumericUpDown();
            this.lbl_obj_number = new System.Windows.Forms.Label();
            this.lbl_obj_type = new System.Windows.Forms.Label();
            this.num_obj_type = new System.Windows.Forms.NumericUpDown();
            this.txb_info = new System.Windows.Forms.TextBox();
            this.btn_apply = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.grp_object_data = new System.Windows.Forms.GroupBox();
            this.grp_info = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.num_obj_number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_obj_type)).BeginInit();
            this.grp_object_data.SuspendLayout();
            this.grp_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // num_obj_number
            // 
            this.num_obj_number.Hexadecimal = true;
            this.num_obj_number.Location = new System.Drawing.Point(104, 46);
            this.num_obj_number.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_obj_number.Name = "num_obj_number";
            this.num_obj_number.Size = new System.Drawing.Size(35, 23);
            this.num_obj_number.TabIndex = 0;
            this.num_obj_number.ValueChanged += new System.EventHandler(this.num_obj_number_ValueChanged);
            // 
            // lbl_obj_number
            // 
            this.lbl_obj_number.AutoSize = true;
            this.lbl_obj_number.Location = new System.Drawing.Point(6, 48);
            this.lbl_obj_number.Name = "lbl_obj_number";
            this.lbl_obj_number.Size = new System.Drawing.Size(92, 15);
            this.lbl_obj_number.TabIndex = 1;
            this.lbl_obj_number.Text = "Object Number:";
            // 
            // lbl_obj_type
            // 
            this.lbl_obj_type.AutoSize = true;
            this.lbl_obj_type.Location = new System.Drawing.Point(6, 19);
            this.lbl_obj_type.Name = "lbl_obj_type";
            this.lbl_obj_type.Size = new System.Drawing.Size(72, 15);
            this.lbl_obj_type.TabIndex = 3;
            this.lbl_obj_type.Text = "Object Type:";
            // 
            // num_obj_type
            // 
            this.num_obj_type.Hexadecimal = true;
            this.num_obj_type.Location = new System.Drawing.Point(104, 17);
            this.num_obj_type.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.num_obj_type.Name = "num_obj_type";
            this.num_obj_type.Size = new System.Drawing.Size(35, 23);
            this.num_obj_type.TabIndex = 2;
            this.num_obj_type.ValueChanged += new System.EventHandler(this.num_obj_type_ValueChanged);
            // 
            // txb_info
            // 
            this.txb_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_info.Location = new System.Drawing.Point(6, 17);
            this.txb_info.Multiline = true;
            this.txb_info.Name = "txb_info";
            this.txb_info.ReadOnly = true;
            this.txb_info.Size = new System.Drawing.Size(183, 81);
            this.txb_info.TabIndex = 4;
            this.txb_info.Text = "Use an Object Number in the range of 0x40 to 0x7F to make the object not respawn!" +
    "\r\n";
            // 
            // btn_apply
            // 
            this.btn_apply.Enabled = false;
            this.btn_apply.Location = new System.Drawing.Point(6, 75);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(58, 23);
            this.btn_apply.TabIndex = 5;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            this.btn_apply.Click += new System.EventHandler(this.btn_apply_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(81, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // grp_object_data
            // 
            this.grp_object_data.Controls.Add(this.lbl_obj_type);
            this.grp_object_data.Controls.Add(this.button1);
            this.grp_object_data.Controls.Add(this.num_obj_number);
            this.grp_object_data.Controls.Add(this.btn_apply);
            this.grp_object_data.Controls.Add(this.lbl_obj_number);
            this.grp_object_data.Controls.Add(this.num_obj_type);
            this.grp_object_data.Location = new System.Drawing.Point(12, 12);
            this.grp_object_data.Name = "grp_object_data";
            this.grp_object_data.Size = new System.Drawing.Size(150, 107);
            this.grp_object_data.TabIndex = 7;
            this.grp_object_data.TabStop = false;
            this.grp_object_data.Text = "Data";
            // 
            // grp_info
            // 
            this.grp_info.Controls.Add(this.txb_info);
            this.grp_info.Location = new System.Drawing.Point(168, 12);
            this.grp_info.Name = "grp_info";
            this.grp_info.Size = new System.Drawing.Size(195, 107);
            this.grp_info.TabIndex = 8;
            this.grp_info.TabStop = false;
            this.grp_info.Text = "Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 129);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(374, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ObjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 151);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_info);
            this.Controls.Add(this.grp_object_data);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(390, 190);
            this.Name = "ObjectSettings";
            this.Text = "Object Settings";
            ((System.ComponentModel.ISupportInitialize)(this.num_obj_number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_obj_type)).EndInit();
            this.grp_object_data.ResumeLayout(false);
            this.grp_object_data.PerformLayout();
            this.grp_info.ResumeLayout(false);
            this.grp_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown num_obj_number;
        private System.Windows.Forms.Label lbl_obj_number;
        private System.Windows.Forms.Label lbl_obj_type;
        private System.Windows.Forms.NumericUpDown num_obj_type;
        private System.Windows.Forms.TextBox txb_info;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grp_object_data;
        private System.Windows.Forms.GroupBox grp_info;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}