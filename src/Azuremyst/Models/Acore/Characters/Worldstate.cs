namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Variable Saves
/// </summary>
public partial class Worldstate
{
    public uint Entry { get; set; }

    public uint Value { get; set; }

    public string? Comment { get; set; }
}
