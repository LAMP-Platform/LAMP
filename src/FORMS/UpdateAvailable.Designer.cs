namespace LAMP.FORMS
{
    partial class UpdateAvailable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAvailable));
            this.pic_lamp_icon = new System.Windows.Forms.PictureBox();
            this.txb_update_info = new System.Windows.Forms.TextBox();
            this.txb_features = new System.Windows.Forms.TextBox();
            this.txb_title = new System.Windows.Forms.TextBox();
            this.btn_remind = new System.Windows.Forms.Button();
            this.btn_download = new System.Windows.Forms.Button();
            this.lbl_features = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_lamp_icon)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_lamp_icon
            // 
            this.pic_lamp_icon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pic_lamp_icon.BackgroundImage")));
            this.pic_lamp_icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pic_lamp_icon.Location = new System.Drawing.Point(118, 12);
            this.pic_lamp_icon.Name = "pic_lamp_icon";
            this.pic_lamp_icon.Size = new System.Drawing.Size(128, 128);
            this.pic_lamp_icon.TabIndex = 0;
            this.pic_lamp_icon.TabStop = false;
            // 
            // txb_update_info
            // 
            this.txb_update_info.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_update_info.Location = new System.Drawing.Point(85, 192);
            this.txb_update_info.Multiline = true;
            this.txb_update_info.Name = "txb_update_info";
            this.txb_update_info.ReadOnly = true;
            this.txb_update_info.Size = new System.Drawing.Size(198, 84);
            this.txb_update_info.TabIndex = 2;
            this.txb_update_info.Text = "A new version of LAMP is available.\r\n\r\nIt is reccommended that you update your LA" +
    "MP to get access to new features and bug fixes!";
            this.txb_update_info.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txb_features
            // 
            this.txb_features.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txb_features.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txb_features.Location = new System.Drawing.Point(12, 307);
            this.txb_features.Multiline = true;
            this.txb_features.Name = "txb_features";
            this.txb_features.ReadOnly = true;
            this.txb_features.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txb_features.Size = new System.Drawing.Size(342, 175);
            this.txb_features.TabIndex = 3;
            this.txb_features.Text = " - Feature 1\r\n - Feature 2\r\n    etc\r\n";
            // 
            // txb_title
            // 
            this.txb_title.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_title.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.txb_title.Location = new System.Drawing.Point(12, 146);
            this.txb_title.Multiline = true;
            this.txb_title.Name = "txb_title";
            this.txb_title.ReadOnly = true;
            this.txb_title.Size = new System.Drawing.Size(342, 40);
            this.txb_title.TabIndex = 4;
            this.txb_title.Text = "Version Nr";
            this.txb_title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_remind
            // 
            this.btn_remind.Location = new System.Drawing.Point(140, 488);
            this.btn_remind.Name = "btn_remind";
            this.btn_remind.Size = new System.Drawing.Size(104, 23);
            this.btn_remind.TabIndex = 5;
            this.btn_remind.Text = "Remind me later";
            this.btn_remind.UseVisualStyleBackColor = true;
            this.btn_remind.Click += new System.EventHandler(this.btn_remind_Click);
            // 
            // btn_download
            // 
            this.btn_download.Location = new System.Drawing.Point(250, 488);
            this.btn_download.Name = "btn_download";
            this.btn_download.Size = new System.Drawing.Size(104, 23);
            this.btn_download.TabIndex = 6;
            this.btn_download.Text = "Download now";
            this.btn_download.UseVisualStyleBackColor = true;
            this.btn_download.Click += new System.EventHandler(this.btn_download_Click);
            // 
            // lbl_features
            // 
            this.lbl_features.AutoSize = true;
            this.lbl_features.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_features.Location = new System.Drawing.Point(12, 279);
            this.lbl_features.Name = "lbl_features";
            this.lbl_features.Size = new System.Drawing.Size(92, 25);
            this.lbl_features.TabIndex = 7;
            this.lbl_features.Text = "Features:";
            // 
            // UpdateAvailable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 518);
            this.Controls.Add(this.lbl_features);
            this.Controls.Add(this.btn_download);
            this.Controls.Add(this.btn_remind);
            this.Controls.Add(this.txb_title);
            this.Controls.Add(this.txb_features);
            this.Controls.Add(this.txb_update_info);
            this.Controls.Add(this.pic_lamp_icon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UpdateAvailable";
            this.Text = "Update Available";
            ((System.ComponentModel.ISupportInitialize)(this.pic_lamp_icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_lamp_icon;
        private System.Windows.Forms.TextBox txb_update_info;
        private System.Windows.Forms.TextBox txb_features;
        private System.Windows.Forms.TextBox txb_title;
        private System.Windows.Forms.Button btn_remind;
        private System.Windows.Forms.Button btn_download;
        private System.Windows.Forms.Label lbl_features;
    }
}