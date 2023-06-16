using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Pointer
{
    [JsonConstructor]
    public Pointer (int offset)
    {
        Offset = offset;

        //calculating bank and pointer
        int bankNr = Offset / 0x4000;
        Bank = bankNr;

        int bOff = bankNr * 0x4000;
        bOff = Offset - bOff + 0x4000;
        bOffset = bOff;
    }

    public Pointer (int bank, int pointer)
    {
        Bank = bank;
        bOffset = pointer;

        //calculating direct offset
        int offset = (int)((pointer - 0x4000) + bank * 0x4000);
        Offset = offset;
    }

    public int Offset { get; set; }
    public int Bank { get; set; }
    public int bOffset { get; set; }

    public bool Add(int amount) //returns true if added amount is still inside the bank
    {
        Offset += amount;

        int bankNr = Offset / 0x4000;
        int bOff = bankNr * 0x4000;
        bOff = Offset - bOff + 0x4000;
        bOffset = bOff;
        if (bankNr != Bank)
        {
            Bank = bankNr;
            return false;
        }
        return true;
    }

    public static Pointer operator +(Pointer a, int b) 
        => new Pointer (a.Offset + b);
    public static Pointer operator +(Pointer a, Pointer b)
        => new Pointer(a.Offset + b.Offset);
    public static implicit operator int(Pointer a) 
        => a.Offset;
}
