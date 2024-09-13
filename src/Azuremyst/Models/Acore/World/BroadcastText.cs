namespace Azuremyst.Models.Acore.World;

public partial class BroadcastText
{
    public uint Id { get; set; }

    public int? LanguageId { get; set; }

    public string? MaleText { get; set; }

    public string? FemaleText { get; set; }

    public int? EmoteId1 { get; set; }

    public int? EmoteId2 { get; set; }

    public int? EmoteId3 { get; set; }

    public int? EmoteDelay1 { get; set; }

    public int? EmoteDelay2 { get; set; }

    public int? EmoteDelay3 { get; set; }

    public int? SoundEntriesId { get; set; }

    public int? EmotesId { get; set; }

    public int? Flags { get; set; }

    public short? VerifiedBuild { get; set; }
}
