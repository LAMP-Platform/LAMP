using System;
using System.Windows.Forms;
using LAMP.Classes;
using LAMP.Controls.Other;

namespace LAMP.FORMS;

public partial class TweaksEditor : Form
{
    public TweaksEditor()
    {
        InitializeComponent();

        for (int i = 0; i < 10; i++)
        {
            Tweak t = new Tweak()
            {
                Name = $"Tweak {i}",
                Description = "Damn, sample description.",
                Include = i % 2 == 0
            };
            Globals.Tweaks.Add(t);
        }

        foreach (Tweak t in Globals.Tweaks)
        {
            TweakDisplay td = new TweakDisplay(t)
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 3)
            };

            Panel p = new Panel()
            {
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(0, 0, 0, 3)
            };

            p.Controls.Add(td);
            pnl_main.Controls.Add(p);
        }
    }
}