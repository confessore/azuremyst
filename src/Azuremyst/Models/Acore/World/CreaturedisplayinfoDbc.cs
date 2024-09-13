namespace Azuremyst.Models.Acore.World;

public partial class CreaturedisplayinfoDbc
{
    public int Id { get; set; }

    public int ModelId { get; set; }

    public int SoundId { get; set; }

    public int ExtendedDisplayInfoId { get; set; }

    public float CreatureModelScale { get; set; }

    public int CreatureModelAlpha { get; set; }

    public string? TextureVariation1 { get; set; }

    public string? TextureVariation2 { get; set; }

    public string? TextureVariation3 { get; set; }

    public string? PortraitTextureName { get; set; }

    public int BloodLevel { get; set; }

    public int BloodId { get; set; }

    public int NpcsoundId { get; set; }

    public int ParticleColorId { get; set; }

    public int CreatureGeosetData { get; set; }

    public int ObjectEffectPackageId { get; set; }
}
