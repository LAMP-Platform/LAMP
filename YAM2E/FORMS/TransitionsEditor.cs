using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YAM2E.FORMS
{
    public partial class TransitionsEditor : Form
    {
        public TransitionsEditor()
        {
            InitializeComponent();

            for (int i = 0; i < 512; i++)
            {
                cbb_tred_transition_selection.Items.Add(i.ToString("X3"));
            }
            cbb_tred_transition_selection.SelectedIndex = 0;
        }
    }
}
