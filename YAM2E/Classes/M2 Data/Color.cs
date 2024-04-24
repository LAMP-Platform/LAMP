using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP.Classes.M2_Data.GBC;

//A datastructure that represents a 15-bit GBC RGB Color Value
public struct Color
{
    public Color()
    {
    }

    public Color(byte R, byte G, byte B)
    {
        this.R = R;
        this.G = G;
        this.B = B;
    }

    /// <summary>
    /// The RGB-Value of the <see cref="Color"/>
    /// </summary>
    public short Value { get; private set; } = 0x0;

    /// <summary>
    /// The red component of the color. Maximum value of 0x1F (DEC 31)
    /// </summary>
    public byte R 
    { 
        get
        {
            return (byte)(Value >> 0 & 0b11111);
        }
        set
        {
            if (value > 0x1F) throw new ArgumentOutOfRangeException("Maximum allowed value is 0x1F (DEC 31)");
            this.Value = (short)((B << 10) | (G << 5) | value);
        }
    }

    /// <summary>
    /// The green component of the color. Maximum value of 0x1F (DEC 31)
    /// </summary>
    public byte G
    {
        get
        {
            return (byte)(Value >> 5 & 0b11111);
        }
        set
        {
            if (value > 0x1F) throw new ArgumentOutOfRangeException("Maximum allowed value is 0x1F (DEC 31)");
            this.Value = (short)((B << 10) | (value << 5) | R);
        }
    }

    /// <summary>
    /// The blue component of the color. Maximum value of 0x1F (DEC 31)
    /// </summary>
    public byte B
    {
        get
        {
            return (byte)(Value >> 10 & 0b11111);
        }
        set
        {
            if (value > 0x1F) throw new ArgumentOutOfRangeException("Maximum allowed value is 0x1F (DEC 31)");
            this.Value = (short)((value << 10) | (G << 5) | R);
        }
    }

    /// <summary>
    /// Returns a 15-bit GBC Color from a 24-bit PC RGB Color
    /// </summary>
    /// <returns></returns>
    public static Color FromRGB(byte R, byte G, byte B)
    {
        return new Color((byte)(R / 8), (byte)(G / 8), (byte)(B / 8));
    }
}
