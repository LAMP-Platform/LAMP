namespace LAMP.FORMS
{
    partial class FreeSpace
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
            this.grp_object_freespace = new System.Windows.Forms.GroupBox();
            this.btn_object_rearrange = new System.Windows.Forms.Button();
            this.txb_object_rearrange = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.grp_object_freespace.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_object_freespace
            // 
            this.grp_object_freespace.Controls.Add(this.btn_object_rearrange);
            this.grp_object_freespace.Controls.Add(this.txb_object_rearrange);
            this.grp_object_freespace.Location = new System.Drawing.Point(12, 12);
            this.grp_object_freespace.Name = "grp_object_freespace";
            this.grp_object_freespace.Size = new System.Drawing.Size(420, 93);
            this.grp_object_freespace.TabIndex = 0;
            this.grp_object_freespace.TabStop = false;
            this.grp_object_freespace.Text = "Objects";
            // 
            // btn_object_rearrange
            // 
            this.btn_object_rearrange.Location = new System.Drawing.Point(6, 60);
            this.btn_object_rearrange.Name = "btn_object_rearrange";
            this.btn_object_rearrange.Size = new System.Drawing.Size(103, 23);
            this.btn_object_rearrange.TabIndex = 1;
            this.btn_object_rearrange.Text = "Rearrange Data";
            this.btn_object_rearrange.UseVisualStyleBackColor = true;
            this.btn_object_rearrange.Click += new System.EventHandler(this.btn_object_rearrange_Click);
            // 
            // txb_object_rearrange
            // 
            this.txb_object_rearrange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txb_object_rearrange.Location = new System.Drawing.Point(6, 22);
            this.txb_object_rearrange.Multiline = true;
            this.txb_object_rearrange.Name = "txb_object_rearrange";
            this.txb_object_rearrange.ReadOnly = true;
            this.txb_object_rearrange.Size = new System.Drawing.Size(410, 32);
            this.txb_object_rearrange.TabIndex = 0;
            this.txb_object_rearrange.Text = "This will rearrange object data to allow for more overall objects in the game.\r\nT" +
    "his change cannot be undone!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 117);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(445, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // FreeSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 139);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.grp_object_freespace);
            this.MaximumSize = new System.Drawing.Size(461, 178);
            this.MinimumSize = new System.Drawing.Size(461, 178);
            this.Name = "FreeSpace";
            this.Text = "Free Space";
            this.grp_object_freespace.ResumeLayout(false);
            this.grp_object_freespace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_object_freespace;
        private System.Windows.Forms.Button btn_object_rearrange;
        private System.Windows.Forms.TextBox txb_object_rearrange;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}