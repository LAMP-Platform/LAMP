namespace LAMP.Controls.Other
{
    partial class RecentFileDisplay
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
            components = new System.ComponentModel.Container();
            pnl_main = new System.Windows.Forms.Panel();
            btn_pin = new System.Windows.Forms.Button();
            lbl_path = new System.Windows.Forms.Label();
            lbl_title = new System.Windows.Forms.Label();
            ctx_menu = new System.Windows.Forms.ContextMenuStrip(components);
            btn_open_path = new System.Windows.Forms.ToolStripMenuItem();
            pnl_main.SuspendLayout();
            ctx_menu.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = System.Drawing.SystemColors.Control;
            pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_main.ContextMenuStrip = ctx_menu;
            pnl_main.Controls.Add(btn_pin);
            pnl_main.Controls.Add(lbl_path);
            pnl_main.Controls.Add(lbl_title);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new System.Drawing.Size(472, 60);
            pnl_main.TabIndex = 0;
            pnl_main.MouseClick += lbl_title_Click;
            pnl_main.MouseEnter += pnl_main_MouseEnter;
            pnl_main.MouseLeave += pnl_main_MouseLeave;
            // 
            // btn_pin
            // 
            btn_pin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_pin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_pin.Image = Properties.Resources.pin;
            btn_pin.Location = new System.Drawing.Point(421, 10);
            btn_pin.Name = "btn_pin";
            btn_pin.Size = new System.Drawing.Size(40, 40);
            btn_pin.TabIndex = 2;
            btn_pin.UseVisualStyleBackColor = true;
            btn_pin.Click += btn_pin_Click;
            // 
            // lbl_path
            // 
            lbl_path.AutoSize = true;
            lbl_path.ContextMenuStrip = ctx_menu;
            lbl_path.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lbl_path.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            lbl_path.Location = new System.Drawing.Point(7, 32);
            lbl_path.Name = "lbl_path";
            lbl_path.Size = new System.Drawing.Size(263, 17);
            lbl_path.TabIndex = 1;
            lbl_path.Text = "E:\\METROID\\Metroid 2 RoS\\April Fools hack";
            lbl_path.MouseClick += lbl_title_Click;
            lbl_path.MouseEnter += pnl_main_MouseEnter;
            lbl_path.MouseLeave += pnl_main_MouseLeave;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.ContextMenuStrip = ctx_menu;
            lbl_title.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_title.Location = new System.Drawing.Point(3, 0);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new System.Drawing.Size(76, 32);
            lbl_title.TabIndex = 0;
            lbl_title.Text = "Sm 2\r\n";
            lbl_title.MouseClick += lbl_title_Click;
            lbl_title.MouseEnter += pnl_main_MouseEnter;
            lbl_title.MouseLeave += pnl_main_MouseLeave;
            // 
            // ctx_menu
            // 
            ctx_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { btn_open_path });
            ctx_menu.Name = "ctx_menu";
            ctx_menu.Size = new System.Drawing.Size(190, 26);
            // 
            // btn_open_path
            // 
            btn_open_path.Name = "btn_open_path";
            btn_open_path.Size = new System.Drawing.Size(189, 22);
            btn_open_path.Text = "Open Path in Explorer";
            btn_open_path.Click += btn_open_path_Click;
            // 
            // RecentFileDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(pnl_main);
            Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            Name = "RecentFileDisplay";
            Size = new System.Drawing.Size(472, 60);
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            ctx_menu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_path;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_pin;
        private System.Windows.Forms.ContextMenuStrip ctx_menu;
        private System.Windows.Forms.ToolStripMenuItem btn_open_path;
    }
}
