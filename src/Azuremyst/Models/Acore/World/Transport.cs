namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Transports
/// </summary>
public partial class Transport
{
    public uint Guid { get; set; }

    public uint Entry { get; set; }

    public string? Name { get; set; }

    public string ScriptName { get; set; } = null!;
}
