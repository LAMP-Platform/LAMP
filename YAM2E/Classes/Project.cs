using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq.Expressions;
using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Project
{
    //constructor
    public Project()
    {
    }

    public bool OptimizeObjectData { get; set; } = false;
    public bool FixVerticalObjectLoading { get; set; } = false;
    public bool useTilesets { get; set; } = true;
    public bool useAdvancedTestSettings { get; set; } = false;
    public string ProjectSpecificROM { get; set; } = "";
    public string DisassemblyPath { get; set; } = "";
    public bool BuildAssemblyWhenCompiling { get; set; } = false;
    public byte FillTile { get; set; } = 0xFF;
    public bool EnableGBCSupport { get; set; } = false;

    //Transition specific Data
    public List<TransitionOpcode> TransitionOpcodes { get; set; } = GenerateStandardOpcodes();

    public static List<TransitionOpcode> GenerateStandardOpcodes()
    {
        List<TransitionOpcode> result = new()
        {
            new TransitionOpcode("Fadeout [0](A)"),
            new TransitionOpcode("End Transition [0;1](FF)"),
            new TransitionOpcode("Warp [0](4), to Bank [1],, at Screen    X [3], and Screen Y [2]"),
            new TransitionOpcode("Branch to a new Transition [0](9), If Metroids alive <= [2;3], Transition Index [4;7](Transitions)"),
            new TransitionOpcode("Load Background Graphics [0;1](B1), from Bank [2;3], at Offset [4;7]"),
            new TransitionOpcode("Load Object Graphics [0;1](B2), from Bank [2;3], at Offset [4;7]"),
            new TransitionOpcode("Select metatile table [0](1), Table [1]"),
            new TransitionOpcode("Select collision table [0](2), Table [1]"),
            new TransitionOpcode("Select solidity table [0](3), Table [1]"),
            new TransitionOpcode("Change Acid & Spike damage [0](6), Acid Damage [2;3], Spike Damage [4;5]"),
            new TransitionOpcode("Load Special Graphics [0](D), Graphics Index [1]"),
            new TransitionOpcode("Load Music [0](C), Music Index [1]"),
            new TransitionOpcode("Enter Queen [0](8), Bank for current room [1], Camera X [6;9], Camera Y [2;5], Samus X [14;17], Samus Y [10;13]"),
            new TransitionOpcode("Retreat from Queen [0](5)"),
            new TransitionOpcode("Leave Queen [0](7)"),
            new TransitionOpcode("Data Block Transfer [0;1](00), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
            new TransitionOpcode("Save BG Tileset source [0;1](01), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
            new TransitionOpcode("Save Sprite Tileset source [0;1](02), Source Bank [2;3], Source Pointer [4;7], Destination Pointer [8;11], Length [12;15]"),
        };
        return result;
    }
}
