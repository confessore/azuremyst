namespace Azuremyst.Models.Acore.World;

public partial class PlayerFactionchangeSpell
{
    public uint AllianceId { get; set; }

    public string AllianceComment { get; set; } = null!;

    public uint HordeId { get; set; }

    public string HordeComment { get; set; } = null!;
}
