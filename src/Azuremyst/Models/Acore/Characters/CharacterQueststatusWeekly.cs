﻿namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterQueststatusWeekly
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// Quest Identifier
    /// </summary>
    public uint Quest { get; set; }
}
