using LAMP.Classes.M2_Data;
using System.Drawing;

namespace LAMP.Classes;

internal class RoomTile
{
    public RoomTile() { }

    public GameScreen Screen { get; set; }
    public int ScreenNr { get; set; }
    public int Area { get; set; }
    public Point Position { get; set; }
    public bool Unused { get; set; } = false;

    public void ReplaceTile(byte tileID)
    {
        int tx = Position.X / 16;
        int ty = Position.Y / 16;
        int count = ty * 16 + tx;
        Screen.Data[count] = tileID;
    }
}
