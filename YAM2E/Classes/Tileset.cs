using System.Text.Json.Serialization;

namespace LAMP.Classes;

public class Tileset
{
    [JsonConstructor]
    public Tileset() {}

    public string Name { get; set; } = "";
    public Pointer GfxOffset { get; set; } = new Pointer(0x0);
    public int MetatileTable { get; set; } = 0;
    public int CollisionTable { get; set; } = 0;
    public int SolidityTable { get; set; } = 0;
}

/// <summary>
/// This class should only be used to export all the data associated with a tileset
/// </summary>
public class ExportTileset
{
    [JsonConstructor]
    public ExportTileset() { }

    public string Name { get; set; } = "";
    public byte[] Graphics { get; set; } = new byte[2048];
    public byte[] MetatileTable { get; set; } = new byte[512];
    public byte[] CollisionTable { get; set; } = new byte[256];
    public byte[] SolidityTable { get; set; } = new byte[4];
}