namespace LAMP.Controls.Other
{
    partial class TweakDisplay
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
            pnl_head = new System.Windows.Forms.Panel();
            btn_edit = new System.Windows.Forms.Button();
            lbl_name = new System.Windows.Forms.Label();
            btn_export = new System.Windows.Forms.Button();
            chb_include = new System.Windows.Forms.CheckBox();
            btn_remove = new System.Windows.Forms.Button();
            seperator = new Seperator();
            toolTip = new System.Windows.Forms.ToolTip(components);
            pnl_foot = new System.Windows.Forms.Panel();
            txb_description = new System.Windows.Forms.TextBox();
            pnl_main = new System.Windows.Forms.Panel();
            pnl_head.SuspendLayout();
            pnl_foot.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_head
            // 
            pnl_head.BackColor = System.Drawing.SystemColors.Control;
            pnl_head.Controls.Add(btn_edit);
            pnl_head.Controls.Add(lbl_name);
            pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_head.Location = new System.Drawing.Point(1, 1);
            pnl_head.Name = "pnl_head";
            pnl_head.Size = new System.Drawing.Size(288, 32);
            pnl_head.TabIndex = 0;
            // 
            // btn_edit
            // 
            btn_edit.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            btn_edit.Image = Properties.Resources.PenOneSelected;
            btn_edit.Location = new System.Drawing.Point(258, 4);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(23, 23);
            btn_edit.TabIndex = 6;
            btn_edit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTip.SetToolTip(btn_edit, "Edit");
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Visible = false;
            // 
            // lbl_name
            // 
            lbl_name.AutoSize = true;
            lbl_name.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_name.Location = new System.Drawing.Point(3, 0);
            lbl_name.Name = "lbl_name";
            lbl_name.Size = new System.Drawing.Size(54, 25);
            lbl_name.TabIndex = 0;
            lbl_name.Text = "Type";
            // 
            // btn_export
            // 
            btn_export.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_export.Image = Properties.Resources.Export;
            btn_export.Location = new System.Drawing.Point(177, 7);
            btn_export.Name = "btn_export";
            btn_export.Size = new System.Drawing.Size(23, 23);
            btn_export.TabIndex = 5;
            btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTip.SetToolTip(btn_export, "Export");
            btn_export.UseVisualStyleBackColor = true;
            btn_export.Click += btn_export_Click;
            // 
            // chb_include
            // 
            chb_include.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chb_include.AutoSize = true;
            chb_include.Location = new System.Drawing.Point(7, 10);
            chb_include.Name = "chb_include";
            chb_include.Size = new System.Drawing.Size(65, 19);
            chb_include.TabIndex = 4;
            chb_include.Text = "Include";
            chb_include.UseVisualStyleBackColor = true;
            chb_include.CheckedChanged += chb_include_CheckedChanged;
            // 
            // btn_remove
            // 
            btn_remove.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_remove.Image = Properties.Resources.Remove;
            btn_remove.Location = new System.Drawing.Point(206, 7);
            btn_remove.Name = "btn_remove";
            btn_remove.Size = new System.Drawing.Size(75, 23);
            btn_remove.TabIndex = 3;
            btn_remove.Text = "Remove";
            btn_remove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_remove.UseVisualStyleBackColor = true;
            btn_remove.Click += btn_remove_Click;
            // 
            // seperator
            // 
            seperator.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            seperator.BackColor = System.Drawing.SystemColors.ControlDark;
            seperator.Location = new System.Drawing.Point(7, 1);
            seperator.MaximumSize = new System.Drawing.Size(0, 1);
            seperator.Name = "seperator";
            seperator.Size = new System.Drawing.Size(274, 1);
            seperator.TabIndex = 2;
            // 
            // pnl_foot
            // 
            pnl_foot.BackColor = System.Drawing.SystemColors.Control;
            pnl_foot.Controls.Add(btn_remove);
            pnl_foot.Controls.Add(btn_export);
            pnl_foot.Controls.Add(seperator);
            pnl_foot.Controls.Add(chb_include);
            pnl_foot.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_foot.Location = new System.Drawing.Point(1, 61);
            pnl_foot.Name = "pnl_foot";
            pnl_foot.Size = new System.Drawing.Size(288, 33);
            pnl_foot.TabIndex = 2;
            // 
            // txb_description
            // 
            txb_description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txb_description.Dock = System.Windows.Forms.DockStyle.Top;
            txb_description.Enabled = false;
            txb_description.Location = new System.Drawing.Point(1, 33);
            txb_description.Multiline = true;
            txb_description.Name = "txb_description";
            txb_description.ReadOnly = true;
            txb_description.Size = new System.Drawing.Size(288, 28);
            txb_description.TabIndex = 3;
            txb_description.Text = "Description goes here";
            txb_description.TextChanged += txb_description_TextChanged;
            // 
            // pnl_main
            // 
            pnl_main.AutoSize = true;
            pnl_main.BackColor = System.Drawing.SystemColors.Control;
            pnl_main.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_main.Location = new System.Drawing.Point(1, 61);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new System.Drawing.Size(288, 0);
            pnl_main.TabIndex = 4;
            // 
            // TweakDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.Black;
            Controls.Add(pnl_foot);
            Controls.Add(pnl_main);
            Controls.Add(txb_description);
            Controls.Add(pnl_head);
            MinimumSize = new System.Drawing.Size(290, 0);
            Name = "TweakDisplay";
            Padding = new System.Windows.Forms.Padding(1);
            Size = new System.Drawing.Size(290, 95);
            pnl_head.ResumeLayout(false);
            pnl_head.PerformLayout();
            pnl_foot.ResumeLayout(false);
            pnl_foot.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnl_head;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.Label lbl_name;
        private Seperator seperator;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.CheckBox chb_include;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel pnl_foot;
        private System.Windows.Forms.TextBox txb_description;
        private System.Windows.Forms.Panel pnl_main;
    }
}
