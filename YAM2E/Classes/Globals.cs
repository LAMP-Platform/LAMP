using System.Collections.Generic;
using System.Drawing;
using LAMP.Classes;
using LAMP.Classes.M2_Data;
using System;
using System.Windows.Forms;

namespace LAMP;

internal static class Globals
{
    //TODO: assigned, but never used

    /// <summary>
    /// Indicates whether a Metroid 2 ROM has been loaded.
    /// </summary>
    public static bool RomLoaded = false;

    /// <summary>
    /// Path to a vanilla ROM
    /// </summary>
    public static string RomPath = "";

    #region colors
    //Editable Color definitions
    /// <summary>
    /// The color representing the black of the gameboy.
    /// </summary>
    public static Color ColorBlack = Color.FromArgb(255, 0, 0, 0);

    /// <summary>
    /// The color representing the dark gray of the gameboy.
    /// </summary>
    public static Color ColorDarkGray = Color.FromArgb(255, 0x6B, 0x6B, 0x6B);

    /// <summary>
    /// The color representing the light gray of the gameboy.
    /// </summary>
    public static Color ColorLightGray = Color.FromArgb(255, 0xA5, 0xA5, 0xA5);

    /// <summary>
    /// The color representing the white of the gameboy..
    /// </summary>
    public static Color ColorWhite = Color.FromArgb(255, 0xEF, 0xEF, 0xEF);

    /// <summary>
    /// The color used by the tile brush.
    /// </summary>
    public static Color SelectedColor = Color.FromArgb(255, 0xFF, 0, 0);

    /// <summary>
    /// The color used to mark unique screens
    /// </summary>
    public static Color UniqueScreenColor = Color.FromArgb(200, 0xFF, 0, 0);

    /// <summary>
    /// The color used for screen scroll outlines
    /// </summary>
    public static Color BorderColor = Color.Yellow;

    /// <summary>
    /// The color used by the tile selection.
    /// </summary>
    public static Color SelectionColor = Color.FromArgb(255, 0xFF, 0xFF, 0xFF);

    /// <summary>
    /// The color used to mark objects
    /// </summary>
    public static Color ObjectColor = Color.FromArgb(255, 0x32, 0xCD, 0x32);
    #endregion

    //Data dirs
    /// <summary>
    /// Root directory of the loaded Project
    /// </summary>
    public static string ProjDirectory { get; set; }
    public static string ProjName { get; set; }

    //Project
    public static Project LoadedProject { get; set; }

    //Data lists
    public static List<List<GameScreen>> Screens;
    public static List<Area> Areas;
    public static List<List<Enemy>> Objects;
    public static List<Transition> Transitions;

    //Bitmap lists
    public static Bitmap[] Metatiles = new Bitmap[128];
    public static Bitmap Tileset = new Bitmap(1, 1);
    public static Bitmap AreaBank = new Bitmap(1, 1);

    //Tileset data
    public static List<Tileset> Tilesets = new List<Tileset>();

    //Tweak data
    public static List<Tweak> Tweaks = new List<Tweak>();

    //Area data
    public static int SelectedArea = 0;
    public static int SelectedScreenX = 0;
    public static int SelectedScreenY = 0;
    public static int SelectedScreenNr = 0;

    //Border data
    public static List<Rectangle> ScrollBorders = new List<Rectangle>();

    //Transition Data
    public static bool ExpandAllOpcodes = false;

    //Data chunks
    public static List<DataChunk> DataChunks = new List<DataChunk>();

    #region User Settings
    public static bool bankOffsets = Properties.programsettings.Default.bankOffsets;
    public static string hexPrefix = Properties.programsettings.Default.hexPrefix;
    public static string hexSuffix = Properties.programsettings.Default.hexSuffix;
    #endregion
}

public static class ByteOp
{
    public static bool IsBitSet(byte b, int bit) => (b & (1 << bit)) != 0;
    public static byte SetBit(byte b, int bit) => (byte)(b | (1 << bit));
    public static byte FlipBit(byte b, int bit) => (byte)(b ^ (1 << bit));
}