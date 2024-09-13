namespace Azuremyst.Models.Acore.World;

public partial class CreatureClasslevelstat
{
    public byte Level { get; set; }

    public byte Class { get; set; }

    public uint Basehp0 { get; set; }

    public uint Basehp1 { get; set; }

    public uint Basehp2 { get; set; }

    public uint Basemana { get; set; }

    public uint Basearmor { get; set; }

    public uint Attackpower { get; set; }

    public uint Rangedattackpower { get; set; }

    public float DamageBase { get; set; }

    public float DamageExp1 { get; set; }

    public float DamageExp2 { get; set; }

    public string? Comment { get; set; }
}
