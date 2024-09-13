namespace Azuremyst.Models.Acore.World;

public partial class NamesprofanityDbc
{
    public uint Id { get; set; }

    public string Pattern { get; set; } = null!;

    public sbyte LanguagueId { get; set; }
}
