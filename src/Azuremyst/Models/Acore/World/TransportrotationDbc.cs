namespace Azuremyst.Models.Acore.World;

public partial class TransportrotationDbc
{
    public int Id { get; set; }

    public int GameObjectsId { get; set; }

    public int TimeIndex { get; set; }

    public float RotX { get; set; }

    public float RotY { get; set; }

    public float RotZ { get; set; }

    public float RotW { get; set; }
}
