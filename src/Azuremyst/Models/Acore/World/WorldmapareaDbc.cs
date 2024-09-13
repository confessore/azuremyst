namespace Azuremyst.Models.Acore.World;

public partial class WorldmapareaDbc
{
    public int Id { get; set; }

    public int MapId { get; set; }

    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public float LocLeft { get; set; }

    public float LocRight { get; set; }

    public float LocTop { get; set; }

    public float LocBottom { get; set; }

    public int DisplayMapId { get; set; }

    public int DefaultDungeonFloor { get; set; }

    public int ParentWorldMapId { get; set; }
}
