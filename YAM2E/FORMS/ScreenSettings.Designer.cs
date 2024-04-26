
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
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            lbl_scse_area_bank = new System.Windows.Forms.Label();
            lbl_scse_screen = new System.Windows.Forms.Label();
            grp_scse_screen_data = new System.Windows.Forms.GroupBox();
            btn_scroll_right = new System.Windows.Forms.Button();
            btn_scroll_left = new System.Windows.Forms.Button();
            btn_scroll_down = new System.Windows.Forms.Button();
            btn_scroll_up = new System.Windows.Forms.Button();
            btn_scse_edit_transition = new System.Windows.Forms.Button();
            chb_samus_priority = new System.Windows.Forms.CheckBox();
            cbb_scse_transition_index = new System.Windows.Forms.ComboBox();
            lbl_scse_transition_index = new System.Windows.Forms.Label();
            num_scse_scroll_data = new System.Windows.Forms.NumericUpDown();
            lbl_scse_scroll_data = new System.Windows.Forms.Label();
            cbb_scse_screen_used = new System.Windows.Forms.ComboBox();
            lbl_scse_screen_used = new System.Windows.Forms.Label();
            cbb_scse_area_bank = new System.Windows.Forms.ComboBox();
            cbb_scse_screen = new System.Windows.Forms.ComboBox();
            btn_scse_apply = new System.Windows.Forms.Button();
            btn_scse_close = new System.Windows.Forms.Button();
            grp_scse_screen_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)num_scse_scroll_data).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new System.Drawing.Point(0, 199);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(314, 22);
            statusStrip1.TabIndex = 0;
            statusStrip1.Text = "statusStrip1";
            // 
            // lbl_scse_area_bank
            // 
            lbl_scse_area_bank.AutoSize = true;
            lbl_scse_area_bank.Location = new System.Drawing.Point(21, 140);
            lbl_scse_area_bank.Name = "lbl_scse_area_bank";
            lbl_scse_area_bank.Size = new System.Drawing.Size(63, 15);
            lbl_scse_area_bank.TabIndex = 1;
            lbl_scse_area_bank.Text = "Area Bank:";
            // 
            // lbl_scse_screen
            // 
            lbl_scse_screen.AutoSize = true;
            lbl_scse_screen.Location = new System.Drawing.Point(21, 169);
            lbl_scse_screen.Name = "lbl_scse_screen";
            lbl_scse_screen.Size = new System.Drawing.Size(45, 15);
            lbl_scse_screen.TabIndex = 2;
            lbl_scse_screen.Text = "Screen:";
            // 
            // grp_scse_screen_data
            // 
            grp_scse_screen_data.Controls.Add(btn_scroll_right);
            grp_scse_screen_data.Controls.Add(btn_scroll_left);
            grp_scse_screen_data.Controls.Add(btn_scroll_down);
            grp_scse_screen_data.Controls.Add(btn_scroll_up);
            grp_scse_screen_data.Controls.Add(btn_scse_edit_transition);
            grp_scse_screen_data.Controls.Add(chb_samus_priority);
            grp_scse_screen_data.Controls.Add(cbb_scse_transition_index);
            grp_scse_screen_data.Controls.Add(lbl_scse_transition_index);
            grp_scse_screen_data.Controls.Add(num_scse_scroll_data);
            grp_scse_screen_data.Controls.Add(lbl_scse_scroll_data);
            grp_scse_screen_data.Controls.Add(cbb_scse_screen_used);
            grp_scse_screen_data.Controls.Add(lbl_scse_screen_used);
            grp_scse_screen_data.Location = new System.Drawing.Point(13, 13);
            grp_scse_screen_data.Name = "grp_scse_screen_data";
            grp_scse_screen_data.Size = new System.Drawing.Size(289, 118);
            grp_scse_screen_data.TabIndex = 3;
            grp_scse_screen_data.TabStop = false;
            grp_scse_screen_data.Text = "Screen Data";
            // 
            // btn_scroll_right
            // 
            btn_scroll_right.BackColor = System.Drawing.Color.YellowGreen;
            btn_scroll_right.Image = (System.Drawing.Image)resources.GetObject("btn_scroll_right.Image");
            btn_scroll_right.Location = new System.Drawing.Point(175, 51);
            btn_scroll_right.Name = "btn_scroll_right";
            btn_scroll_right.Size = new System.Drawing.Size(23, 23);
            btn_scroll_right.TabIndex = 11;
            btn_scroll_right.UseVisualStyleBackColor = false;
            btn_scroll_right.Click += btn_scroll_right_Click;
            // 
            // btn_scroll_left
            // 
            btn_scroll_left.BackColor = System.Drawing.Color.YellowGreen;
            btn_scroll_left.Image = (System.Drawing.Image)resources.GetObject("btn_scroll_left.Image");
            btn_scroll_left.Location = new System.Drawing.Point(146, 51);
            btn_scroll_left.Name = "btn_scroll_left";
            btn_scroll_left.Size = new System.Drawing.Size(23, 23);
            btn_scroll_left.TabIndex = 10;
            btn_scroll_left.UseVisualStyleBackColor = false;
            btn_scroll_left.Click += btn_scroll_left_Click;
            // 
            // btn_scroll_down
            // 
            btn_scroll_down.BackColor = System.Drawing.Color.YellowGreen;
            btn_scroll_down.Image = (System.Drawing.Image)resources.GetObject("btn_scroll_down.Image");
            btn_scroll_down.Location = new System.Drawing.Point(117, 51);
            btn_scroll_down.Name = "btn_scroll_down";
            btn_scroll_down.Size = new System.Drawing.Size(23, 23);
            btn_scroll_down.TabIndex = 9;
            btn_scroll_down.UseVisualStyleBackColor = false;
            btn_scroll_down.Click += btn_scroll_down_Click;
            // 
            // btn_scroll_up
            // 
            btn_scroll_up.BackColor = System.Drawing.Color.YellowGreen;
            btn_scroll_up.Image = (System.Drawing.Image)resources.GetObject("btn_scroll_up.Image");
            btn_scroll_up.Location = new System.Drawing.Point(88, 51);
            btn_scroll_up.Name = "btn_scroll_up";
            btn_scroll_up.Size = new System.Drawing.Size(23, 23);
            btn_scroll_up.TabIndex = 8;
            btn_scroll_up.UseVisualStyleBackColor = false;
            btn_scroll_up.Click += btn_scroll_up_Click;
            // 
            // btn_scse_edit_transition
            // 
            btn_scse_edit_transition.Image = Properties.Resources.PenOneSelected;
            btn_scse_edit_transition.Location = new System.Drawing.Point(260, 80);
            btn_scse_edit_transition.Name = "btn_scse_edit_transition";
            btn_scse_edit_transition.Size = new System.Drawing.Size(23, 23);
            btn_scse_edit_transition.TabIndex = 7;
            btn_scse_edit_transition.UseVisualStyleBackColor = true;
            btn_scse_edit_transition.Click += btn_scse_edit_transition_Click;
            // 
            // chb_samus_priority
            // 
            chb_samus_priority.AutoSize = true;
            chb_samus_priority.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            chb_samus_priority.Location = new System.Drawing.Point(162, 24);
            chb_samus_priority.Name = "chb_samus_priority";
            chb_samus_priority.Size = new System.Drawing.Size(121, 19);
            chb_samus_priority.TabIndex = 6;
            chb_samus_priority.Text = "Samus under Tiles";
            chb_samus_priority.UseVisualStyleBackColor = true;
            chb_samus_priority.CheckedChanged += chb_samus_priority_CheckedChanged;
            // 
            // cbb_scse_transition_index
            // 
            cbb_scse_transition_index.FormattingEnabled = true;
            cbb_scse_transition_index.Location = new System.Drawing.Point(88, 80);
            cbb_scse_transition_index.Name = "cbb_scse_transition_index";
            cbb_scse_transition_index.Size = new System.Drawing.Size(166, 23);
            cbb_scse_transition_index.TabIndex = 5;
            cbb_scse_transition_index.SelectedIndexChanged += cbb_scse_transition_index_SelectedIndexChanged;
            // 
            // lbl_scse_transition_index
            // 
            lbl_scse_transition_index.AutoSize = true;
            lbl_scse_transition_index.Location = new System.Drawing.Point(8, 83);
            lbl_scse_transition_index.Name = "lbl_scse_transition_index";
            lbl_scse_transition_index.Size = new System.Drawing.Size(61, 15);
            lbl_scse_transition_index.TabIndex = 4;
            lbl_scse_transition_index.Text = "Transition:";
            // 
            // num_scse_scroll_data
            // 
            num_scse_scroll_data.Hexadecimal = true;
            num_scse_scroll_data.Location = new System.Drawing.Point(204, 51);
            num_scse_scroll_data.Maximum = new decimal(new int[] { 15, 0, 0, 0 });
            num_scse_scroll_data.Name = "num_scse_scroll_data";
            num_scse_scroll_data.Size = new System.Drawing.Size(79, 23);
            num_scse_scroll_data.TabIndex = 3;
            num_scse_scroll_data.ValueChanged += num_scse_scroll_data_ValueChanged;
            // 
            // lbl_scse_scroll_data
            // 
            lbl_scse_scroll_data.AutoSize = true;
            lbl_scse_scroll_data.Location = new System.Drawing.Point(8, 53);
            lbl_scse_scroll_data.Name = "lbl_scse_scroll_data";
            lbl_scse_scroll_data.Size = new System.Drawing.Size(39, 15);
            lbl_scse_scroll_data.TabIndex = 2;
            lbl_scse_scroll_data.Text = "Scroll:";
            // 
            // cbb_scse_screen_used
            // 
            cbb_scse_screen_used.FormattingEnabled = true;
            cbb_scse_screen_used.Location = new System.Drawing.Point(88, 22);
            cbb_scse_screen_used.Name = "cbb_scse_screen_used";
            cbb_scse_screen_used.Size = new System.Drawing.Size(56, 23);
            cbb_scse_screen_used.TabIndex = 1;
            cbb_scse_screen_used.SelectedIndexChanged += cbb_scse_screen_used_SelectedIndexChanged;
            // 
            // lbl_scse_screen_used
            // 
            lbl_scse_screen_used.AutoSize = true;
            lbl_scse_screen_used.Location = new System.Drawing.Point(8, 25);
            lbl_scse_screen_used.Name = "lbl_scse_screen_used";
            lbl_scse_screen_used.Size = new System.Drawing.Size(74, 15);
            lbl_scse_screen_used.TabIndex = 0;
            lbl_scse_screen_used.Text = "Screen Used:";
            // 
            // cbb_scse_area_bank
            // 
            cbb_scse_area_bank.FormattingEnabled = true;
            cbb_scse_area_bank.Items.AddRange(new object[] { "9", "A", "B", "C", "D", "E", "F" });
            cbb_scse_area_bank.Location = new System.Drawing.Point(101, 137);
            cbb_scse_area_bank.Name = "cbb_scse_area_bank";
            cbb_scse_area_bank.Size = new System.Drawing.Size(56, 23);
            cbb_scse_area_bank.TabIndex = 4;
            cbb_scse_area_bank.SelectedIndexChanged += cbb_scse_area_bank_SelectedIndexChanged;
            // 
            // cbb_scse_screen
            // 
            cbb_scse_screen.FormattingEnabled = true;
            cbb_scse_screen.Location = new System.Drawing.Point(101, 166);
            cbb_scse_screen.Name = "cbb_scse_screen";
            cbb_scse_screen.Size = new System.Drawing.Size(56, 23);
            cbb_scse_screen.TabIndex = 5;
            cbb_scse_screen.SelectedIndexChanged += cbb_scse_screen_SelectedIndexChanged;
            // 
            // btn_scse_apply
            // 
            btn_scse_apply.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btn_scse_apply.Location = new System.Drawing.Point(175, 136);
            btn_scse_apply.Name = "btn_scse_apply";
            btn_scse_apply.Size = new System.Drawing.Size(121, 23);
            btn_scse_apply.TabIndex = 6;
            btn_scse_apply.Text = "Apply";
            btn_scse_apply.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btn_scse_apply.UseVisualStyleBackColor = true;
            btn_scse_apply.Click += btn_scse_apply_Click;
            // 
            // btn_scse_close
            // 
            btn_scse_close.Location = new System.Drawing.Point(175, 165);
            btn_scse_close.Name = "btn_scse_close";
            btn_scse_close.Size = new System.Drawing.Size(121, 23);
            btn_scse_close.TabIndex = 7;
            btn_scse_close.Text = "Close";
            btn_scse_close.UseVisualStyleBackColor = true;
            btn_scse_close.Click += btn_scse_close_Click;
            // 
            // ScreenSettings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(314, 221);
            Controls.Add(btn_scse_close);
            Controls.Add(btn_scse_apply);
            Controls.Add(cbb_scse_screen);
            Controls.Add(cbb_scse_area_bank);
            Controls.Add(grp_scse_screen_data);
            Controls.Add(lbl_scse_screen);
            Controls.Add(lbl_scse_area_bank);
            Controls.Add(statusStrip1);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimumSize = new System.Drawing.Size(330, 260);
            Name = "ScreenSettings";
            Text = "Screen Settings";
            grp_scse_screen_data.ResumeLayout(false);
            grp_scse_screen_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)num_scse_scroll_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
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