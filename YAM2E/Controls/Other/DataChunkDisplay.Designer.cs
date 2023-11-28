namespace LAMP.Controls.Other
{
    partial class DataChunkDisplay
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
            lbl_contains = new System.Windows.Forms.Label();
            btn_preview = new System.Windows.Forms.Button();
            btn_export = new System.Windows.Forms.Button();
            chb_include = new System.Windows.Forms.CheckBox();
            btn_remove = new System.Windows.Forms.Button();
            seperator = new Seperator();
            lbl_range = new System.Windows.Forms.Label();
            lbl_type = new System.Windows.Forms.Label();
            toolTip = new System.Windows.Forms.ToolTip(components);
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.BackColor = System.Drawing.SystemColors.Control;
            pnl_main.Controls.Add(lbl_contains);
            pnl_main.Controls.Add(btn_preview);
            pnl_main.Controls.Add(btn_export);
            pnl_main.Controls.Add(chb_include);
            pnl_main.Controls.Add(btn_remove);
            pnl_main.Controls.Add(seperator);
            pnl_main.Controls.Add(lbl_range);
            pnl_main.Controls.Add(lbl_type);
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(1, 1);
            pnl_main.Name = "pnl_main";
            pnl_main.Size = new System.Drawing.Size(294, 113);
            pnl_main.TabIndex = 0;
            // 
            // lbl_contains
            // 
            lbl_contains.AutoSize = true;
            lbl_contains.Location = new System.Drawing.Point(7, 56);
            lbl_contains.Name = "lbl_contains";
            lbl_contains.Size = new System.Drawing.Size(126, 15);
            lbl_contains.TabIndex = 7;
            lbl_contains.Text = "Not used in any Tileset";
            // 
            // btn_preview
            // 
            btn_preview.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_preview.Image = Properties.Resources.FilePreview;
            btn_preview.Location = new System.Drawing.Point(264, 53);
            btn_preview.Name = "btn_preview";
            btn_preview.Size = new System.Drawing.Size(23, 23);
            btn_preview.TabIndex = 6;
            btn_preview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTip.SetToolTip(btn_preview, "Preview");
            btn_preview.UseVisualStyleBackColor = true;
            btn_preview.Visible = false;
            btn_preview.Click += btn_preview_Click;
            // 
            // btn_export
            // 
            btn_export.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            btn_export.Image = Properties.Resources.Export;
            btn_export.Location = new System.Drawing.Point(183, 85);
            btn_export.Name = "btn_export";
            btn_export.Size = new System.Drawing.Size(23, 23);
            btn_export.TabIndex = 5;
            btn_export.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            toolTip.SetToolTip(btn_export, "Export");
            btn_export.UseVisualStyleBackColor = true;
            // 
            // chb_include
            // 
            chb_include.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            chb_include.AutoSize = true;
            chb_include.Location = new System.Drawing.Point(7, 88);
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
            btn_remove.Location = new System.Drawing.Point(212, 85);
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
            seperator.Location = new System.Drawing.Point(7, 78);
            seperator.MaximumSize = new System.Drawing.Size(0, 1);
            seperator.Name = "seperator";
            seperator.Size = new System.Drawing.Size(280, 1);
            seperator.TabIndex = 2;
            // 
            // lbl_range
            // 
            lbl_range.AutoSize = true;
            lbl_range.Location = new System.Drawing.Point(7, 34);
            lbl_range.Name = "lbl_range";
            lbl_range.Size = new System.Drawing.Size(56, 15);
            lbl_range.TabIndex = 1;
            lbl_range.Text = "Location:";
            // 
            // lbl_type
            // 
            lbl_type.AutoSize = true;
            lbl_type.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            lbl_type.Location = new System.Drawing.Point(3, 0);
            lbl_type.Name = "lbl_type";
            lbl_type.Size = new System.Drawing.Size(54, 25);
            lbl_type.TabIndex = 0;
            lbl_type.Text = "Type";
            // 
            // DataChunkDisplay
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Black;
            Controls.Add(pnl_main);
            MinimumSize = new System.Drawing.Size(296, 92);
            Name = "DataChunkDisplay";
            Padding = new System.Windows.Forms.Padding(1);
            Size = new System.Drawing.Size(296, 115);
            pnl_main.ResumeLayout(false);
            pnl_main.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Label lbl_range;
        private System.Windows.Forms.Label lbl_type;
        private Seperator seperator;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.CheckBox chb_include;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button btn_preview;
        private System.Windows.Forms.Label lbl_contains;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
