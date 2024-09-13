namespace Azuremyst.Models.Acore.Auth;

/// <summary>
/// Banned IPs
/// </summary>
public partial class IpBanned
{
    public string Ip { get; set; } = null!;

    public uint Bandate { get; set; }

    public uint Unbandate { get; set; }

    public string Bannedby { get; set; } = null!;

    public string Banreason { get; set; } = null!;
}
