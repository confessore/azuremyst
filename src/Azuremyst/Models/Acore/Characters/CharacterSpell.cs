namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterSpell
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Spell Identifier
    /// </summary>
    public uint Spell { get; set; }

    public byte SpecMask { get; set; }
}
