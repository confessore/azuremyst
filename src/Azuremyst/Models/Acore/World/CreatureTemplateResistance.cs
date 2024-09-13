namespace Azuremyst.Models.Acore.World;

public partial class CreatureTemplateResistance
{
    public uint CreatureId { get; set; }

    public byte School { get; set; }

    public short? Resistance { get; set; }

    public int? VerifiedBuild { get; set; }
}
