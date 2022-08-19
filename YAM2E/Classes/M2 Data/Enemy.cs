using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes
{
    public class Enemy
    {
        public byte Number;
        public byte Type;
        public byte sX;
        public byte sY;

        public int X;
        public int Y;

        public int Screen;

        public Enemy(byte number, byte type, byte x, byte y, int screen)
        {
            Number = number;
            Type = type;
            sX = x;
            sY = y;
            Screen = screen;

            //calculating actual position in the area
            int screenY = (int)(screen / 16);
            int screenX = screen - screenY * 16;

            X = screenX * 256 + x - 8;
            Y = screenY * 256 + y - 8;
        }
    }
}
