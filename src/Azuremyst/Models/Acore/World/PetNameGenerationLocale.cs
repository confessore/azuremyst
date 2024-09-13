namespace Azuremyst.Models.Acore.World;

public partial class PetNameGenerationLocale
{
    public uint Id { get; set; }

    public string Locale { get; set; } = null!;

    public string Word { get; set; } = null!;

    public uint Entry { get; set; }

    public byte Half { get; set; }
}
