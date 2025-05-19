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
using LAMP.Controls.Other;

namespace LAMP.FORMS;

public partial class Test_form : Form
{
    public Test_form()
    {
        InitializeComponent();

        Tweak t = new Tweak()
        {
            Description = "Man I love this description \r\n" +
            "I am adding a bunch of newlines\r\n\r\n\r\n" +
            "Hopefully this is readable"
        };
        TweakDisplay td = new TweakDisplay(t);
        Controls.Add(td);
    }
}
