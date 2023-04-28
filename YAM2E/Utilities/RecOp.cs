using System.Drawing;

namespace LAMP;

/// <summary>
/// Helper class to allow for mathematical operations on Rectangles
/// </summary>
public static class RecOp
{
    /// <summary>
    /// Multiplies all values of the <paramref name="input"/> by the <paramref name="value"/>
    /// </summary>
    /// <param name="input"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Rectangle Multiply(Rectangle input, int value) => new(input.X * value, input.Y * value, input.Width * value, input.Height * value);
    /// <summary>
    /// Divides all values of the <paramref name="input"/> by the <paramref name="value"/>
    /// </summary>
    /// <param name="input"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Rectangle Divide(Rectangle input, int value) => new(input.X / value, input.Y / value, input.Width / value, input.Height / value);

    /// <summary>
    /// Adds <paramref name="value"/> to the <see cref="Rectangle.Width"/> and <see cref="Rectangle.Height"/> of <paramref name="input"/>
    /// </summary>
    /// <param name="input"></param>
    /// <param name="value"></param>
    /// <returns></returns>
    public static Rectangle Add(Rectangle input, int value) => new(input.Location, input.Size + new Size(value, value));
}
