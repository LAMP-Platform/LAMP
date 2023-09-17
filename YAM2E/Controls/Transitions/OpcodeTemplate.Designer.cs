namespace LAMP.Controls.Transitions
{
    partial class OpcodeTemplate
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
            pnl_main = new System.Windows.Forms.Panel();
            lbl_opcode_title = new System.Windows.Forms.Label();
            pnl_add_display = new System.Windows.Forms.Panel();
            pcb_add = new System.Windows.Forms.PictureBox();
            pnl_main.SuspendLayout();
            pnl_add_display.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcb_add).BeginInit();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.AutoSize = true;
            pnl_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_main.Controls.Add(lbl_opcode_title);
            pnl_main.Controls.Add(pnl_add_display);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(1);
            pnl_main.Size = new System.Drawing.Size(200, 27);
            pnl_main.TabIndex = 0;
            pnl_main.MouseLeave += pnl_main_MouseLeave;
            pnl_main.MouseMove += pnl_main_MouseMove;
            pnl_main.MouseUp += pnl_main_MouseUp;
            // 
            // lbl_opcode_title
            // 
            lbl_opcode_title.AutoSize = true;
            lbl_opcode_title.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_opcode_title.Location = new System.Drawing.Point(1, 1);
            lbl_opcode_title.Name = "lbl_opcode_title";
            lbl_opcode_title.Size = new System.Drawing.Size(38, 20);
            lbl_opcode_title.TabIndex = 2;
            lbl_opcode_title.Text = "Title";
            lbl_opcode_title.MouseLeave += pnl_main_MouseLeave;
            lbl_opcode_title.MouseMove += pnl_main_MouseMove;
            lbl_opcode_title.MouseUp += pnl_main_MouseUp;
            // 
            // pnl_add_display
            // 
            pnl_add_display.AutoSize = true;
            pnl_add_display.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_add_display.Controls.Add(pcb_add);
            pnl_add_display.Dock = System.Windows.Forms.DockStyle.Right;
            pnl_add_display.Location = new System.Drawing.Point(174, 1);
            pnl_add_display.Name = "pnl_add_display";
            pnl_add_display.Size = new System.Drawing.Size(23, 23);
            pnl_add_display.TabIndex = 1;
            // 
            // pcb_add
            // 
            pcb_add.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            pcb_add.BackgroundImage = Properties.Resources.Add;
            pcb_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            pcb_add.Location = new System.Drawing.Point(0, 0);
            pcb_add.Name = "pcb_add";
            pcb_add.Size = new System.Drawing.Size(23, 23);
            pcb_add.TabIndex = 0;
            pcb_add.TabStop = false;
            pcb_add.MouseLeave += pnl_main_MouseLeave;
            pcb_add.MouseMove += pnl_main_MouseMove;
            pcb_add.MouseUp += pnl_main_MouseUp;
            // 
            // OpcodeTemplate
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(pnl_main);
            MinimumSize = new System.Drawing.Size(200, 30);
            Name = "OpcodeTemplate";
            Padding = new System.Windows.Forms.Padding(0, 0, 0, 3);
            Size = new System.Drawing.Size(200, 30);
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            pnl_add_display.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcb_add).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_add_display;
        private System.Windows.Forms.PictureBox pcb_add;
        private System.Windows.Forms.Label lbl_opcode_title;
    }
}
