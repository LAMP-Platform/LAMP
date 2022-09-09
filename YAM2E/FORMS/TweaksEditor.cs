using System;
using System.Windows.Forms;
using LAMP.Classes;

namespace LAMP.FORMS;

public partial class TweaksEditor : Form
{
    public static TweaksEditor Current;

    public TweaksEditor()
    {
        InitializeComponent();
        Current = this;
    }
}