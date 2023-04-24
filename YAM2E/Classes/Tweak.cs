using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LAMP.Classes;

internal class Tweak
{
    [JsonConstructor]
    public Tweak()
    {
    }

    public string Name { get; set; }
    public string Offset { get; set; }
    public string Replacement { get; set; }
    public string Apply { get; set; }
}
