﻿namespace Azuremyst.Models.Acore.Characters;

public partial class BattlegroundDeserter
{
    /// <summary>
    /// characters.guid
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// type of the desertion
    /// </summary>
    public byte Type { get; set; }

    /// <summary>
    /// datetime of the desertion
    /// </summary>
    public DateTime Datetime { get; set; }
}
