namespace Azuremyst.Models.Acore.World;

public partial class AreatableDbc
{
    public int Id { get; set; }

    public int ContinentId { get; set; }

    public int ParentAreaId { get; set; }

    public int AreaBit { get; set; }

    public int Flags { get; set; }

    public int SoundProviderPref { get; set; }

    public int SoundProviderPrefUnderwater { get; set; }

    public int AmbienceId { get; set; }

    public int ZoneMusic { get; set; }

    public int IntroSound { get; set; }

    public int ExplorationLevel { get; set; }

    public string? AreaNameLangEnUs { get; set; }

    public string? AreaNameLangEnGb { get; set; }

    public string? AreaNameLangKoKr { get; set; }

    public string? AreaNameLangFrFr { get; set; }

    public string? AreaNameLangDeDe { get; set; }

    public string? AreaNameLangEnCn { get; set; }

    public string? AreaNameLangZhCn { get; set; }

    public string? AreaNameLangEnTw { get; set; }

    public string? AreaNameLangZhTw { get; set; }

    public string? AreaNameLangEsEs { get; set; }

    public string? AreaNameLangEsMx { get; set; }

    public string? AreaNameLangRuRu { get; set; }

    public string? AreaNameLangPtPt { get; set; }

    public string? AreaNameLangPtBr { get; set; }

    public string? AreaNameLangItIt { get; set; }

    public string? AreaNameLangUnk { get; set; }

    public uint AreaNameLangMask { get; set; }

    public int FactionGroupMask { get; set; }

    public int LiquidTypeId1 { get; set; }

    public int LiquidTypeId2 { get; set; }

    public int LiquidTypeId3 { get; set; }

    public int LiquidTypeId4 { get; set; }

    public float MinElevation { get; set; }

    public float AmbientMultiplier { get; set; }

    public int Lightid { get; set; }
}
