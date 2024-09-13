namespace Azuremyst.Models.Acore.World;

public partial class TalentDbc
{
    public int Id { get; set; }

    public int TabId { get; set; }

    public int TierId { get; set; }

    public int ColumnIndex { get; set; }

    public int SpellRank1 { get; set; }

    public int SpellRank2 { get; set; }

    public int SpellRank3 { get; set; }

    public int SpellRank4 { get; set; }

    public int SpellRank5 { get; set; }

    public int SpellRank6 { get; set; }

    public int SpellRank7 { get; set; }

    public int SpellRank8 { get; set; }

    public int SpellRank9 { get; set; }

    public int PrereqTalent1 { get; set; }

    public int PrereqTalent2 { get; set; }

    public int PrereqTalent3 { get; set; }

    public int PrereqRank1 { get; set; }

    public int PrereqRank2 { get; set; }

    public int PrereqRank3 { get; set; }

    public int Flags { get; set; }

    public int RequiredSpellId { get; set; }

    public int CategoryMask1 { get; set; }

    public int CategoryMask2 { get; set; }
}
