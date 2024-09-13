namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Grid Loading System
/// </summary>
public partial class GameobjectRespawn
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public uint RespawnTime { get; set; }

    public ushort MapId { get; set; }

    /// <summary>
    /// Instance Identifier
    /// </summary>
    public uint InstanceId { get; set; }
}
