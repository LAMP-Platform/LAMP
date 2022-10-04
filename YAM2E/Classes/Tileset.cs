using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Tileset
{
    [JsonConstructor]
    public Tileset(int id)
    {
    }

    public string Name { get; set; } = "";
    public Pointer GfxOffset { get; set; } = new Pointer(0x0);
    public int MetatileTable { get; set; } = 0;
    public int CollisionTable { get; set; } = 0;
    public int SolidityTable { get; set; } = 0;
}