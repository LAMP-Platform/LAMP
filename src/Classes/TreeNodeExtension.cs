namespace LAMP;

/// <summary>
/// An LAMP specific extension of <see cref="System.Windows.Forms.TreeNode"/> for use with transition bytecodes.
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