namespace Azuremyst.Models.Acore.Characters;

public partial class CharacterSpellCooldown
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

    /// <summary>
    /// Item Identifier
    /// </summary>
    public uint Item { get; set; }

    public uint Time { get; set; }

    public byte NeedSend { get; set; }
}
