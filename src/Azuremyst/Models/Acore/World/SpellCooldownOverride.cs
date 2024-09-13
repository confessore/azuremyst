namespace Azuremyst.Models.Acore.World;

public partial class SpellCooldownOverride
{
    public uint Id { get; set; }

    public uint RecoveryTime { get; set; }

    public uint CategoryRecoveryTime { get; set; }

    public uint StartRecoveryTime { get; set; }

    public uint StartRecoveryCategory { get; set; }

    public string? Comment { get; set; }
}
