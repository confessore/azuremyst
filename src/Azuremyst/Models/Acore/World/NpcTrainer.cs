namespace Azuremyst.Models.Acore.World;

public partial class NpcTrainer
{
    public uint Id { get; set; }

    public int SpellId { get; set; }

    public uint MoneyCost { get; set; }

    public ushort ReqSkillLine { get; set; }

    public ushort ReqSkillRank { get; set; }

    public byte ReqLevel { get; set; }

    public uint ReqSpell { get; set; }
}
