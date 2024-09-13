namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Trigger System
/// </summary>
public partial class AreatriggerTeleport
{
    public uint Id { get; set; }

    public string? Name { get; set; }

    public ushort TargetMap { get; set; }

    public float TargetPositionX { get; set; }

    public float TargetPositionY { get; set; }

    public float TargetPositionZ { get; set; }

    public float TargetOrientation { get; set; }
}
