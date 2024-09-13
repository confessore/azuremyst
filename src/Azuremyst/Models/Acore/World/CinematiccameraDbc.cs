namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Cinematic camera DBC
/// </summary>
public partial class CinematiccameraDbc
{
    public int Id { get; set; }

    public string? Model { get; set; }

    public int SoundEntry { get; set; }

    public float LocationX { get; set; }

    public float LocationY { get; set; }

    public float LocationZ { get; set; }

    public float Rotation { get; set; }
}
