
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TweaksEditor));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            pnl_main = new System.Windows.Forms.Panel();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 437);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(373, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // pnl_main
            // 
            pnl_main.AutoScroll = true;
            pnl_main.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_main.Location = new System.Drawing.Point(0, 0);
            pnl_main.Name = "pnl_main";
            pnl_main.Padding = new System.Windows.Forms.Padding(3);
            pnl_main.Size = new System.Drawing.Size(373, 437);
            pnl_main.TabIndex = 1;
            // 
            // TweaksEditor
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            AutoScroll = true;
            ClientSize = new System.Drawing.Size(373, 459);
            Controls.Add(pnl_main);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            Name = "TweaksEditor";
            Text = "Tweaks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnl_main;
    }
}