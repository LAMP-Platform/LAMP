using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq.Expressions;

namespace LAMP.Classes;

public class Project
{
    //constructor
    public Project()
    {
    }

    public bool OptimizeObjectData { get; set; } = false;
    public bool useTilesets { get; set; } = true;
    public string ProjectSpecificROM { get; set; } = "";

    //Transition specific Data
    public List<TransitionOpcode> TransitionOpcodes { get; set; } = GenerateStandardOpcodes();

    static List<TransitionOpcode> GenerateStandardOpcodes()
    {
        List<TransitionOpcode> result = new()
        {
            new TransitionOpcode("End Transition [0;1](FF)"),
            new TransitionOpcode("Data Block Transfer [0;1](0), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
            new TransitionOpcode("Save BG Tileset source [0;1](1), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
            new TransitionOpcode("Save Sprite Tileset source [0;1](2), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
            new TransitionOpcode("Select metatile table [0](1), Table [1]"),
            new TransitionOpcode("Select collision table [0](2), Table [1]"),
            new TransitionOpcode("Select solidity table [0](3), Table [1]"),
            new TransitionOpcode("Warp [0](4), to Bank [1], at X [3], and Y [2]"),
        };


        return result;
    }
}
