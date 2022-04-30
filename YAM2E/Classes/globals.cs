using System.Drawing;

namespace YAM2E
{
    static class Globals
    {
        public static bool rom_loaded = false;

        //Editable Color definitions
        public static Color CBlack = Color.FromArgb(255, 0, 0, 0);
        public static Color CDarkGray = Color.FromArgb(255, 0x6B, 0x6B, 0x6B);
        public static Color CLightGray = Color.FromArgb(255, 0xA5, 0xA5, 0xA5);
        public static Color CWhite = Color.FromArgb(255, 0xEF, 0xEF, 0xEF);

        public static Color CTileSelector = Color.FromArgb(255, 0xFF, 0, 0);
        public static Color CTileSelection = Color.FromArgb(255, 0x46, 0xAA, 0xFF);

        //Bitmap lists
        public static Bitmap[] TilesetTiles = new Bitmap[128];
        public static Bitmap Tileset = new Bitmap(1, 1);
        public static Bitmap[] Screens = new Bitmap[59];
        public static Bitmap AreaBank = new Bitmap(1, 1);

        //Area data
        public static int[,] AreaScreens = new int[16, 16];
        public static int SelectedScreenX = 0;
        public static int SelectedScreenY = 0;

        //public static Color cBlack = Color.FromArgb(255, 0, 0, 0);
        //public static Color cDarkGray = Color.FromArgb(255, 0x6B, 0x6B, 0x6B);
        //public static Color cLightGray = Color.FromArgb(255, 0xA5, 0xA5, 0xA5);
        //public static Color cWhite = Color.FromArgb(255, 0xEF, 0xEF, 0xEF);

        #region Tweaks
        public static readonly int[] CenterSamusOnHorizontalMovementOffset = { 0x96C, 0x980, 0x9F3, 0xA07 };
        public static readonly byte[] CenterSamusOnHorizontalMovementValues = { 0x58, 0x57, 0x58, 0x59 };
        public static readonly byte[] CenterSamusOnHorizontalMovementStandard = { 0x40, 0x3F, 0x70, 0x71 };

        public const int SamusWalkingSpeedRightOffset = 0x1C2A;
        public const int SamusWalkingSpeedLeftOffset = 0x1C6D;

        public const int SamusRollingSpeedRightOffset = 0x1C99;
        public const int SamusRollingSpeedLeftOffset = 0x1CCA;

        public const int SamusMidairSpeedRightOffset = 0x1CFB;
        public const int SamusMidairSpeedLeftOffset = 0x1D27;


        public const int MissileConsistentSpeedOffset = 0x51A1;
        public static readonly byte[] MissileConsistentSpeedValues = { 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4, 0x4 };
        public static readonly byte[] MissileConsistentSpeedStandard = { 0x0, 0x0, 0x1, 0x0, 0x0, 0x1, 0x0, 0x1, 0x0, 0x1, 0x0, 0x1, 0x1, 0x1, 0x1, 0x2, 0x1, 0x2, 0x1, 0x2, 0x2, 0x2, 0x2, 0x3, 0x2, 0x2, 0x3, 0x2, 0x3, 0x3, 0x3, 0x3, 0x4 };

        public const int BombExplosionTimerOffset = 0x53FC;


        public static readonly int[] ETankJingleOffset = { 0x374D, 0x3752 };
        public static readonly byte[] ETankJingleValues = { 0x5, 0x0 };
        public static readonly byte[] ETankJingleStandard = { 0x1, 0x1 };

        public const int LargeEnergyRestoreAmountOffset = 0x8267;
        public const int SmallEnergyRestoreAmountOffset = 0x8270;
        public const int MissileRestoreAmountOffset = 0x82AC;


        public const int InfiniteSpinJumpOffset = 0x190E;
        public const int InfiniteSpinJumpValues = 0xFF;
        public const int InfiniteSpinJumpStandard = 0x56;

        public static readonly int[] EnableDebugMenuOffset = { 0x2CB6, 0x2D02 };
        public static readonly byte[] EnableDebugMenuValues = { 0x20, 0x28 };
        public static readonly byte[] EnableDebugMenuStandard = { 0x28, 0x20 };

        public const int MusicKeepPlayingOnPauseOffset = 0x2CE4;
        public const byte MusicKeepPlayingOnPauseValues = 0x2;
        public const byte MusicKeepPlayingOnPauseStandard = 0x1;

        public const int DisableLowHealthOffset = 0x58C5;
        public static readonly byte[] DisableLowHealthValues = { 0x3E, 0x0, 0x0 };
        public static readonly byte[] DisableLowHealthStandard = { 0xCB, 0x37, 0x3C };

        public const int HatchesVulnerableToBeamOffset = 0xAA2E;
        public const int HatchesVulnerableToBeamValues = 0x0;
        public const int HatchesVulnerableToBeamStandard = 0xC0;

        public const int AmountsOfMissileToOpenHatchOffset = 0xAA43;
        #endregion
    }

    static class ByteOp
    {
        public static bool IsBitSet(byte b, int bit)
           => (b & (1 << bit)) != 0;
    }
}
