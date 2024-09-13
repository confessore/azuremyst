namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterEntryPoint
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public float JoinX { get; set; }

    public float JoinY { get; set; }

    public float JoinZ { get; set; }

    public float JoinO { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public uint JoinMapId { get; set; }

    public uint TaxiPath0 { get; set; }

    public uint TaxiPath1 { get; set; }

    public uint MountSpell { get; set; }
}
