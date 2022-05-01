using System.Windows.Forms;
using YAM2E.Classes;
using System;

namespace YAM2E.FORMS;

public partial class ScreenSettings : Form
{
    //Screen Data
    int SelectedBank;
    int SelectedScreen;
    int UsedScreen;
    int Scroll;
    int Transition;

    public ScreenSettings()
    {
        InitializeComponent();

        for (int i = 0; i < 512; i++)
        {
            cbb_scse_transition_index.Items.Add(i.ToString("X3"));
        }
        for (int i = 0; i < 59; i++)
        {
            cbb_scse_screen_used.Items.Add(i.ToString("X2"));
        }
        for (int i = 0; i < 256; i++)
        {
            cbb_scse_screen.Items.Add(i.ToString("X2"));
        }
        cbb_scse_screen.SelectedIndex = 0;
        cbb_scse_area_bank.SelectedIndex = 0;
    }

    void SelectedScreenChanged()
    {
        SelectedBank = Math.Max(SelectedBank, 0);
        SelectedScreen = Math.Max(SelectedScreen, 0);

        //Used screen data
        int usedScreen = Editor.ROM[Editor.A_BANKS[SelectedBank] + (2 * SelectedScreen) + 1];
        usedScreen -= 0x45;
        cbb_scse_screen_used.SelectedIndex = usedScreen;

        //Scroll data
        int scrollData = Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x200 + SelectedScreen];
        num_scse_scroll_data.Value = scrollData;

        //Transition data
        int transitionData = Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen)];
        transitionData += Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen) + 1] << 8;
        cbb_scse_transition_index.SelectedIndex = transitionData & 0xF7FF; //0xF7FF masks out the priority bit

        //Priority bit
        transitionData &= 0x800;
        if (transitionData == 0x800) chb_samus_priority.Checked = true;
        else chb_samus_priority.Checked = false;
    }

    private void cbb_scse_area_bank_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        SelectedBank = cbb_scse_area_bank.SelectedIndex;
        SelectedScreenChanged();
    }

    private void cbb_scse_screen_SelectedIndexChanged(object sender, System.EventArgs e)
    {
        SelectedScreen = cbb_scse_screen.SelectedIndex;
        SelectedScreenChanged();
    }
}