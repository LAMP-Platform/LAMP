using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using LAMP.Classes.M2_Data.GBC;

namespace LAMP.Classes.M2_Data;

/// <summary>
/// A data structure to resemble a list of GBC colors, 4 Colors per index
/// </summary>
public class Palette
{
    [JsonConstructor]
    public Palette()
    {
    }

    /// <summary>
    /// List of Color lists. Each entry has a length of 4 Colors
    /// </summary>
    public List<Color[]> Colors { get; set; } = new();
}