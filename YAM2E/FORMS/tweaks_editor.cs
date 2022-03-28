using System;
using System.Windows.Forms;
using YAM2E.Classes;

namespace YAM2E.FORMS
{
    public partial class tweaks_editor : Form
    {
        public static tweaks_editor Current;

        public tweaks_editor()
        {
            InitializeComponent();
            Current = this;
        }

        public void ApplyTweak(int offset, byte value)
            => Editor.ROM[offset] = value;

        public void ApplyTweak(int offset, byte[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Editor.ROM[offset + i] = values[i];
        }

        public void ApplyTweak(int[] offsets, byte[] values)
        {
            for (int i = 0; i < values.Length; i++)
                Editor.ROM[offsets[i]] = values[i];
        }

        private void btn_close_tweaks_Click(object sender, EventArgs e)
            => Close();

        private void btn_apply_tweaks_Click(object sender, EventArgs e)
            => apply_tweaks();

        private void apply_tweaks()
        {
            //Samus tweaks
            if (chb_tweak_center_samus.Checked)
                ApplyTweak(Globals.CenterSamusOnHorizontalMovement_Offset, Globals.CenterSamusOnHorizontalMovement_Values);
            else ApplyTweak(Globals.CenterSamusOnHorizontalMovement_Offset, Globals.CenterSamusOnHorizontalMovement_Standard);

            if (chb_tweak_disable_health_alarm.Checked)
                ApplyTweak(Globals.DisableLowHealth_Offset, Globals.DisableLowHealth_Values);
            else ApplyTweak(Globals.DisableLowHealth_Offset, Globals.DisableLowHealth_Standard);

            ApplyTweak(Globals.SamusWalkingSpeedLeft_Offset, (byte)num_tweak_samus_speed.Value);
            ApplyTweak(Globals.SamusWalkingSpeedRight_Offset, (byte)num_tweak_samus_speed.Value);

            ApplyTweak(Globals.SamusRollingSpeedLeft_Offset, (byte)num_tweak_morph_speed.Value);
            ApplyTweak(Globals.SamusRollingSpeedRight_Offset, (byte)num_tweak_morph_speed.Value);

            ApplyTweak(Globals.SamusMidairSpeedLeft_Offset, (byte)num_tweak_air_speed.Value);
            ApplyTweak(Globals.SamusMidairSpeedRight_Offset, (byte)num_tweak_air_speed.Value);

            //Weapons Tweaks
            if (chb_tweak_smooth_missile.Checked)
                ApplyTweak(Globals.MissileConsistentSpeed_Offset, Globals.MissileConsistentSpeed_Values);
            else ApplyTweak(Globals.MissileConsistentSpeed_Offset, Globals.MissileConsistentSpeed_Standard);

            ApplyTweak(Globals.BombExplosionTimer_Offset, (byte)num_tweak_bomb_timer.Value);

            //Drops and Items
            if (chb_tweak_fanfare.Checked)
                ApplyTweak(Globals.ETankJingle_Offset, Globals.ETankJingle_Values);
            else ApplyTweak(Globals.ETankJingle_Offset, Globals.ETankJingle_Standard);

            ApplyTweak(Globals.LargeEnergyRestoreAmount_Offset, (byte)num_tweak_amount_large_energy.Value);

            ApplyTweak(Globals.SmallEnergyRestoreAmount_Offset, (byte)num_tweak_small_energy_amount.Value);

            ApplyTweak(Globals.MissileRestoreAmount_Offset, (byte)num_tweak_missile_restore.Value);

            //misc
            if (chb_tweak_infinite_spin.Checked)
                ApplyTweak(Globals.InfiniteSpinJump_Offset, Globals.InfiniteSpinJump_Values);
            else ApplyTweak(Globals.InfiniteSpinJump_Offset, Globals.InfiniteSpinJump_Standard);

            if (chb_tweak_debug_menu.Checked)
                ApplyTweak(Globals.EnableDebugMenu_Offset, Globals.EnableDebugMenu_Values);
            else ApplyTweak(Globals.EnableDebugMenu_Offset, Globals.EnableDebugMenu_Standard);

            if (chb_tweak_music_plays_pause.Checked)
                ApplyTweak(Globals.MusicKeepPlayingOnPause_Offset, Globals.MusicKeepPlayingOnPause_Values);
            else ApplyTweak(Globals.MusicKeepPlayingOnPause_Offset, Globals.MusicKeepPlayingOnPause_Standard);

            if (chb_tweak_hatches_beam.Checked)
                ApplyTweak(Globals.HatchesVulnerableToBeam_Offset, Globals.HatchesVulnerableToBeam_Values);
            else ApplyTweak(Globals.HatchesVulnerableToBeam_Offset, Globals.HatchesVulnerableToBeam_Standard);

            ApplyTweak(Globals.AmountsOfMissileToOpenHatch_Offset, (byte)num_tweak_missiles_hatch.Value);
        }
    }
}
