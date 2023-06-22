using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAMP;

public static class ByteOp
{
    public static bool IsBitSet(byte b, int bit) => (b & (1 << bit)) != 0;
    public static byte SetBit(byte b, int bit, int val)
    {
        bit %= 8;
        val %= 2;

        byte bitMask = (byte)(1 << bit);
        return (byte)(val == 1 ? b | bitMask : b & ~bitMask);
    }
    public static byte FlipBit(byte b, int bit) => (byte)(b ^ (1 << bit));
}