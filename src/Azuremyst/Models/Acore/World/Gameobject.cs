﻿namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Gameobject System
/// </summary>
public partial class Gameobject
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Gameobject Identifier
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// Map Identifier
    /// </summary>
    public ushort Map { get; set; }

    /// <summary>
    /// Zone Identifier
    /// </summary>
    public ushort ZoneId { get; set; }

    /// <summary>
    /// Area Identifier
    /// </summary>
    public ushort AreaId { get; set; }

    public byte SpawnMask { get; set; }

    public uint PhaseMask { get; set; }

    public float PositionX { get; set; }

    public float PositionY { get; set; }

    public float PositionZ { get; set; }

    public float Orientation { get; set; }

    public float Rotation0 { get; set; }

    public float Rotation1 { get; set; }

    public float Rotation2 { get; set; }

    public float Rotation3 { get; set; }

    public int Spawntimesecs { get; set; }

    public byte Animprogress { get; set; }

    public byte State { get; set; }

    public string? ScriptName { get; set; }

    public int? VerifiedBuild { get; set; }

    public string? Comment { get; set; }
}
