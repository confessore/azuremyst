namespace Azuremyst.Models.Acore.World;

public partial class LightDbc
{
    public int Id { get; set; }

    public int ContinentId { get; set; }

    public float X { get; set; }

    public float Y { get; set; }

    public float Z { get; set; }

    public float FalloffStart { get; set; }

    public float FalloffEnd { get; set; }

    public int LightParamsId1 { get; set; }

    public int LightParamsId2 { get; set; }

    public int LightParamsId3 { get; set; }

    public int LightParamsId4 { get; set; }

    public int LightParamsId5 { get; set; }

    public int LightParamsId6 { get; set; }

    public int LightParamsId7 { get; set; }

    public int LightParamsId8 { get; set; }
}
