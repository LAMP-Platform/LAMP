namespace LAMP.FORMS
{
    partial class CollisionEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollisionEditor));
            pnl_main = new System.Windows.Forms.SplitContainer();
            txb_offset = new System.Windows.Forms.TextBox();
            cbb_collision_table = new System.Windows.Forms.ComboBox();
            lbl_gfx = new System.Windows.Forms.Label();
            lbl_table = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pnl_main).BeginInit();
            pnl_main.Panel1.SuspendLayout();
            pnl_main.SuspendLayout();
            SuspendLayout();
            // 
            // pnl_main
            // 
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            // 
            // pnl_main.Panel1
            // 
            pnl_main.Panel1.Controls.Add(txb_offset);
            pnl_main.Panel1.Controls.Add(cbb_collision_table);
            pnl_main.Panel1.Controls.Add(lbl_gfx);
            pnl_main.Panel1.Controls.Add(lbl_table);
            pnl_main.Size = new System.Drawing.Size(800, 450);
            pnl_main.SplitterDistance = 197;
            pnl_main.TabIndex = 0;
            // 
            // txb_offset
            // 
            txb_offset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            txb_offset.Location = new System.Drawing.Point(112, 41);
            txb_offset.Name = "txb_offset";
            txb_offset.Size = new System.Drawing.Size(73, 23);
            txb_offset.TabIndex = 27;
            // 
            // cbb_collision_table
            // 
            cbb_collision_table.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            cbb_collision_table.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_collision_table.FormattingEnabled = true;
            cbb_collision_table.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7" });
            cbb_collision_table.Location = new System.Drawing.Point(112, 12);
            cbb_collision_table.Name = "cbb_collision_table";
            cbb_collision_table.Size = new System.Drawing.Size(73, 23);
            cbb_collision_table.TabIndex = 20;
            // 
            // lbl_gfx
            // 
            lbl_gfx.AutoSize = true;
            lbl_gfx.Location = new System.Drawing.Point(12, 44);
            lbl_gfx.Name = "lbl_gfx";
            lbl_gfx.Size = new System.Drawing.Size(94, 15);
            lbl_gfx.TabIndex = 1;
            lbl_gfx.Text = "Graphic Overlay:";
            // 
            // lbl_table
            // 
            lbl_table.AutoSize = true;
            lbl_table.Location = new System.Drawing.Point(12, 15);
            lbl_table.Name = "lbl_table";
            lbl_table.Size = new System.Drawing.Size(86, 15);
            lbl_table.TabIndex = 0;
            lbl_table.Text = "Collision Table:";
            // 
            // CollisionEditor
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pnl_main);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "CollisionEditor";
            Text = "Collision Editor";
            pnl_main.Panel1.ResumeLayout(false);
            pnl_main.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pnl_main).EndInit();
            pnl_main.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.SplitContainer pnl_main;
        private System.Windows.Forms.Label lbl_table;
        private System.Windows.Forms.Label lbl_gfx;
        private System.Windows.Forms.ComboBox cbb_collision_table;
        private System.Windows.Forms.TextBox txb_offset;
    }
}