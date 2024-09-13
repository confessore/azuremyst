namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Debug System
/// </summary>
public partial class Bugreport
{
    /// <summary>
    /// Identifier
    /// </summary>
    public uint Id { get; set; }

    public string Type { get; set; } = null!;

    public string Content { get; set; } = null!;
}
