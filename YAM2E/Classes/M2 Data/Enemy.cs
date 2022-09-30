using System.Drawing;
using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Enemy
{
    public byte Number { get; set; }
    public byte Type { get; set; }
    public byte sX { get; set; }
    public byte sY { get; set; }

    [JsonConstructor]
    public Enemy() { }
    public Enemy(byte number, byte type, byte x, byte y)
    {
        Number = number;
        Type = type;
        sX = x;
        sY = y;
    }

    public Point GetPosition(int screen)
    {
        //calculating actual position in the area
        int screenY = (int)(screen / 16);
        int screenX = screen - screenY * 16;

        return new Point(screenX * 256 + sX - 8, screenY * 256 + sY - 8);
    }
}
