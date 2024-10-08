﻿namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Chat System
/// </summary>
public partial class Command
{
    public string Name { get; set; } = null!;

    public byte Security { get; set; }

    public string? Help { get; set; }
}
