﻿namespace Azuremyst.Models.Acore.World;

public partial class PoolPool
{
    public uint PoolId { get; set; }

    public uint MotherPool { get; set; }

    public float Chance { get; set; }

    public string? Description { get; set; }
}
