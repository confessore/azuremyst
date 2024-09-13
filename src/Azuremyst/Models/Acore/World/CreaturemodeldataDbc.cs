namespace Azuremyst.Models.Acore.World;

public partial class CreaturemodeldataDbc
{
    public int Id { get; set; }

    public int Flags { get; set; }

    public string? ModelName { get; set; }

    public int SizeClass { get; set; }

    public float ModelScale { get; set; }

    public int BloodId { get; set; }

    public int FootprintTextureId { get; set; }

    public float FootprintTextureLength { get; set; }

    public float FootprintTextureWidth { get; set; }

    public float FootprintParticleScale { get; set; }

    public int FoleyMaterialId { get; set; }

    public int FootstepShakeSize { get; set; }

    public int DeathThudShakeSize { get; set; }

    public int SoundId { get; set; }

    public float CollisionWidth { get; set; }

    public float CollisionHeight { get; set; }

    public float MountHeight { get; set; }

    public float GeoBoxMinX { get; set; }

    public float GeoBoxMinY { get; set; }

    public float GeoBoxMinZ { get; set; }

    public float GeoBoxMaxX { get; set; }

    public float GeoBoxMaxY { get; set; }

    public float GeoBoxMaxZ { get; set; }

    public float WorldEffectScale { get; set; }

    public float AttachedEffectScale { get; set; }

    public float MissileCollisionRadius { get; set; }

    public float MissileCollisionPush { get; set; }

    public float MissileCollisionRaise { get; set; }
}
