using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace YAM2E
{
    static class Globals
    {
        public static bool rom_loaded = false;

        //Editable Color definitons
        public static Color cBlack = Color.FromArgb(255, 0x00, 0x00, 0x00);
        public static Color cDarkGray = Color.FromArgb(255, 0x6b, 0x6b, 0x6b);
        public static Color cLightGray = Color.FromArgb(255, 0xa5, 0xa5, 0xa5);
        public static Color cWhite = Color.FromArgb(255, 0xef, 0xef, 0xef);
        public static Color cTileSelector = Color.FromArgb(255, 0xFF, 0, 0);
        public static Color cTileSelection = Color.FromArgb(255, 0x46, 0xAA, 0xFF);

        //public static Color cBlack = Color.FromArgb(255, 0, 0, 0);
        //public static Color cDarkGray = Color.FromArgb(255, 0x6B, 0x6B, 0x6B);
        //public static Color cLightGray = Color.FromArgb(255, 0xA5, 0xA5, 0xA5);
        //public static Color cWhite = Color.FromArgb(255, 0xEF, 0xEF, 0xEF);

        #region Tweaks
        public static readonly int[] CenterSamusOnHorizontalMovement_Offset = { 0x96C, 0x980, 0x9F3, 0xA07 };
        public static readonly byte[] CenterSamusOnHorizontalMovement_Values = { 0x58, 0x57, 0x58, 0x59 };
        public static readonly byte[] CenterSamusOnHorizontalMovement_Standard = { 0x40, 0x3F, 0x70, 0x71 };

        public const int SamusWalkingSpeedRight_Offset = 0x1C2A;
        public const int SamusWalkingSpeedLeft_Offset = 0x1C6D;

        public const int SamusRollingSpeedRight_Offset = 0x1C99;
        public const int SamusRollingSpeedLeft_Offset = 0x1CCA;

        public const int SamusMidairSpeedRight_Offset = 0x1CFB;
        public const int SamusMidairSpeedLeft_Offset = 0x1D27;


        public const int MissileConsistentSpeed_Offset = 0x51A1;
        public static readonly byte[] MissileConsistentSpeed_Values = { 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4 };
        public static readonly byte[] MissileConsistentSpeed_Standard = { 0x0, 0x0, 0x1, 0x0, 0x0, 0x1, 0x0, 0x1, 0x0, 0x1, 0x0, 0x1, 0x1, 0x1, 0x1, 0x2, 0x1, 0x2, 0x1, 0x2, 0x2, 0x2, 0x2, 0x3, 0x2, 0x2, 0x3, 0x2, 0x3, 0x3, 0x3, 0x3, 0x4 };

        public const int BombExplosionTimer_Offset = 0x53FC;


        public static readonly int[] ETankJingle_Offset = { 0x374D, 0x3752 };
        public static readonly byte[] ETankJingle_Values = { 0x5, 0x0 };
        public static readonly byte[] ETankJingle_Standard = { 0x1, 0x1 };

        public const int LargeEnergyRestoreAmount_Offset = 0x8267;
        public const int SmallEnergyRestoreAmount_Offset = 0x8270;
        public const int MissileRestoreAmount_Offset = 0x82AC;


        public const int InfiniteSpinJump_Offset = 0x190E;
        public const int InfiniteSpinJump_Values = 0xFF;
        public const int InfiniteSpinJump_Standard = 0x56;

        public static readonly int[] EnableDebugMenu_Offset = { 0x2CB6, 0x2D02 };
        public static readonly byte[] EnableDebugMenu_Values = { 0x20, 0x28 };
        public static readonly byte[] EnableDebugMenu_Standard = { 0x28, 0x20 };

        public const int MusicKeepPlayingOnPause_Offset = 0x2CE4;
        public const byte MusicKeepPlayingOnPause_Values = 0x2;
        public const byte MusicKeepPlayingOnPause_Standard = 0x1;

        public const int DisableLowHealth_Offset = 0x58C5;
        public static readonly byte[] DisableLowHealth_Values = { 0x3E, 0x0, 0x0 };
        public static readonly byte[] DisableLowHealth_Standard = { 0xCB, 0x37, 0x3C };

        public const int HatchesVulnerableToBeam_Offset = 0xAA2E;
        public const int HatchesVulnerableToBeam_Values = 0x0;
        public const int HatchesVulnerableToBeam_Standard = 0xC0;

        public const int AmountsOfMissileToOpenHatch_Offset = 0xAA43;
        #endregion
    }

    static class ByteOp
    {
        public static bool IsBitSet(byte b, int bit)
           => (b & (1 << bit)) != 0;
    }
}
