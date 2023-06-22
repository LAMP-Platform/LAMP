using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP;

public static class ComboboxOp
{
    public static void AutoSize(ComboBox comboBox)
    {
        const int scrollPadding = 20; //The scroll bar takes up space!

        if (comboBox == null) return;
        if (comboBox.Items.Count == 0) return;

        int maxWidth = 0;
        foreach (object item in comboBox.Items)
        {
            int temp = TextRenderer.MeasureText(item.ToString(), comboBox.Font).Width;
            if (temp > maxWidth) maxWidth = temp;
        }
        comboBox.DropDownWidth = maxWidth > comboBox.Width ? maxWidth + scrollPadding : comboBox.Width;
    }
}
