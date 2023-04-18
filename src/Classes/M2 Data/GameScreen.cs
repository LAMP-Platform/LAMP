using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data;

public class GameScreen
{
    //constructor
    [JsonConstructor]
    public GameScreen() { }
    public GameScreen(Pointer offset)
    {
        Data = new byte[256];
        Editor.ROM.ReadBytes(offset.Offset, Data, 256);
    }

    public byte[] Data { get; set; }
    public Bitmap image;
}
