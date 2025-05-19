using LAMP.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes;

public class TweakValue : INamedResource
{
    /// <summary>
    /// The type of the <see cref="TweakValue"/>. Defines how the Value(s) will be interpreted.
    /// </summary>
    public TweakDataTypes Type { get; set; }

    /// <summary>
    /// The value for the tweak. Cannot be used if multiple values are supplied
    /// </summary>
    [JsonIgnore]
    public byte Value => Values.Count >= 1 ? throw new InvalidOperationException("There is more than 1 value stored for this object") : Values[0];
    public List<byte> Values { get; set; } = new List<byte>();

    /// <summary>
    /// Name of the Tweak Value
    /// </summary>
    public string Name { get; set; }
}

public enum TweakDataTypes
{
    Byte,
    Short,
    Pointer,
    Flag
}