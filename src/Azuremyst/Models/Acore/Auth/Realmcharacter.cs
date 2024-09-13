namespace Azuremyst.Models.Acore.Auth;

/// <summary>
/// Realm Character Tracker
/// </summary>
public partial class Realmcharacter
{
    public uint Realmid { get; set; }

    public uint Acctid { get; set; }

    public byte Numchars { get; set; }
}
