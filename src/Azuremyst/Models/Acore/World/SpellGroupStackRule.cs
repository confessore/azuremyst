namespace Azuremyst.Models.Acore.World;

public partial class SpellGroupStackRule
{
    public uint GroupId { get; set; }

    public sbyte StackRule { get; set; }

    public string Description { get; set; } = null!;
}
