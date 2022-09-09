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
            this.grp_compiler.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_compiler
            // 
            this.grp_compiler.Controls.Add(this.chb_rmv_mt_o_list);
            this.grp_compiler.Location = new System.Drawing.Point(12, 12);
            this.grp_compiler.Name = "grp_compiler";
            this.grp_compiler.Size = new System.Drawing.Size(189, 50);
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
            // ProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 76);
            this.Controls.Add(this.grp_compiler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(230, 115);
            this.Name = "ProjectSettings";
            this.Text = "Project Settings";
            this.grp_compiler.ResumeLayout(false);
            this.grp_compiler.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_compiler;
        private System.Windows.Forms.CheckBox chb_rmv_mt_o_list;
        private System.Windows.Forms.ToolTip tlt_info;
    }
}