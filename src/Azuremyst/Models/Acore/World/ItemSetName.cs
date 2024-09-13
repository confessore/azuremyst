namespace Azuremyst.Models.Acore.World;

public partial class ItemSetName
{
    public uint Entry { get; set; }

    public string Name { get; set; } = null!;

    public byte InventoryType { get; set; }

    public int? VerifiedBuild { get; set; }
}
