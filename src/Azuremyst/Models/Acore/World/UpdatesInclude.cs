﻿namespace Azuremyst.Models.Acore.World;

/// <summary>
/// List of directories where we want to include sql updates.
/// </summary>
public partial class UpdatesInclude
{
    /// <summary>
    /// directory to include. $ means relative to the source directory.
    /// </summary>
    public string Path { get; set; } = null!;

    /// <summary>
    /// defines if the directory contains released or archived updates.
    /// </summary>
    public string State { get; set; } = null!;
}
