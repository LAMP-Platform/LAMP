namespace LAMP;

/// <summary>
/// Describes different ways on how bytes can be read.
/// </summary>
public enum ReadByte
{
    /// <summary>
    /// Whether to read a whole Byte.
    /// </summary>
    WholeByte,

    /// <summary>
    /// Whether to read the high nibble (first 4 bits).
    /// </summary>
    HighNibble,

    /// <summary>
    /// Whether to read the low nibble (last 4 bits).
    /// </summary>
    LowNibble,

    /// <summary>
    /// Whether to read a Pointer.
    /// </summary>
    Pointer
}