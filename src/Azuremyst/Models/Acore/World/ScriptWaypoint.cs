﻿namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Script Creature waypoints
/// </summary>
public partial class ScriptWaypoint
{
    /// <summary>
    /// creature_template entry
    /// </summary>
    public uint Entry { get; set; }

    public uint Pointid { get; set; }

    public float LocationX { get; set; }

    public float LocationY { get; set; }

    public float LocationZ { get; set; }

    /// <summary>
    /// waittime in millisecs
    /// </summary>
    public uint Waittime { get; set; }

    public string? PointComment { get; set; }
}
