namespace Azuremyst.Models.Acore.World;

public partial class CreatureEquipTemplate
{
    public uint CreatureId { get; set; }

    public byte Id { get; set; }

    public uint ItemId1 { get; set; }

    public uint ItemId2 { get; set; }

    public uint ItemId3 { get; set; }

    public int? VerifiedBuild { get; set; }
}
