using LAMP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAMP.Utilities;

public static class Format
{
    //This class will have methods to interpret text 
    public static Pointer StringToPointer(string input)
    {
        if (input.Length == 0) return new(0);

        //removing spaces and pre-/suffix
        input = Regex.Replace(input, @"\s+", "");
        input = input.Replace("0x", "").Replace("h", "").Replace("$", "");
        input = input.Replace("ROM", ""); //Replacing ROM (could be copied from disassembly)

        //Splitting bank and relative offset
        string[] words = input.Split(',');
        if (words.Length == 1) words = input.Split(':');
        if (words.Length == 1) words = input.Split(';');

        //Converting to Pointer
        try
        {
            if (words.Length == 2)
            {
                int bank, offset;
                if (words[0].Length == 0) bank = 0;
                else bank = int.Parse(words[0], System.Globalization.NumberStyles.HexNumber);
                if (words[1].Length == 0) offset = 0;
                else offset = int.Parse(words[1], System.Globalization.NumberStyles.HexNumber);

                return new(bank, offset);
            }
            else if (words.Length == 1)
            {
                int offset;
                if (words[0].Length == 0) offset = 0;
                else offset = int.Parse(words[0], System.Globalization.NumberStyles.HexNumber);

                return new(offset);
            }
            else
            {
                MessageBox.Show("You can only seperate one bank from an offset!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
        catch
        {
            MessageBox.Show("One of the characters input is invalid!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return null;
        }
    }

    public static string PointerToString(Pointer input)
    {
        if (Globals.bankOffsets)
        {
            StringBuilder s = new();
            s.Append(Globals.hexPrefix).Append(input.Bank.ToString("X")).Append(Globals.hexSuffix);
            s.Append(", ");
            s.Append(Globals.hexPrefix).Append(input.bOffset.ToString("X")).Append(Globals.hexSuffix);
            return s.ToString();
        } else
        {
            StringBuilder s = new();
            s.Append(Globals.hexPrefix).Append(input.Offset.ToString("X")).Append(Globals.hexSuffix);
            return s.ToString();
        }
    }
}
