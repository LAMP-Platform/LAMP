using System;

namespace LAMP;

/// <summary>
/// All the things that LAMP will compile onto a ROM
/// </summary>
[Flags]
public enum CompilationItem
{
    None = 0,
    Screens = 1,
    Areas = 2,
    Objects = 4,
    Transitions = 8,
    Save = 16,
    DataChunk = 32,
    Palettes = 64,
}
