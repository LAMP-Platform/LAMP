using System;
using System.Windows.Forms;
using YAM2E.Classes;

namespace YAM2E.FORMS;

public partial class TweaksEditor : Form
{
    public static TweaksEditor Current;

    public TweaksEditor()
    {
        InitializeComponent();
        Current = this;
    }

    public void ApplyTweak(int offset, byte value)
        => Editor.ROM.Data[offset] = value;

    public void ApplyTweak(int offset, byte[] values)
    {
        for (int i = 0; i < values.Length; i++)
            Editor.ROM.Data[offset + i] = values[i];
    }

    public void ApplyTweak(int[] offsets, byte[] values)
    {
        for (int i = 0; i < values.Length; i++)
            Editor.ROM.Data[offsets[i]] = values[i];
    }

    private void btn_close_tweaks_Click(object sender, EventArgs e)
        => Close();

    private void btn_apply_tweaks_Click(object sender, EventArgs e)
        => apply_tweaks();

    private void apply_tweaks()
    {
        //Samus tweaks
        if (chb_tweak_center_samus.Checked)
            ApplyTweak(Globals.CenterSamusOnHorizontalMovementOffset, Globals.CenterSamusOnHorizontalMovementValues);
        else ApplyTweak(Globals.CenterSamusOnHorizontalMovementOffset, Globals.CenterSamusOnHorizontalMovementStandard);

        if (chb_tweak_disable_health_alarm.Checked)
            ApplyTweak(Globals.DisableLowHealthOffset, Globals.DisableLowHealthValues);
        else ApplyTweak(Globals.DisableLowHealthOffset, Globals.DisableLowHealthStandard);

        ApplyTweak(Globals.SamusWalkingSpeedLeftOffset, (byte)num_tweak_samus_speed.Value);
        ApplyTweak(Globals.SamusWalkingSpeedRightOffset, (byte)num_tweak_samus_speed.Value);

        ApplyTweak(Globals.SamusRollingSpeedLeftOffset, (byte)num_tweak_morph_speed.Value);
        ApplyTweak(Globals.SamusRollingSpeedRightOffset, (byte)num_tweak_morph_speed.Value);

        ApplyTweak(Globals.SamusMidairSpeedLeftOffset, (byte)num_tweak_air_speed.Value);
        ApplyTweak(Globals.SamusMidairSpeedRightOffset, (byte)num_tweak_air_speed.Value);

        //Weapons Tweaks
        if (chb_tweak_smooth_missile.Checked)
            ApplyTweak(Globals.MissileConsistentSpeedOffset, Globals.MissileConsistentSpeedValues);
        else ApplyTweak(Globals.MissileConsistentSpeedOffset, Globals.MissileConsistentSpeedStandard);

        ApplyTweak(Globals.BombExplosionTimerOffset, (byte)num_tweak_bomb_timer.Value);

        //Drops and Items
        if (chb_tweak_fanfare.Checked)
            ApplyTweak(Globals.ETankJingleOffset, Globals.ETankJingleValues);
        else ApplyTweak(Globals.ETankJingleOffset, Globals.ETankJingleStandard);

        ApplyTweak(Globals.LargeEnergyRestoreAmountOffset, (byte)num_tweak_amount_large_energy.Value);

        ApplyTweak(Globals.SmallEnergyRestoreAmountOffset, (byte)num_tweak_small_energy_amount.Value);

        ApplyTweak(Globals.MissileRestoreAmountOffset, (byte)num_tweak_missile_restore.Value);

        //misc
        if (chb_tweak_infinite_spin.Checked)
            ApplyTweak(Globals.InfiniteSpinJumpOffset, Globals.InfiniteSpinJumpValues);
        else ApplyTweak(Globals.InfiniteSpinJumpOffset, Globals.InfiniteSpinJumpStandard);

        if (chb_tweak_debug_menu.Checked)
            ApplyTweak(Globals.EnableDebugMenuOffset, Globals.EnableDebugMenuValues);
        else ApplyTweak(Globals.EnableDebugMenuOffset, Globals.EnableDebugMenuStandard);

        if (chb_tweak_music_plays_pause.Checked)
            ApplyTweak(Globals.MusicKeepPlayingOnPauseOffset, Globals.MusicKeepPlayingOnPauseValues);
        else ApplyTweak(Globals.MusicKeepPlayingOnPauseOffset, Globals.MusicKeepPlayingOnPauseStandard);

        if (chb_tweak_hatches_beam.Checked)
            ApplyTweak(Globals.HatchesVulnerableToBeamOffset, Globals.HatchesVulnerableToBeamValues);
        else ApplyTweak(Globals.HatchesVulnerableToBeamOffset, Globals.HatchesVulnerableToBeamStandard);

        ApplyTweak(Globals.AmountsOfMissileToOpenHatchOffset, (byte)num_tweak_missiles_hatch.Value);
    }
}