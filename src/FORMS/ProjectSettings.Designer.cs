namespace LAMP.FORMS
{
    partial class ProjectSettings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectSettings));
            this.grp_compiler = new System.Windows.Forms.GroupBox();
            this.chb_rmv_mt_o_list = new System.Windows.Forms.CheckBox();
            this.tlt_info = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_tileset_usage = new System.Windows.Forms.GroupBox();
            this.rbt_use_tilesets = new System.Windows.Forms.RadioButton();
            this.rbt_use_offsets = new System.Windows.Forms.RadioButton();
            this.grp_compiler.SuspendLayout();
            this.grp_tileset_usage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_compiler
            // 
            this.grp_compiler.Controls.Add(this.chb_rmv_mt_o_list);
            this.grp_compiler.Location = new System.Drawing.Point(12, 12);
            this.grp_compiler.Name = "grp_compiler";
            this.grp_compiler.Size = new System.Drawing.Size(262, 50);
            this.grp_compiler.TabIndex = 0;
            this.grp_compiler.TabStop = false;
            this.grp_compiler.Text = "Compiling";
            // 
            // chb_rmv_mt_o_list
            // 
            this.chb_rmv_mt_o_list.AutoSize = true;
            this.chb_rmv_mt_o_list.Location = new System.Drawing.Point(6, 22);
            this.chb_rmv_mt_o_list.Name = "chb_rmv_mt_o_list";
            this.chb_rmv_mt_o_list.Size = new System.Drawing.Size(139, 19);
            this.chb_rmv_mt_o_list.TabIndex = 0;
            this.chb_rmv_mt_o_list.Text = "Optimise Object Data";
            this.tlt_info.SetToolTip(this.chb_rmv_mt_o_list, "If the object data gets optimised, it is reccommended\r\nto use the HEX tweak that " +
        "changes vertical object\r\nloading!");
            this.chb_rmv_mt_o_list.UseVisualStyleBackColor = true;
            this.chb_rmv_mt_o_list.CheckedChanged += new System.EventHandler(this.chb_rmv_mt_o_list_CheckedChanged);
            // 
            // tlt_info
            // 
            this.tlt_info.AutoPopDelay = 5000;
            this.tlt_info.InitialDelay = 300;
            this.tlt_info.ReshowDelay = 100;
            this.tlt_info.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tlt_info.ToolTipTitle = "Info";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 159);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(284, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // grp_tileset_usage
            // 
            this.grp_tileset_usage.Controls.Add(this.rbt_use_tilesets);
            this.grp_tileset_usage.Controls.Add(this.rbt_use_offsets);
            this.grp_tileset_usage.Location = new System.Drawing.Point(12, 68);
            this.grp_tileset_usage.Name = "grp_tileset_usage";
            this.grp_tileset_usage.Size = new System.Drawing.Size(262, 77);
            this.grp_tileset_usage.TabIndex = 2;
            this.grp_tileset_usage.TabStop = false;
            this.grp_tileset_usage.Text = "Tileset Usage";
            // 
            // rbt_use_tilesets
            // 
            this.rbt_use_tilesets.AutoSize = true;
            this.rbt_use_tilesets.Location = new System.Drawing.Point(6, 47);
            this.rbt_use_tilesets.Name = "rbt_use_tilesets";
            this.rbt_use_tilesets.Size = new System.Drawing.Size(141, 19);
            this.rbt_use_tilesets.TabIndex = 1;
            this.rbt_use_tilesets.Text = "Use Tilesets if possible";
            this.rbt_use_tilesets.UseVisualStyleBackColor = true;
            this.rbt_use_tilesets.CheckedChanged += new System.EventHandler(this.rbt_use_tilesets_CheckedChanged);
            // 
            // rbt_use_offsets
            // 
            this.rbt_use_offsets.AutoSize = true;
            this.rbt_use_offsets.Checked = true;
            this.rbt_use_offsets.Location = new System.Drawing.Point(6, 22);
            this.rbt_use_offsets.Name = "rbt_use_offsets";
            this.rbt_use_offsets.Size = new System.Drawing.Size(225, 19);
            this.rbt_use_offsets.TabIndex = 0;
            this.rbt_use_offsets.TabStop = true;
            this.rbt_use_offsets.Text = "Use direct graphical Offsets if possible";
            this.rbt_use_offsets.UseVisualStyleBackColor = true;
            this.rbt_use_offsets.CheckedChanged += new System.EventHandler(this.rbt_use_offsets_CheckedChanged);
            // 
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.grp_tileset_usage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_compiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "ProjectSettings";
            this.Text = "Project Settings";
            this.grp_compiler.ResumeLayout(false);
            this.grp_compiler.PerformLayout();
            this.grp_tileset_usage.ResumeLayout(false);
            this.grp_tileset_usage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_compiler;
        private System.Windows.Forms.CheckBox chb_rmv_mt_o_list;
        private System.Windows.Forms.ToolTip tlt_info;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.GroupBox grp_tileset_usage;
        private System.Windows.Forms.RadioButton rbt_use_tilesets;
        private System.Windows.Forms.RadioButton rbt_use_offsets;
    }
}