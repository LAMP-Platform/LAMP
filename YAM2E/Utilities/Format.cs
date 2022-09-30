using LAMP.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LAMP.Utilities;

public static class Format
{
    //This class will have methods to interpret text 
    public static Pointer StringToPointer(string input)
    {
        input = "0x3, 0xA28C";
        input = Regex.Replace(input, @"\s+", "");
        string[] words = input.Split(',');

        foreach (var word in words)
        {
            System.Console.WriteLine($"<{word}>");
        }
    }
}
