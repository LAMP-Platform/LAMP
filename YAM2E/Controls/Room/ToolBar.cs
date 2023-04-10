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

        #region ToolEvents
        public void SetTools(bool pen, bool select, bool fill)
        {
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

        private void btn_pen_Click(object sender, EventArgs e)
        {
            selectedTool = LampTool.Pen;
        }

        private void btn_select_Click(object sender, EventArgs e)
        {
            selectedTool = LampTool.Select;
            OnToolSwitched(new EventArgs());
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            selectedTool = LampTool.Fill;
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
    }
    #endregion

    public enum LampTool
    {
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
