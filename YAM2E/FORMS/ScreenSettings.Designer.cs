
namespace LAMP.FORMS
{
    partial class ScreenSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenSettings));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_scse_area_bank = new System.Windows.Forms.Label();
            this.lbl_scse_screen = new System.Windows.Forms.Label();
            this.grp_scse_screen_data = new System.Windows.Forms.GroupBox();
            this.btn_scroll_right = new System.Windows.Forms.Button();
            this.btn_scroll_left = new System.Windows.Forms.Button();
            this.btn_scroll_down = new System.Windows.Forms.Button();
            this.btn_scroll_up = new System.Windows.Forms.Button();
            this.btn_scse_edit_transition = new System.Windows.Forms.Button();
            this.chb_samus_priority = new System.Windows.Forms.CheckBox();
            this.cbb_scse_transition_index = new System.Windows.Forms.ComboBox();
            this.lbl_scse_transition_index = new System.Windows.Forms.Label();
            this.num_scse_scroll_data = new System.Windows.Forms.NumericUpDown();
            this.lbl_scse_scroll_data = new System.Windows.Forms.Label();
            this.cbb_scse_screen_used = new System.Windows.Forms.ComboBox();
            this.lbl_scse_screen_used = new System.Windows.Forms.Label();
            this.cbb_scse_area_bank = new System.Windows.Forms.ComboBox();
            this.cbb_scse_screen = new System.Windows.Forms.ComboBox();
            this.btn_scse_apply = new System.Windows.Forms.Button();
            this.btn_scse_close = new System.Windows.Forms.Button();
            this.grp_scse_screen_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_scse_scroll_data)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 199);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(314, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_scse_area_bank
            // 
            this.lbl_scse_area_bank.AutoSize = true;
            this.lbl_scse_area_bank.Location = new System.Drawing.Point(21, 140);
            this.lbl_scse_area_bank.Name = "lbl_scse_area_bank";
            this.lbl_scse_area_bank.Size = new System.Drawing.Size(63, 15);
            this.lbl_scse_area_bank.TabIndex = 1;
            this.lbl_scse_area_bank.Text = "Area Bank:";
            // 
            // lbl_scse_screen
            // 
            this.lbl_scse_screen.AutoSize = true;
            this.lbl_scse_screen.Location = new System.Drawing.Point(21, 169);
            this.lbl_scse_screen.Name = "lbl_scse_screen";
            this.lbl_scse_screen.Size = new System.Drawing.Size(45, 15);
            this.lbl_scse_screen.TabIndex = 2;
            this.lbl_scse_screen.Text = "Screen:";
            // 
            // grp_scse_screen_data
            // 
            this.grp_scse_screen_data.Controls.Add(this.btn_scroll_right);
            this.grp_scse_screen_data.Controls.Add(this.btn_scroll_left);
            this.grp_scse_screen_data.Controls.Add(this.btn_scroll_down);
            this.grp_scse_screen_data.Controls.Add(this.btn_scroll_up);
            this.grp_scse_screen_data.Controls.Add(this.btn_scse_edit_transition);
            this.grp_scse_screen_data.Controls.Add(this.chb_samus_priority);
            this.grp_scse_screen_data.Controls.Add(this.cbb_scse_transition_index);
            this.grp_scse_screen_data.Controls.Add(this.lbl_scse_transition_index);
            this.grp_scse_screen_data.Controls.Add(this.num_scse_scroll_data);
            this.grp_scse_screen_data.Controls.Add(this.lbl_scse_scroll_data);
            this.grp_scse_screen_data.Controls.Add(this.cbb_scse_screen_used);
            this.grp_scse_screen_data.Controls.Add(this.lbl_scse_screen_used);
            this.grp_scse_screen_data.Location = new System.Drawing.Point(13, 13);
            this.grp_scse_screen_data.Name = "grp_scse_screen_data";
            this.grp_scse_screen_data.Size = new System.Drawing.Size(289, 118);
            this.grp_scse_screen_data.TabIndex = 3;
            this.grp_scse_screen_data.TabStop = false;
            this.grp_scse_screen_data.Text = "Screen Data";
            // 
            // btn_scroll_right
            // 
            this.btn_scroll_right.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_scroll_right.Image = ((System.Drawing.Image)(resources.GetObject("btn_scroll_right.Image")));
            this.btn_scroll_right.Location = new System.Drawing.Point(175, 51);
            this.btn_scroll_right.Name = "btn_scroll_right";
            this.btn_scroll_right.Size = new System.Drawing.Size(23, 23);
            this.btn_scroll_right.TabIndex = 11;
            this.btn_scroll_right.UseVisualStyleBackColor = false;
            this.btn_scroll_right.Click += new System.EventHandler(this.btn_scroll_right_Click);
            // 
            // btn_scroll_left
            // 
            this.btn_scroll_left.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_scroll_left.Image = ((System.Drawing.Image)(resources.GetObject("btn_scroll_left.Image")));
            this.btn_scroll_left.Location = new System.Drawing.Point(146, 51);
            this.btn_scroll_left.Name = "btn_scroll_left";
            this.btn_scroll_left.Size = new System.Drawing.Size(23, 23);
            this.btn_scroll_left.TabIndex = 10;
            this.btn_scroll_left.UseVisualStyleBackColor = false;
            this.btn_scroll_left.Click += new System.EventHandler(this.btn_scroll_left_Click);
            // 
            // btn_scroll_down
            // 
            this.btn_scroll_down.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_scroll_down.Image = ((System.Drawing.Image)(resources.GetObject("btn_scroll_down.Image")));
            this.btn_scroll_down.Location = new System.Drawing.Point(117, 51);
            this.btn_scroll_down.Name = "btn_scroll_down";
            this.btn_scroll_down.Size = new System.Drawing.Size(23, 23);
            this.btn_scroll_down.TabIndex = 9;
            this.btn_scroll_down.UseVisualStyleBackColor = false;
            this.btn_scroll_down.Click += new System.EventHandler(this.btn_scroll_down_Click);
            // 
            // btn_scroll_up
            // 
            this.btn_scroll_up.BackColor = System.Drawing.Color.YellowGreen;
            this.btn_scroll_up.Image = ((System.Drawing.Image)(resources.GetObject("btn_scroll_up.Image")));
            this.btn_scroll_up.Location = new System.Drawing.Point(88, 51);
            this.btn_scroll_up.Name = "btn_scroll_up";
            this.btn_scroll_up.Size = new System.Drawing.Size(23, 23);
            this.btn_scroll_up.TabIndex = 8;
            this.btn_scroll_up.UseVisualStyleBackColor = false;
            this.btn_scroll_up.Click += new System.EventHandler(this.btn_scroll_up_Click);
            // 
            // btn_scse_edit_transition
            // 
            this.btn_scse_edit_transition.Location = new System.Drawing.Point(162, 80);
            this.btn_scse_edit_transition.Name = "btn_scse_edit_transition";
            this.btn_scse_edit_transition.Size = new System.Drawing.Size(121, 23);
            this.btn_scse_edit_transition.TabIndex = 7;
            this.btn_scse_edit_transition.Text = "Edit Transition";
            this.btn_scse_edit_transition.UseVisualStyleBackColor = true;
            this.btn_scse_edit_transition.Click += new System.EventHandler(this.btn_scse_edit_transition_Click);
            // 
            // chb_samus_priority
            // 
            this.chb_samus_priority.AutoSize = true;
            this.chb_samus_priority.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chb_samus_priority.Location = new System.Drawing.Point(162, 24);
            this.chb_samus_priority.Name = "chb_samus_priority";
            this.chb_samus_priority.Size = new System.Drawing.Size(121, 19);
            this.chb_samus_priority.TabIndex = 6;
            this.chb_samus_priority.Text = "Samus under Tiles";
            this.chb_samus_priority.UseVisualStyleBackColor = true;
            this.chb_samus_priority.CheckedChanged += new System.EventHandler(this.chb_samus_priority_CheckedChanged);
            // 
            // cbb_scse_transition_index
            // 
            this.cbb_scse_transition_index.FormattingEnabled = true;
            this.cbb_scse_transition_index.Location = new System.Drawing.Point(88, 80);
            this.cbb_scse_transition_index.Name = "cbb_scse_transition_index";
            this.cbb_scse_transition_index.Size = new System.Drawing.Size(56, 23);
            this.cbb_scse_transition_index.TabIndex = 5;
            this.cbb_scse_transition_index.SelectedIndexChanged += new System.EventHandler(this.cbb_scse_transition_index_SelectedIndexChanged);
            // 
            // lbl_scse_transition_index
            // 
            this.lbl_scse_transition_index.AutoSize = true;
            this.lbl_scse_transition_index.Location = new System.Drawing.Point(8, 83);
            this.lbl_scse_transition_index.Name = "lbl_scse_transition_index";
            this.lbl_scse_transition_index.Size = new System.Drawing.Size(61, 15);
            this.lbl_scse_transition_index.TabIndex = 4;
            this.lbl_scse_transition_index.Text = "Transition:";
            // 
            // num_scse_scroll_data
            // 
            this.num_scse_scroll_data.Hexadecimal = true;
            this.num_scse_scroll_data.Location = new System.Drawing.Point(204, 51);
            this.num_scse_scroll_data.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.num_scse_scroll_data.Name = "num_scse_scroll_data";
            this.num_scse_scroll_data.Size = new System.Drawing.Size(79, 23);
            this.num_scse_scroll_data.TabIndex = 3;
            this.num_scse_scroll_data.ValueChanged += new System.EventHandler(this.num_scse_scroll_data_ValueChanged);
            // 
            // lbl_scse_scroll_data
            // 
            this.lbl_scse_scroll_data.AutoSize = true;
            this.lbl_scse_scroll_data.Location = new System.Drawing.Point(8, 53);
            this.lbl_scse_scroll_data.Name = "lbl_scse_scroll_data";
            this.lbl_scse_scroll_data.Size = new System.Drawing.Size(39, 15);
            this.lbl_scse_scroll_data.TabIndex = 2;
            this.lbl_scse_scroll_data.Text = "Scroll:";
            // 
            // cbb_scse_screen_used
            // 
            this.cbb_scse_screen_used.FormattingEnabled = true;
            this.cbb_scse_screen_used.Location = new System.Drawing.Point(88, 22);
            this.cbb_scse_screen_used.Name = "cbb_scse_screen_used";
            this.cbb_scse_screen_used.Size = new System.Drawing.Size(56, 23);
            this.cbb_scse_screen_used.TabIndex = 1;
            this.cbb_scse_screen_used.SelectedIndexChanged += new System.EventHandler(this.cbb_scse_screen_used_SelectedIndexChanged);
            // 
            // lbl_scse_screen_used
            // 
            this.lbl_scse_screen_used.AutoSize = true;
            this.lbl_scse_screen_used.Location = new System.Drawing.Point(8, 25);
            this.lbl_scse_screen_used.Name = "lbl_scse_screen_used";
            this.lbl_scse_screen_used.Size = new System.Drawing.Size(74, 15);
            this.lbl_scse_screen_used.TabIndex = 0;
            this.lbl_scse_screen_used.Text = "Screen Used:";
            // 
            // cbb_scse_area_bank
            // 
            this.cbb_scse_area_bank.FormattingEnabled = true;
            this.cbb_scse_area_bank.Items.AddRange(new object[] {
            "9",
            "A",
            "B",
            "C",
            "D",
            "E",
            "F"});
            this.cbb_scse_area_bank.Location = new System.Drawing.Point(101, 137);
            this.cbb_scse_area_bank.Name = "cbb_scse_area_bank";
            this.cbb_scse_area_bank.Size = new System.Drawing.Size(56, 23);
            this.cbb_scse_area_bank.TabIndex = 4;
            this.cbb_scse_area_bank.SelectedIndexChanged += new System.EventHandler(this.cbb_scse_area_bank_SelectedIndexChanged);
            // 
            // cbb_scse_screen
            // 
            this.cbb_scse_screen.FormattingEnabled = true;
            this.cbb_scse_screen.Location = new System.Drawing.Point(101, 166);
            this.cbb_scse_screen.Name = "cbb_scse_screen";
            this.cbb_scse_screen.Size = new System.Drawing.Size(56, 23);
            this.cbb_scse_screen.TabIndex = 5;
            this.cbb_scse_screen.SelectedIndexChanged += new System.EventHandler(this.cbb_scse_screen_SelectedIndexChanged);
            // 
            // btn_scse_apply
            // 
            this.btn_scse_apply.Location = new System.Drawing.Point(175, 136);
            this.btn_scse_apply.Name = "btn_scse_apply";
            this.btn_scse_apply.Size = new System.Drawing.Size(121, 23);
            this.btn_scse_apply.TabIndex = 6;
            this.btn_scse_apply.Text = "Apply";
            this.btn_scse_apply.UseVisualStyleBackColor = true;
            this.btn_scse_apply.Click += new System.EventHandler(this.btn_scse_apply_Click);
            // 
            // btn_scse_close
            // 
            this.btn_scse_close.Location = new System.Drawing.Point(175, 165);
            this.btn_scse_close.Name = "btn_scse_close";
            this.btn_scse_close.Size = new System.Drawing.Size(121, 23);
            this.btn_scse_close.TabIndex = 7;
            this.btn_scse_close.Text = "Close";
            this.btn_scse_close.UseVisualStyleBackColor = true;
            this.btn_scse_close.Click += new System.EventHandler(this.btn_scse_close_Click);
            // 
            // ScreenSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 221);
            this.Controls.Add(this.btn_scse_close);
            this.Controls.Add(this.btn_scse_apply);
            this.Controls.Add(this.cbb_scse_screen);
            this.Controls.Add(this.cbb_scse_area_bank);
            this.Controls.Add(this.grp_scse_screen_data);
            this.Controls.Add(this.lbl_scse_screen);
            this.Controls.Add(this.lbl_scse_area_bank);
            this.Controls.Add(this.statusStrip1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(330, 260);
            this.Name = "ScreenSettings";
            this.Text = "Screen Settings";
            this.grp_scse_screen_data.ResumeLayout(false);
            this.grp_scse_screen_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_scse_scroll_data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label lbl_scse_area_bank;
        private System.Windows.Forms.Label lbl_scse_screen;
        private System.Windows.Forms.GroupBox grp_scse_screen_data;
        private System.Windows.Forms.CheckBox chb_samus_priority;
        private System.Windows.Forms.ComboBox cbb_scse_transition_index;
        private System.Windows.Forms.Label lbl_scse_transition_index;
        private System.Windows.Forms.NumericUpDown num_scse_scroll_data;
        private System.Windows.Forms.Label lbl_scse_scroll_data;
        private System.Windows.Forms.ComboBox cbb_scse_screen_used;
        private System.Windows.Forms.Label lbl_scse_screen_used;
        private System.Windows.Forms.ComboBox cbb_scse_area_bank;
        private System.Windows.Forms.ComboBox cbb_scse_screen;
        private System.Windows.Forms.Button btn_scse_edit_transition;
        private System.Windows.Forms.Button btn_scse_apply;
        private System.Windows.Forms.Button btn_scse_close;
        private System.Windows.Forms.Button btn_scroll_right;
        private System.Windows.Forms.Button btn_scroll_left;
        private System.Windows.Forms.Button btn_scroll_down;
        private System.Windows.Forms.Button btn_scroll_up;
    }
}