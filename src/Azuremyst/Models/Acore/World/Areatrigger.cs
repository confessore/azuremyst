namespace Azuremyst.Models.Acore.World;

public partial class Areatrigger
{
    public uint Entry { get; set; }

    public uint Map { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    /// <summary>
    /// Seems to be a box of size yards with center at x,y,z
    /// </summary>
    public float Radius { get; set; }

    /// <summary>
    /// Most commonly used when size is 0, but not always
    /// </summary>
    public float Length { get; set; }

    /// <summary>
    /// Most commonly used when size is 0, but not always
    /// </summary>
    public float Width { get; set; }

    /// <summary>
    /// Most commonly used when size is 0, but not always
    /// </summary>
    public float Height { get; set; }

    /// <summary>
    /// Most commonly used when size is 0, but not always
    /// </summary>
    public float Orientation { get; set; }
}
