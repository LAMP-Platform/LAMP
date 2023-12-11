namespace LAMP.Controls
{
    partial class TransitionOpcodeDisplay
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
            pnl_header = new System.Windows.Forms.Panel();
            Seperator = new Other.Seperator();
            btn_expand = new System.Windows.Forms.PictureBox();
            lbl_opcode_name = new System.Windows.Forms.Label();
            btn_move_down = new System.Windows.Forms.Button();
            btn_move_up = new System.Windows.Forms.Button();
            btn_remove_opcode = new System.Windows.Forms.Button();
            pnl_border = new System.Windows.Forms.Panel();
            pnl_parameters = new System.Windows.Forms.Panel();
            pnl_main = new System.Windows.Forms.Panel();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_expand).BeginInit();
            pnl_border.SuspendLayout();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_remove_opcode);
            pnl_header.Controls.Add(btn_move_down);
            pnl_header.Controls.Add(Seperator);
            pnl_header.Controls.Add(btn_move_up);
            pnl_header.Controls.Add(btn_expand);
            pnl_header.Controls.Add(lbl_opcode_name);
            pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_header.Location = new System.Drawing.Point(0, 0);
            pnl_header.Margin = new System.Windows.Forms.Padding(0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new System.Drawing.Size(323, 30);
            pnl_header.TabIndex = 0;
            pnl_header.MouseLeave += lbl_opcode_name_MouseLeave;
            pnl_header.MouseMove += lbl_opcode_name_MouseMove;
            pnl_header.MouseUp += pnl_header_MouseClick;
            // 
            // Seperator
            // 
            Seperator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Seperator.BackColor = System.Drawing.SystemColors.ControlDark;
            Seperator.Location = new System.Drawing.Point(3, 29);
            Seperator.MaximumSize = new System.Drawing.Size(0, 1);
            Seperator.Name = "Seperator";
            Seperator.Size = new System.Drawing.Size(317, 1);
            Seperator.TabIndex = 2;
            Seperator.Visible = false;
            // 
            // btn_expand
            // 
            btn_expand.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_expand.Image = Properties.Resources.ExpandArrow;
            btn_expand.Location = new System.Drawing.Point(297, 3);
            btn_expand.Name = "btn_expand";
            btn_expand.Size = new System.Drawing.Size(23, 23);
            btn_expand.TabIndex = 1;
            btn_expand.TabStop = false;
            btn_expand.MouseLeave += lbl_opcode_name_MouseLeave;
            btn_expand.MouseMove += lbl_opcode_name_MouseMove;
            btn_expand.MouseUp += pnl_header_MouseClick;
            // 
            // lbl_opcode_name
            // 
            lbl_opcode_name.AutoSize = true;
            lbl_opcode_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_opcode_name.Location = new System.Drawing.Point(81, 3);
            lbl_opcode_name.Name = "lbl_opcode_name";
            lbl_opcode_name.Size = new System.Drawing.Size(211, 21);
            lbl_opcode_name.TabIndex = 0;
            lbl_opcode_name.Text = "Name of Transition Opcode";
            lbl_opcode_name.MouseLeave += lbl_opcode_name_MouseLeave;
            lbl_opcode_name.MouseMove += lbl_opcode_name_MouseMove;
            lbl_opcode_name.MouseUp += pnl_header_MouseClick;
            // 
            // btn_move_down
            // 
            btn_move_down.Image = Properties.Resources.ArrowDown;
            btn_move_down.Location = new System.Drawing.Point(29, 3);
            btn_move_down.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            btn_move_down.Name = "btn_move_down";
            btn_move_down.Size = new System.Drawing.Size(23, 23);
            btn_move_down.TabIndex = 2;
            btn_move_down.UseVisualStyleBackColor = true;
            btn_move_down.Click += btn_move_down_Click;
            // 
            // btn_move_up
            // 
            btn_move_up.Image = Properties.Resources.ArrowUp;
            btn_move_up.Location = new System.Drawing.Point(55, 3);
            btn_move_up.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            btn_move_up.Name = "btn_move_up";
            btn_move_up.Size = new System.Drawing.Size(23, 23);
            btn_move_up.TabIndex = 1;
            btn_move_up.UseVisualStyleBackColor = true;
            btn_move_up.Click += btn_move_up_Click;
            // 
            // btn_remove_opcode
            // 
            btn_remove_opcode.Image = Properties.Resources.Remove;
            btn_remove_opcode.Location = new System.Drawing.Point(3, 3);
            btn_remove_opcode.Name = "btn_remove_opcode";
            btn_remove_opcode.Size = new System.Drawing.Size(23, 23);
            btn_remove_opcode.TabIndex = 0;
            btn_remove_opcode.UseVisualStyleBackColor = true;
            btn_remove_opcode.Click += btn_remove_opcode_Click;
            // 
            // pnl_border
            // 
            pnl_border.AutoSize = true;
            pnl_border.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_border.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnl_border.Controls.Add(pnl_parameters);
            pnl_border.Controls.Add(pnl_header);
            pnl_border.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_border.Location = new System.Drawing.Point(0, 0);
            pnl_border.Name = "pnl_border";
            pnl_border.Size = new System.Drawing.Size(325, 32);
            pnl_border.TabIndex = 3;
            // 
            // pnl_parameters
            // 
            pnl_parameters.AutoSize = true;
            pnl_parameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_parameters.Location = new System.Drawing.Point(0, 30);
            pnl_parameters.Name = "pnl_parameters";
            pnl_parameters.Size = new System.Drawing.Size(323, 0);
            pnl_parameters.TabIndex = 3;
            pnl_parameters.Visible = false;
            // 
            // pnl_main
            // 
            pnl_main.AutoSize = true;
            pnl_main.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_main.Controls.Add(pnl_border);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            pnl_main.Size = new System.Drawing.Size(325, 38);
            pnl_main.TabIndex = 4;
            // 
            // TransitionOpcodeDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            Controls.Add(pnl_main);
            Margin = new System.Windows.Forms.Padding(0);
            MinimumSize = new System.Drawing.Size(325, 30);
            Name = "TransitionOpcodeDisplay";
            Size = new System.Drawing.Size(325, 38);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_expand).EndInit();
            pnl_border.ResumeLayout(false);
            pnl_border.PerformLayout();
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox btn_expand;
        private System.Windows.Forms.Label lbl_opcode_name;
        private System.Windows.Forms.Button btn_remove_opcode;
        private Other.Seperator Seperator;
        private System.Windows.Forms.Panel pnl_border;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_parameters;
        private System.Windows.Forms.Button btn_move_down;
        private System.Windows.Forms.Button btn_move_up;
    }
}
