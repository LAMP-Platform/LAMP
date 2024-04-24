using System.Collections.Generic;
using System.Text.Json.Serialization;
using LAMP.Interfaces;

namespace LAMP.Classes.M2_Data;

public class Transition : INamedResource
{
    [JsonConstructor]
    public Transition() { }

    public string Name { get; set; } = "";
    public int Number { get; set; }
    public List<byte> Data { get; set; }
    public int CopyOf { get; set; } = -1;
}

/// <summary>
/// This should only be used to export a Transition as a seperate file
/// </summary>
public class ExportTransition
{
    [JsonConstructor]
    public ExportTransition() {}

    public string Name { get; set; }
    public List<byte> Data { get; set; }
}