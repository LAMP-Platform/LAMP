using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;
using LAMP.Classes;
using LAMP.Controls;
using LAMP.Utilities;

namespace LAMP.FORMS;

public partial class Test_form : Form
{
    public Test_form()
    {
        InitializeComponent();
    }

    bool isDragging = false;
    int clickOffsetX;
    int clickOffsetY;

    private void grp1_DragLeave(object sender, EventArgs e)
    {

    }

    private void lbl_MouseDown(object sender, MouseEventArgs e)
    {
        isDragging = true;
        clickOffsetX = e.X;
        clickOffsetY = e.Y;
    }

    private void lbl_MouseLeave(object sender, EventArgs e)
    {

    }

    private void lbl_MouseUp(object sender, MouseEventArgs e)
    {
        isDragging = false;
    }

    private void lbl_MouseMove(object sender, MouseEventArgs e)
    {
        if (!isDragging) return;
        Control c = sender as Control;

        c.Left = e.X + c.Left - clickOffsetX;
        c.Top = e.Y + c.Top - clickOffsetY;
    }
}
