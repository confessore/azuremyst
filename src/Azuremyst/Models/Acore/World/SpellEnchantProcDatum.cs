namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Spell enchant proc data
/// </summary>
public partial class SpellEnchantProcDatum
{
    public uint Entry { get; set; }

    public uint CustomChance { get; set; }

    public float Ppmchance { get; set; }

    public uint ProcEx { get; set; }

    public uint AttributeMask { get; set; }
}
