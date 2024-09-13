namespace Azuremyst.Models.Acore.World;

public partial class EmotesDbc
{
    public int Id { get; set; }

    public string? EmoteSlashCommand { get; set; }

    public int AnimId { get; set; }

    public int EmoteFlags { get; set; }

    public int EmoteSpecProc { get; set; }

    public int EmoteSpecProcParam { get; set; }

    public int EventSoundId { get; set; }
}
