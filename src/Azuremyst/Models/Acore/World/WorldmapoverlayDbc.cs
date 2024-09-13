namespace Azuremyst.Models.Acore.World;

public partial class WorldmapoverlayDbc
{
    public int Id { get; set; }

    public int MapAreaId { get; set; }

    public int AreaId1 { get; set; }

    public int AreaId2 { get; set; }

    public int AreaId3 { get; set; }

    public int AreaId4 { get; set; }

    public int MapPointX { get; set; }

    public int MapPointY { get; set; }

    public string? TextureName { get; set; }

    public int TextureWidth { get; set; }

    public int TextureHeight { get; set; }

    public int OffsetX { get; set; }

    public int OffsetY { get; set; }

    public int HitRectTop { get; set; }

    public int HitRectLeft { get; set; }

    public int HitRectBottom { get; set; }

    public int HitRectRight { get; set; }
}
