using System.Windows.Forms;
using LAMP.Classes;
using System;
using System.Drawing;

namespace LAMP.FORMS;

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

    /// <summary>
    /// If the selected area or screen changes the values have to be updated
    /// </summary>
    void SelectedScreenChanged()
    {
        SelectedBank = Math.Max(SelectedBank, 0);
        SelectedScreen = Math.Max(SelectedScreen, 0);

        //Used screen data
        int usedScreen = Globals.Areas[SelectedBank].Screens[SelectedScreen];
        if (usedScreen <= 0) cbb_scse_screen_used.Text = "Undefined";
        else
        {
            UsedScreen = usedScreen;
            cbb_scse_screen_used.SelectedIndex = UsedScreen;
        }

        //Scroll data
        int scrollData = Globals.Areas[SelectedBank].Scrolls[SelectedScreen];
        ScrollData = scrollData;
        num_scse_scroll_data.Value = ScrollData;

        //Transition data
        int transitionData = Globals.Areas[SelectedBank].Tansitions[SelectedScreen];
        Transition = transitionData;
        cbb_scse_transition_index.SelectedIndex = Transition;

        //Priority bit
        PriorityData = Globals.Areas[SelectedBank].Priorities[SelectedScreen];
        chb_samus_priority.Checked = PriorityData;

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

    /// <summary>
    /// Copies current values to old-variables for comparison
    /// </summary>
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
        int usedScreen = cbb_scse_screen_used.SelectedIndex;
        Globals.Areas[SelectedBank].Screens[SelectedScreen] = usedScreen;

        //Scroll data
        Globals.Areas[SelectedBank].Scrolls[SelectedScreen] = (byte)num_scse_scroll_data.Value;

        //Transition Data and Priority bit
        Globals.Areas[SelectedBank].Tansitions[SelectedScreen] = cbb_scse_transition_index.SelectedIndex;
        Globals.Areas[SelectedBank].Priorities[SelectedScreen] = chb_samus_priority.Checked;

        //updating screen
        if ((cbb_scse_screen_used.SelectedIndex != UsedScreen) && (Globals.SelectedArea == SelectedBank))
        {
            int ScreenX = SelectedScreen % 16;
            int ScreenY = SelectedScreen / 16;

            Graphics g = Graphics.FromImage(MainWindow.Room.BackgroundImage);
            g.DrawImage(Globals.Screens[SelectedBank][cbb_scse_screen_used.SelectedIndex].image, new Point(256 * ScreenX, 256 * ScreenY));
            g.Dispose();
            MainWindow.Room.Invalidate(new Rectangle(256 * ScreenX, 256 * ScreenY, 256, 256));
        }

        //Done writing
        DisableApply();
        SetOlds();
    }
}