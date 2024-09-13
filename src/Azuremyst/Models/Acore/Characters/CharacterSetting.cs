namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player Settings
/// </summary>
public partial class CharacterSetting
{
    public uint Guid { get; set; }

    public string Source { get; set; } = null!;

    public string? Data { get; set; }
}
