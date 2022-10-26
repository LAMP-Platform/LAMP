namespace LAMP.Controls
{
    partial class TransitionOpcode
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
            this.pnlBasicInfo = new System.Windows.Forms.Panel();
            this.seperator = new LAMP.Controls.Other.Seperator();
            this.lblOpcodeName = new System.Windows.Forms.Label();
            this.pnlOperands = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBasicInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasicInfo
            // 
            this.pnlBasicInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBasicInfo.Controls.Add(this.seperator);
            this.pnlBasicInfo.Controls.Add(this.lblOpcodeName);
            this.pnlBasicInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlBasicInfo.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBasicInfo.Name = "pnlBasicInfo";
            this.pnlBasicInfo.Size = new System.Drawing.Size(283, 26);
            this.pnlBasicInfo.TabIndex = 0;
            this.pnlBasicInfo.Click += new System.EventHandler(this.pnlBasicInfo_Click);
            this.pnlBasicInfo.MouseLeave += new System.EventHandler(this.pnlBasicInfo_MouseLeave);
            this.pnlBasicInfo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBasicInfo_MouseMove);
            // 
            // seperator
            // 
            this.seperator.BackColor = System.Drawing.SystemColors.ControlDark;
            this.seperator.Location = new System.Drawing.Point(6, 25);
            this.seperator.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.seperator.MaximumSize = new System.Drawing.Size(0, 1);
            this.seperator.Name = "seperator";
            this.seperator.Size = new System.Drawing.Size(271, 1);
            this.seperator.TabIndex = 1;
            this.seperator.Visible = false;
            // 
            // lblOpcodeName
            // 
            this.lblOpcodeName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblOpcodeName.AutoSize = true;
            this.lblOpcodeName.Location = new System.Drawing.Point(3, 5);
            this.lblOpcodeName.Name = "lblOpcodeName";
            this.lblOpcodeName.Size = new System.Drawing.Size(138, 15);
            this.lblOpcodeName.TabIndex = 0;
            this.lblOpcodeName.Text = "Transition Opcode Name";
            this.lblOpcodeName.Click += new System.EventHandler(this.pnlBasicInfo_Click);
            this.lblOpcodeName.MouseLeave += new System.EventHandler(this.pnlBasicInfo_MouseLeave);
            this.lblOpcodeName.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBasicInfo_MouseMove);
            // 
            // pnlOperands
            // 
            this.pnlOperands.AutoSize = true;
            this.pnlOperands.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlOperands.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.pnlOperands.Location = new System.Drawing.Point(0, 26);
            this.pnlOperands.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperands.Name = "pnlOperands";
            this.pnlOperands.Size = new System.Drawing.Size(0, 0);
            this.pnlOperands.TabIndex = 1;
            this.pnlOperands.Visible = false;
            this.pnlOperands.WrapContents = false;
            // 
            // TransitionOpcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlOperands);
            this.Controls.Add(this.pnlBasicInfo);
            this.Name = "TransitionOpcode";
            this.Size = new System.Drawing.Size(283, 26);
            this.pnlBasicInfo.ResumeLayout(false);
            this.pnlBasicInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasicInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlOperands;
        public System.Windows.Forms.Label lblOpcodeName;
        private Other.Seperator seperator;
    }
}
