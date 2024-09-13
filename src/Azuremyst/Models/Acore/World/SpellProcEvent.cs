namespace Azuremyst.Models.Acore.World;

public partial class SpellProcEvent
{
    public int Entry { get; set; }

    public sbyte SchoolMask { get; set; }

    public ushort SpellFamilyName { get; set; }

    public uint SpellFamilyMask0 { get; set; }

    public uint SpellFamilyMask1 { get; set; }

    public uint SpellFamilyMask2 { get; set; }

    public uint ProcFlags { get; set; }

    public uint ProcEx { get; set; }

    public uint ProcPhase { get; set; }

    public float PpmRate { get; set; }

    public float CustomChance { get; set; }

    public uint Cooldown { get; set; }
}
