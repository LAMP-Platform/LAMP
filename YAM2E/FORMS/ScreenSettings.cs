using System.Windows.Forms;
using YAM2E.Classes;
using System;

namespace YAM2E.FORMS;

public partial class ScreenSettings : Form
{
    public ScreenSettings Current;

    //Screen Data
    int SelectedBank;
    int SelectedScreen;
    int UsedScreen;
    int ScrollData;
    int Transition;
    bool PriorityData;

    public ScreenSettings(int AreaIndex = 0, int ScreenIndex = 0)
    {
        Current = this;
        InitializeComponent();

        DisableApply();
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
        cbb_scse_screen.SelectedIndex = ScreenIndex;
        cbb_scse_area_bank.SelectedIndex = AreaIndex;
    }

    void SelectedScreenChanged()
    {
        SelectedBank = Math.Max(SelectedBank, 0);
        SelectedScreen = Math.Max(SelectedScreen, 0);

        //Used screen data
        int usedScreen = Editor.ROM[Editor.A_BANKS[SelectedBank] + (2 * SelectedScreen) + 1];
        if (usedScreen == 0)
        {
            cbb_scse_screen_used.Text = "Undefined";
        }
        else
        {
            usedScreen -= 0x45;
            UsedScreen = usedScreen;
            cbb_scse_screen_used.SelectedIndex = UsedScreen;
        }

        //Scroll data
        int scrollData = Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x200 + SelectedScreen];
        ScrollData = scrollData;
        num_scse_scroll_data.Value = ScrollData;

        //Transition data
        int transitionData = Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen)];
        transitionData += Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen) + 1] << 8;
        Transition = transitionData & 0xF7FF; //0xF7FF masks out the priority bit
        cbb_scse_transition_index.SelectedIndex = Transition;

        //Priority bit
        transitionData &= 0x800;
        if (transitionData == 0x800)
        {
            PriorityData = true;
            chb_samus_priority.Checked = true;
        }
        else
        {
            PriorityData = false;
            chb_samus_priority.Checked = false;
        }

        SetOlds();
        DisableApply();
    }

    void EnableApply()
    {
        btn_scse_apply.Enabled = true;
    }

    void DisableApply()
    {
        btn_scse_apply.Enabled = false;
    }

    void SetOlds()
    {
        UsedScreen = cbb_scse_screen_used.SelectedIndex;
        ScrollData = (int)num_scse_scroll_data.Value;
        Transition = cbb_scse_transition_index.SelectedIndex;
        PriorityData = chb_samus_priority.Checked;
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

    private void btn_scse_edit_transition_Click(object sender, EventArgs e)
    {
        new TransitionsEditor(Transition).Show();
    }

    private void cbb_scse_screen_used_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbb_scse_screen_used.SelectedIndex != UsedScreen) EnableApply();
    }

    private void num_scse_scroll_data_ValueChanged(object sender, EventArgs e)
    {
        if ((int)num_scse_scroll_data.Value != ScrollData) EnableApply();
    }

    private void cbb_scse_transition_index_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (cbb_scse_transition_index.SelectedIndex != Transition) EnableApply();
    }

    private void chb_samus_priority_CheckedChanged(object sender, EventArgs e)
    {
        if (chb_samus_priority.Checked != PriorityData) EnableApply();
    }

    private void btn_scse_close_Click(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btn_scse_apply_Click(object sender, EventArgs e)
    {
        //Writing data
        //Used screen data
        int usedScreen = cbb_scse_screen_used.SelectedIndex + 0x45;
        Editor.ROM[Editor.A_BANKS[SelectedBank] + (2 * SelectedScreen) + 1] = (byte)usedScreen;

        //Scroll data
        Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x200 + SelectedScreen] = (byte)num_scse_scroll_data.Value;

        //Transition Data and Priority bit
        int transitionData;
        if (chb_samus_priority.Checked) transitionData = 0x800;
        else transitionData = 0x0;
        transitionData += cbb_scse_transition_index.SelectedIndex;
        Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen)] = (byte)(transitionData & 0xFF);
        Editor.ROM[Editor.A_BANKS[SelectedBank] + 0x300 + (2 * SelectedScreen) + 1] = (byte)(transitionData >> 8);

        //Done writing
        DisableApply();
        SetOlds();
    }
}