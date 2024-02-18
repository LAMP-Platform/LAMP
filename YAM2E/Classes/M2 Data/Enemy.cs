using System.Drawing;
using System.Text.Json.Serialization;
using System.Web;

namespace LAMP.Classes;

public class Enemy
{
    public byte Number { get; set; }
    public byte Type { get; set; }
    public byte sX { get; set; }
    public byte sY { get; set; }

    /// <summary>
    /// Unused
    /// </summary>
    public string LocationInfo = "";

    [JsonConstructor]
    public Enemy() { }
    public Enemy(byte number, byte type, byte x, byte y)
    {
        Number = number;
        Type = type;
        sX = x;
        sY = y;
    }

    /// <summary>
    /// Returns the absolute position of the enemy in the area
    /// </summary>
    /// <param name="screen"></param>
    /// <returns></returns>
    public Point GetPosition(int screen)
    {
        //calculating actual position in the area
        int screenY = (int)(screen / 16);
        int screenX = screen % 16;

        return new Point(screenX * 256 + sX - 8, screenY * 256 + sY - 8);
    }
}
