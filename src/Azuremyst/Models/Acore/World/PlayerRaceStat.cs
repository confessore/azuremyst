namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Stores race stats.
/// </summary>
public partial class PlayerRaceStat
{
    public byte Race { get; set; }

    public int Strength { get; set; }

    public int Agility { get; set; }

    public int Stamina { get; set; }

    public int Intellect { get; set; }

    public int Spirit { get; set; }
}
