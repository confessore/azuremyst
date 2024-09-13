namespace Azuremyst.Models.Acore.World;

public partial class SkilllineabilityDbc
{
    public int Id { get; set; }

    public int SkillLine { get; set; }

    public int Spell { get; set; }

    public int RaceMask { get; set; }

    public int ClassMask { get; set; }

    public int ExcludeRace { get; set; }

    public int ExcludeClass { get; set; }

    public int MinSkillLineRank { get; set; }

    public int SupercededBySpell { get; set; }

    public int AcquireMethod { get; set; }

    public int TrivialSkillLineRankHigh { get; set; }

    public int TrivialSkillLineRankLow { get; set; }

    public int CharacterPoints1 { get; set; }

    public int CharacterPoints2 { get; set; }
}
