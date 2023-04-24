using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Controls.Overrides;

public class FixedScrollPanel : Panel
{
    protected override Point ScrollToControl(Control activeControl)
    {
        return this.DisplayRectangle.Location;
    }
}
