namespace Azuremyst.Models.Acore.Auth;

public partial class SecretDigest
{
    public uint Id { get; set; }

    public string Digest { get; set; } = null!;
}
