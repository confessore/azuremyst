namespace Azuremyst.Models.Acore.World;

public partial class PvpdifficultyDbc
{
    public int Id { get; set; }

    public int MapId { get; set; }

    public int RangeIndex { get; set; }

    public int MinLevel { get; set; }

    public int MaxLevel { get; set; }

    public int Difficulty { get; set; }
}
