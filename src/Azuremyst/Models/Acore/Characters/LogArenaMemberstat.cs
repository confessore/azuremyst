namespace Azuremyst.Models.Acore.Characters;

public partial class LogArenaMemberstat
{
    public uint FightId { get; set; }

    public byte MemberId { get; set; }

    public string Name { get; set; } = null!;

    public uint Guid { get; set; }

    public uint Team { get; set; }

    public uint Account { get; set; }

    public string Ip { get; set; } = null!;

    public uint Damage { get; set; }

    public uint Heal { get; set; }

    public uint Kblows { get; set; }
}
