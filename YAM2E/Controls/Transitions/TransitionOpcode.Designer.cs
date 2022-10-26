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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransitionOpcode));
            this.pnlBasicInfo = new System.Windows.Forms.Panel();
            this.pbxCollapse = new System.Windows.Forms.PictureBox();
            this.pbxExpand = new System.Windows.Forms.PictureBox();
            this.seperator = new LAMP.Controls.Other.Seperator();
            this.lblOpcodeName = new System.Windows.Forms.Label();
            this.pnlOperands = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRemoveOpcode = new System.Windows.Forms.Button();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.pnlBasicInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCollapse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExpand)).BeginInit();
            this.pnlEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBasicInfo
            // 
            this.pnlBasicInfo.BackColor = System.Drawing.SystemColors.Control;
            this.pnlBasicInfo.Controls.Add(this.pbxCollapse);
            this.pnlBasicInfo.Controls.Add(this.pbxExpand);
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
            // pbxCollapse
            // 
            this.pbxCollapse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxCollapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxCollapse.BackgroundImage")));
            this.pbxCollapse.Location = new System.Drawing.Point(256, 1);
            this.pbxCollapse.Name = "pbxCollapse";
            this.pbxCollapse.Size = new System.Drawing.Size(24, 24);
            this.pbxCollapse.TabIndex = 3;
            this.pbxCollapse.TabStop = false;
            this.pbxCollapse.Visible = false;
            this.pbxCollapse.Click += new System.EventHandler(this.pnlBasicInfo_Click);
            this.pbxCollapse.MouseLeave += new System.EventHandler(this.pnlBasicInfo_MouseLeave);
            this.pbxCollapse.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBasicInfo_MouseMove);
            // 
            // pbxExpand
            // 
            this.pbxExpand.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pbxExpand.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxExpand.BackgroundImage")));
            this.pbxExpand.Location = new System.Drawing.Point(256, 1);
            this.pbxExpand.Name = "pbxExpand";
            this.pbxExpand.Size = new System.Drawing.Size(24, 24);
            this.pbxExpand.TabIndex = 2;
            this.pbxExpand.TabStop = false;
            this.pbxExpand.Click += new System.EventHandler(this.pnlBasicInfo_Click);
            this.pbxExpand.MouseLeave += new System.EventHandler(this.pnlBasicInfo_MouseLeave);
            this.pbxExpand.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlBasicInfo_MouseMove);
            // 
            // seperator
            // 
            this.seperator.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            this.pnlOperands.Location = new System.Drawing.Point(0, 0);
            this.pnlOperands.Margin = new System.Windows.Forms.Padding(0);
            this.pnlOperands.Name = "pnlOperands";
            this.pnlOperands.Size = new System.Drawing.Size(0, 0);
            this.pnlOperands.TabIndex = 1;
            this.pnlOperands.WrapContents = false;
            // 
            // btnRemoveOpcode
            // 
            this.btnRemoveOpcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveOpcode.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveOpcode.Image")));
            this.btnRemoveOpcode.Location = new System.Drawing.Point(256, 2);
            this.btnRemoveOpcode.Name = "btnRemoveOpcode";
            this.btnRemoveOpcode.Size = new System.Drawing.Size(24, 23);
            this.btnRemoveOpcode.TabIndex = 2;
            this.btnRemoveOpcode.UseVisualStyleBackColor = true;
            this.btnRemoveOpcode.Click += new System.EventHandler(this.btnRemoveOpcode_Click);
            // 
            // pnlEdit
            // 
            this.pnlEdit.AutoSize = true;
            this.pnlEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlEdit.Controls.Add(this.btnRemoveOpcode);
            this.pnlEdit.Controls.Add(this.pnlOperands);
            this.pnlEdit.Location = new System.Drawing.Point(0, 26);
            this.pnlEdit.Margin = new System.Windows.Forms.Padding(0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(283, 28);
            this.pnlEdit.TabIndex = 2;
            this.pnlEdit.Visible = false;
            // 
            // TransitionOpcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.pnlBasicInfo);
            this.Name = "TransitionOpcode";
            this.Size = new System.Drawing.Size(283, 54);
            this.pnlBasicInfo.ResumeLayout(false);
            this.pnlBasicInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCollapse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxExpand)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBasicInfo;
        private System.Windows.Forms.FlowLayoutPanel pnlOperands;
        public System.Windows.Forms.Label lblOpcodeName;
        private Other.Seperator seperator;
        private System.Windows.Forms.PictureBox pbxCollapse;
        private System.Windows.Forms.PictureBox pbxExpand;
        private System.Windows.Forms.Button btnRemoveOpcode;
        private System.Windows.Forms.Panel pnlEdit;
    }
}
