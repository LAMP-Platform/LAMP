using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LAMP.Controls.Other;

namespace LAMP.Controls.Room
{
    public partial class ToolBar : UserControl
    {
        public ToolBar()
        {
            InitializeComponent();
        }

        #region EVENTS
        public EventHandler onToolSwitched { get; set; }
        public event EventHandler ToolSwitched
        {
            add
            {
                onToolSwitched += value;
            }
            remove
            {
                onToolSwitched -= value;
            }

        }
        public virtual void OnToolSwitched(EventArgs e)
        {
            onToolSwitched?.Invoke(this, e);
        }

        public EventHandler onToolCommandTriggered { get; set; }
        public event EventHandler ToolCommandTriggered
        {
            add
            {
                onToolCommandTriggered += value;
            }
            remove
            {
                onToolCommandTriggered -= value;
            }

        }
        public virtual void OnToolCommandTriggered(EventArgs e)
        {
            onToolCommandTriggered?.Invoke(this, e);
        }
        #endregion

        #region FIELDS
        public LampTool SelectedTool
        {
            get { return selectedTool; }
            set { selectedTool = value; }
        }
        private LampTool selectedTool = LampTool.Pen;

        public LampToolCommand TriggeredCommand
        {
            get { return triggeredCommand; }
        }
        private LampToolCommand triggeredCommand = LampToolCommand.Copy;
        #endregion

        /// <summary>
        /// Retroactively adds a new Control that wasnt present before.
        /// If <paramref name="newCategory"/> is set to true, a seperator will be put before the control.
        /// </summary>
        public void AddControl(Control control, bool newCategory = false)
        {
            if (newCategory) flw_controls.Controls.Add(new SeperatorVertical());
            flw_controls.Controls.Add(control);
        }

        private void SetButtonSelected(Button button, bool selected = false)
        {
            button.BackColor = Color.FromArgb(0, 0xF0, 0xF0, 0xF0);

            if (!selected) return;

            button.BackColor = Color.FromArgb(0, 0xA0, 0xA0, 0xFF);
        }

        private void ResetButtonSelected()
        {
            SetButtonSelected(btn_pen);
            SetButtonSelected(btn_move);
            SetButtonSelected(btn_fill);
            SetButtonSelected(btn_select);
        }

        public void SetTools(bool move, bool pen, bool select, bool fill)
        {
            btn_move.Visible = move;
            btn_pen.Visible = pen;
            btn_select.Visible = select;
            btn_fill.Visible = fill;
        }

        public void SetCopyPaste(bool copy, bool paste)
        {
            btn_copy.Visible = copy;
            btn_paste.Visible = paste;

            if (!(copy || paste)) sep_copy.Visible = false;
        }

        public void SetTransform(bool flipH, bool flipV, bool rotateR, bool rotateL)
        {
            btn_flip_hor.Visible = flipH;
            btn_flip_vert.Visible = flipV;
            btn_rotate_left.Visible = rotateL;
            btn_rotate_right.Visible = rotateR;

            if (!(flipH || flipV || rotateL || rotateR)) sep_transform.Visible = false;
        }

        public void SetZoom(bool zoomIn, bool zoomOut)
        {
            btn_zoom_in.Visible = zoomIn;
            btn_zoom_out.Visible = zoomOut;

            if (!(zoomIn || zoomOut)) sep_zoom.Visible = false;
        }

        public void EnableZoom(bool zoomIn, bool zoomOut)
        {
            btn_zoom_in.Enabled = zoomIn;
            btn_zoom_out.Enabled = zoomOut;
        }

        #region ToolEvents
        private void btn_pen_Click(object sender, EventArgs e)
        {
            ResetButtonSelected();

            selectedTool = LampTool.Pen;
            SetButtonSelected(btn_pen, true);
            OnToolSwitched(new EventArgs());
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            ResetButtonSelected();

            selectedTool = LampTool.Select;
            SetButtonSelected(btn_select, true);
            OnToolSwitched(new EventArgs());
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            ResetButtonSelected();

            selectedTool = LampTool.Fill;
            SetButtonSelected(btn_fill, true);
            OnToolSwitched(new EventArgs());
        }

        private void btn_copy_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.Copy;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_paste_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.Paste;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_flip_hor_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.FlipHorizontal;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_flip_vert_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.FlipVertical;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_rotate_right_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.RotateRight;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_rotate_left_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.RotateLeft;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_zoom_in_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.ZoomIn;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_zoom_out_Click(object sender, EventArgs e)
        {
            triggeredCommand = LampToolCommand.ZoomOut;
            OnToolCommandTriggered(new EventArgs());
        }

        private void btn_move_Click(object sender, EventArgs e)
        {
            ResetButtonSelected();

            selectedTool = LampTool.Move;
            SetButtonSelected(btn_move, true);
            OnToolSwitched(new EventArgs());
        }
    }
    #endregion

    public enum LampTool
    {
        Move,
        Pen,
        Select,
        Fill
    }

    public enum LampToolCommand
    {
        Copy,
        Paste,
        FlipHorizontal,
        FlipVertical,
        RotateRight,
        RotateLeft,
        ZoomIn,
        ZoomOut
    }
}
