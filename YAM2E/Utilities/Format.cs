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

    /// <summary>
    /// Takes a string and interpretes it into a pointer object.
    /// You can input a bank + offset or a direct offset.
    /// Does not care about pre- and suffixes.
    /// </summary>
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


    /// <summary>
    /// Takes a pointer and represents it as a string.
    /// Uses the users preffered styling for offset splits
    /// and pre- and suffixes.
    /// </summary>
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

    /// <summary>
    /// Takes a string and interprets it as a hex intiger.
    /// Only allows a direct value.
    /// Does not care about pre- and suffixes.
    /// </summary>
    public static int StringToInt(string input, int maxValue = 0)
    {
        if (input.Length == 0) return 0;

        //removing spaces and pre-/suffix
        input = Regex.Replace(input, @"\s+", "");
        input = input.Replace("0x", "").Replace("h", "").Replace("$", "");
        input = input.Replace("ROM", ""); //Replacing ROM (could be copied from disassembly)

        //Splitting at "splitters" to throw error at user for being a bad person
        string[] words = input.Split(',');
        if (words.Length == 1) words = input.Split(':');
        if (words.Length == 1) words = input.Split(';');

        //Converting to Int
        try
        {
            if (words.Length == 1)
            {
                int val;
                if (words[0].Length == 0) val = 0;
                else val = int.Parse(words[0], System.Globalization.NumberStyles.HexNumber);

                if (maxValue != 0) return Math.Min(val, maxValue);
                return val;
            }
            else
            {
                MessageBox.Show("Please only input one value!\nThis field does not accept banks!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return 0;
        }
        catch
        {
            MessageBox.Show("One of the characters input is invalid!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return 0;
        }
    }


    /// <summary>
    /// Takes an integer and represents it as a hex string.
    /// Adds the users preffered pre- and suffix.
    /// </summary>
    public static string IntToString(int input)
    {
        StringBuilder s = new();
        s.Append(Globals.hexPrefix).Append(input.ToString("X")).Append(Globals.hexSuffix);
        return s.ToString();
    }
}
