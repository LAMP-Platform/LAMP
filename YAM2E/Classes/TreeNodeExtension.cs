namespace YAM2E;

/// <summary>
/// An YAM2E specific extension of <see cref="System.Windows.Forms.TreeNode"/> for use with transition bytecodes.
/// </summary>
internal class TreeNodeExtension
{
    /// <summary>
    /// Whether the Node represents an Opcode. If this is <see langword="false"/>
    /// it represents a parameter for an opcode instead.
    /// </summary>
    public bool IsOpcode { get; set; }

    /// <summary>
    /// What part of the byte to read.
    /// </summary>
    public ReadByte WhichByteToRead { get; set; } = ReadByte.WholeByte;

    /// <summary>
    /// The byte to read.
    /// </summary>
    public int Byte { get; set; }

    /// <summary>
    /// The length of the Opcode.
    /// </summary>
    public int OpcodeLength { get; set; }
}

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