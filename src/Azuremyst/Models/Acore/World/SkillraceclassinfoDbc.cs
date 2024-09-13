namespace Azuremyst.Models.Acore.World;

public partial class SkillraceclassinfoDbc
{
    public int Id { get; set; }

    public int SkillId { get; set; }

    public int RaceMask { get; set; }

    public int ClassMask { get; set; }

    public int Flags { get; set; }

    public int MinLevel { get; set; }

    public int SkillTierId { get; set; }

    public int SkillCostIndex { get; set; }
}
