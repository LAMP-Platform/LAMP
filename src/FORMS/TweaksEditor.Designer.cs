
namespace LAMP.FORMS
{
    partial class TweaksEditor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweaksEditor));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbl_tweaks = new System.Windows.Forms.DataGridView();
            this.clm_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clm_use = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TestLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tweaks)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TestLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 239);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(924, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbl_tweaks
            // 
            this.tbl_tweaks.AllowUserToResizeRows = false;
            this.tbl_tweaks.BackgroundColor = System.Drawing.SystemColors.Control;
            this.tbl_tweaks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_tweaks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clm_name,
            this.clm_offset,
            this.clm_data,
            this.clm_use});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tbl_tweaks.DefaultCellStyle = dataGridViewCellStyle1;
            this.tbl_tweaks.Location = new System.Drawing.Point(12, 12);
            this.tbl_tweaks.Name = "tbl_tweaks";
            this.tbl_tweaks.RowTemplate.Height = 25;
            this.tbl_tweaks.Size = new System.Drawing.Size(900, 215);
            this.tbl_tweaks.TabIndex = 1;
            this.tbl_tweaks.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.tbl_tweaks_CellBeginEdit);
            this.tbl_tweaks.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_tweaks_CellEndEdit);
            // 
            // clm_name
            // 
            this.clm_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_name.FillWeight = 75F;
            this.clm_name.HeaderText = "Name";
            this.clm_name.Name = "clm_name";
            // 
            // clm_offset
            // 
            this.clm_offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_offset.HeaderText = "Offset";
            this.clm_offset.Name = "clm_offset";
            // 
            // clm_data
            // 
            this.clm_data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_data.HeaderText = "Replacement";
            this.clm_data.Name = "clm_data";
            // 
            // clm_use
            // 
            this.clm_use.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clm_use.FillWeight = 20F;
            this.clm_use.HeaderText = "Apply";
            this.clm_use.Name = "clm_use";
            // 
            // TestLabel
            // 
            this.TestLabel.Name = "TestLabel";
            this.TestLabel.Size = new System.Drawing.Size(118, 17);
            this.TestLabel.Text = "toolStripStatusLabel1";
            // 
            // TweaksEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(924, 261);
            this.Controls.Add(this.tbl_tweaks);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 185);
            this.Name = "TweaksEditor";
            this.Text = "Tweaks";
            this.SizeChanged += new System.EventHandler(this.TweaksEditor_SizeChanged);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tweaks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView tbl_tweaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn clm_data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clm_use;
        private System.Windows.Forms.ToolStripStatusLabel TestLabel;
    }
}