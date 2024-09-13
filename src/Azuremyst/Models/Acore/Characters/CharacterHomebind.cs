namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterHomebind
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort MapId { get; set; }

    /// <summary>
    /// Zone Identifier
    /// </summary>
    public ushort ZoneId { get; set; }

    public float PosX { get; set; }

    public float PosY { get; set; }

    public float PosZ { get; set; }

    public float PosO { get; set; }
}
