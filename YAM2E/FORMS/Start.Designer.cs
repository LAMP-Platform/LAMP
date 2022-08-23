namespace LAMP.FORMS
{
    partial class Start
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.lbl_rom_path = new System.Windows.Forms.Label();
            this.txb_rom_path = new System.Windows.Forms.TextBox();
            this.btn_select_rom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rom_path
            // 
            this.lbl_rom_path.AutoSize = true;
            this.lbl_rom_path.Location = new System.Drawing.Point(12, 9);
            this.lbl_rom_path.Name = "lbl_rom_path";
            this.lbl_rom_path.Size = new System.Drawing.Size(64, 15);
            this.lbl_rom_path.TabIndex = 0;
            this.lbl_rom_path.Text = "ROM Path:";
            // 
            // txb_rom_path
            // 
            this.txb_rom_path.Location = new System.Drawing.Point(82, 6);
            this.txb_rom_path.Name = "txb_rom_path";
            this.txb_rom_path.Size = new System.Drawing.Size(234, 23);
            this.txb_rom_path.TabIndex = 1;
            this.txb_rom_path.TextChanged += new System.EventHandler(this.txb_rom_path_TextChanged);
            // 
            // btn_select_rom
            // 
            this.btn_select_rom.Image = ((System.Drawing.Image)(resources.GetObject("btn_select_rom.Image")));
            this.btn_select_rom.Location = new System.Drawing.Point(322, 6);
            this.btn_select_rom.Name = "btn_select_rom";
            this.btn_select_rom.Size = new System.Drawing.Size(23, 23);
            this.btn_select_rom.TabIndex = 2;
            this.btn_select_rom.UseVisualStyleBackColor = true;
            this.btn_select_rom.Click += new System.EventHandler(this.btn_select_rom_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 36);
            this.Controls.Add(this.btn_select_rom);
            this.Controls.Add(this.txb_rom_path);
            this.Controls.Add(this.lbl_rom_path);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(370, 75);
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select a vanilla ROM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rom_path;
        private System.Windows.Forms.TextBox txb_rom_path;
        private System.Windows.Forms.Button btn_select_rom;
    }
}