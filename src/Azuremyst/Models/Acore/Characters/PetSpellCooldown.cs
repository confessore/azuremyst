namespace Azuremyst.Models.Acore.Characters;

public partial class PetSpellCooldown
{
    /// <summary>
    /// Global Unique Identifier, Low part
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Spell Identifier
    /// </summary>
    public uint Spell { get; set; }

    public uint? Category { get; set; }

    public uint Time { get; set; }
}
