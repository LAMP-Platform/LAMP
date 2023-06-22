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
            pnl_parameters = new System.Windows.Forms.FlowLayoutPanel();
            pnl_footer = new System.Windows.Forms.Panel();
            btn_remove_opcode = new System.Windows.Forms.Button();
            pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_expand).BeginInit();
            pnl_footer.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(Seperator);
            pnl_header.Controls.Add(btn_expand);
            pnl_header.Controls.Add(lbl_opcode_name);
            pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_header.Location = new System.Drawing.Point(0, 0);
            pnl_header.Margin = new System.Windows.Forms.Padding(0);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new System.Drawing.Size(248, 30);
            pnl_header.TabIndex = 0;
            // 
            // Seperator
            // 
            Seperator.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            Seperator.BackColor = System.Drawing.SystemColors.ControlDark;
            Seperator.Location = new System.Drawing.Point(3, 29);
            Seperator.MaximumSize = new System.Drawing.Size(0, 1);
            Seperator.Name = "Seperator";
            Seperator.Size = new System.Drawing.Size(242, 1);
            Seperator.TabIndex = 2;
            // 
            // btn_expand
            // 
            btn_expand.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_expand.Image = Properties.Resources.CollapseArrow;
            btn_expand.Location = new System.Drawing.Point(222, 3);
            btn_expand.Name = "btn_expand";
            btn_expand.Size = new System.Drawing.Size(23, 23);
            btn_expand.TabIndex = 1;
            btn_expand.TabStop = false;
            // 
            // lbl_opcode_name
            // 
            lbl_opcode_name.AutoSize = true;
            lbl_opcode_name.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_opcode_name.Location = new System.Drawing.Point(3, 3);
            lbl_opcode_name.Name = "lbl_opcode_name";
            lbl_opcode_name.Size = new System.Drawing.Size(211, 21);
            lbl_opcode_name.TabIndex = 0;
            lbl_opcode_name.Text = "Name of Transition Opcode";
            // 
            // pnl_parameters
            // 
            pnl_parameters.AutoSize = true;
            pnl_parameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            pnl_parameters.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_parameters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            pnl_parameters.Location = new System.Drawing.Point(0, 30);
            pnl_parameters.Margin = new System.Windows.Forms.Padding(0);
            pnl_parameters.Name = "pnl_parameters";
            pnl_parameters.Size = new System.Drawing.Size(248, 29);
            pnl_parameters.TabIndex = 1;
            // 
            // pnl_footer
            // 
            pnl_footer.Controls.Add(btn_remove_opcode);
            pnl_footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_footer.Location = new System.Drawing.Point(0, 30);
            pnl_footer.Name = "pnl_footer";
            pnl_footer.Size = new System.Drawing.Size(248, 29);
            pnl_footer.TabIndex = 2;
            // 
            // btn_remove_opcode
            // 
            btn_remove_opcode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_remove_opcode.Image = Properties.Resources.Remove;
            btn_remove_opcode.Location = new System.Drawing.Point(222, 3);
            btn_remove_opcode.Name = "btn_remove_opcode";
            btn_remove_opcode.Size = new System.Drawing.Size(23, 23);
            btn_remove_opcode.TabIndex = 0;
            btn_remove_opcode.UseVisualStyleBackColor = true;
            // 
            // TransitionOpcode
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Controls.Add(pnl_footer);
            Controls.Add(pnl_parameters);
            Controls.Add(pnl_header);
            Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            MinimumSize = new System.Drawing.Size(250, 30);
            Name = "TransitionOpcode";
            Size = new System.Drawing.Size(248, 59);
            pnl_header.ResumeLayout(false);
            pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_expand).EndInit();
            pnl_footer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.PictureBox btn_expand;
        private System.Windows.Forms.Label lbl_opcode_name;
        private System.Windows.Forms.FlowLayoutPanel pnl_parameters;
        private System.Windows.Forms.Panel pnl_footer;
        private System.Windows.Forms.Button btn_remove_opcode;
        private Other.Seperator Seperator;
    }
}
