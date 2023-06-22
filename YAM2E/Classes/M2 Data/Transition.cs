using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace LAMP.Classes.M2_Data;

public class Transition
{
    [JsonConstructor]
    public Transition() { }

    public string Name { get; set; } = "";
    public int Number { get; set; }
    public List<byte> Data { get; set; }
    public int CopyOf { get; set; } = -1;
}
