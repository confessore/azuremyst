﻿namespace Azuremyst.Models.Acore.Auth;

/// <summary>
/// Uptime system
/// </summary>
public partial class Uptime
{
    public uint Realmid { get; set; }

    public uint Starttime { get; set; }

    public uint Uptime1 { get; set; }

    public ushort Maxplayers { get; set; }

    public string Revision { get; set; } = null!;
}
