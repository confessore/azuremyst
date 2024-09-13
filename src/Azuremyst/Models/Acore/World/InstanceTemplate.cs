namespace Azuremyst.Models.Acore.World;

public partial class InstanceTemplate
{
    public ushort Map { get; set; }

    public ushort Parent { get; set; }

    public string Script { get; set; } = null!;

    public byte AllowMount { get; set; }
}
