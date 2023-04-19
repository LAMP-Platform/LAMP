namespace LAMP.Controls.Other
{
    partial class RecentFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecentFiles));
            btn_open_project = new System.Windows.Forms.Button();
            btn_create_project = new System.Windows.Forms.Button();
            pnl_main_container = new System.Windows.Forms.SplitContainer();
            pnl_recent_files = new System.Windows.Forms.Panel();
            pnl_cog_button = new System.Windows.Forms.Panel();
            btn_project_settings = new System.Windows.Forms.Button();
            pnl_new_button = new System.Windows.Forms.Panel();
            pnl_open_button = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)pnl_main_container).BeginInit();
            pnl_main_container.Panel1.SuspendLayout();
            pnl_main_container.Panel2.SuspendLayout();
            pnl_main_container.SuspendLayout();
            pnl_cog_button.SuspendLayout();
            pnl_new_button.SuspendLayout();
            pnl_open_button.SuspendLayout();
            SuspendLayout();
            // 
            // btn_open_project
            // 
            btn_open_project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_open_project.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_open_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_open_project.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_open_project.Image = (System.Drawing.Image)resources.GetObject("btn_open_project.Image");
            btn_open_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_open_project.Location = new System.Drawing.Point(3, 3);
            btn_open_project.Name = "btn_open_project";
            btn_open_project.Size = new System.Drawing.Size(307, 60);
            btn_open_project.TabIndex = 0;
            btn_open_project.Text = "Create a new Project. A Metroid II: Return of Samus ROM is needed!";
            btn_open_project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_open_project.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_open_project.UseVisualStyleBackColor = true;
            btn_open_project.Click += btn_open_project_Click;
            // 
            // btn_create_project
            // 
            btn_create_project.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_create_project.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_create_project.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_create_project.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_create_project.Image = Properties.Resources.OpenProject;
            btn_create_project.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_create_project.Location = new System.Drawing.Point(3, 6);
            btn_create_project.Margin = new System.Windows.Forms.Padding(3, 6, 3, 3);
            btn_create_project.Name = "btn_create_project";
            btn_create_project.Size = new System.Drawing.Size(307, 60);
            btn_create_project.TabIndex = 1;
            btn_create_project.Text = "Open an existing Project file. Browse your PC for an .m2 file!";
            btn_create_project.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_create_project.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_create_project.UseVisualStyleBackColor = true;
            btn_create_project.Click += btn_create_project_Click;
            // 
            // pnl_main_container
            // 
            pnl_main_container.BackColor = System.Drawing.SystemColors.Control;
            pnl_main_container.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main_container.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            pnl_main_container.IsSplitterFixed = true;
            pnl_main_container.Location = new System.Drawing.Point(0, 0);
            pnl_main_container.Name = "pnl_main_container";
            // 
            // pnl_main_container.Panel1
            // 
            pnl_main_container.Panel1.BackColor = System.Drawing.SystemColors.Control;
            pnl_main_container.Panel1.Controls.Add(pnl_recent_files);
            // 
            // pnl_main_container.Panel2
            // 
            pnl_main_container.Panel2.Controls.Add(pnl_cog_button);
            pnl_main_container.Panel2.Controls.Add(pnl_new_button);
            pnl_main_container.Panel2.Controls.Add(pnl_open_button);
            pnl_main_container.Size = new System.Drawing.Size(805, 532);
            pnl_main_container.SplitterDistance = 485;
            pnl_main_container.TabIndex = 2;
            // 
            // pnl_recent_files
            // 
            pnl_recent_files.AutoScroll = true;
            pnl_recent_files.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_recent_files.Location = new System.Drawing.Point(0, 0);
            pnl_recent_files.Name = "pnl_recent_files";
            pnl_recent_files.Padding = new System.Windows.Forms.Padding(6, 3, 3, 6);
            pnl_recent_files.Size = new System.Drawing.Size(485, 532);
            pnl_recent_files.TabIndex = 0;
            // 
            // pnl_cog_button
            // 
            pnl_cog_button.Controls.Add(btn_project_settings);
            pnl_cog_button.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_cog_button.Location = new System.Drawing.Point(0, 135);
            pnl_cog_button.Name = "pnl_cog_button";
            pnl_cog_button.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            pnl_cog_button.Size = new System.Drawing.Size(316, 66);
            pnl_cog_button.TabIndex = 2;
            // 
            // btn_project_settings
            // 
            btn_project_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btn_project_settings.Dock = System.Windows.Forms.DockStyle.Fill;
            btn_project_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn_project_settings.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btn_project_settings.Image = (System.Drawing.Image)resources.GetObject("btn_project_settings.Image");
            btn_project_settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_project_settings.Location = new System.Drawing.Point(3, 3);
            btn_project_settings.Name = "btn_project_settings";
            btn_project_settings.Size = new System.Drawing.Size(307, 60);
            btn_project_settings.TabIndex = 0;
            btn_project_settings.Text = "Open the Program Settings. Set a ROM or change your preferences!\r\n";
            btn_project_settings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btn_project_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_project_settings.UseVisualStyleBackColor = true;
            btn_project_settings.Click += btn_project_settings_Click;
            // 
            // pnl_new_button
            // 
            pnl_new_button.Controls.Add(btn_open_project);
            pnl_new_button.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_new_button.Location = new System.Drawing.Point(0, 69);
            pnl_new_button.Name = "pnl_new_button";
            pnl_new_button.Padding = new System.Windows.Forms.Padding(3, 3, 6, 3);
            pnl_new_button.Size = new System.Drawing.Size(316, 66);
            pnl_new_button.TabIndex = 1;
            // 
            // pnl_open_button
            // 
            pnl_open_button.Controls.Add(btn_create_project);
            pnl_open_button.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_open_button.Location = new System.Drawing.Point(0, 0);
            pnl_open_button.Name = "pnl_open_button";
            pnl_open_button.Padding = new System.Windows.Forms.Padding(3, 6, 6, 3);
            pnl_open_button.Size = new System.Drawing.Size(316, 69);
            pnl_open_button.TabIndex = 0;
            // 
            // RecentFiles
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ControlDark;
            Controls.Add(pnl_main_container);
            Name = "RecentFiles";
            Size = new System.Drawing.Size(805, 532);
            pnl_main_container.Panel1.ResumeLayout(false);
            pnl_main_container.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pnl_main_container).EndInit();
            pnl_main_container.ResumeLayout(false);
            pnl_cog_button.ResumeLayout(false);
            pnl_new_button.ResumeLayout(false);
            pnl_open_button.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btn_open_project;
        private System.Windows.Forms.Button btn_create_project;
        private System.Windows.Forms.SplitContainer pnl_main_container;
        private System.Windows.Forms.Panel pnl_recent_files;
        private System.Windows.Forms.Panel pnl_new_button;
        private System.Windows.Forms.Panel pnl_open_button;
        private System.Windows.Forms.Panel pnl_cog_button;
        private System.Windows.Forms.Button btn_project_settings;
    }
}
