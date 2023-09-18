using LAMP.Utilities;
using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Pointer
{
    [JsonConstructor]
    public Pointer (int Offset)
    {
        this.Offset = Offset;

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
    [JsonIgnore]
    public int Bank { get; set; }
    [JsonIgnore]
    public int bOffset { get; set; }

    public override string ToString() => Format.PointerToString(this);

    public static Pointer operator +(Pointer a, int b) 
        => new Pointer (a.Offset + b);
    public static Pointer operator +(Pointer a, Pointer b)
        => new Pointer(a.Offset + b.Offset);

    public static implicit operator int(Pointer a) 
        => a.Offset;

    public static implicit operator Pointer(int a) => new Pointer(a);
}
