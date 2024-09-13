namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Spell System
/// </summary>
public partial class SpellLinkedSpell
{
    public int SpellTrigger { get; set; }

    public int SpellEffect { get; set; }

    public byte Type { get; set; }

    public string Comment { get; set; } = null!;
}
