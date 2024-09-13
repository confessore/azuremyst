namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterQueststatusRewarded
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }

    public byte Active { get; set; }
}
