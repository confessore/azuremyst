﻿namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Creature OnKill Reputation gain
/// </summary>
public partial class CreatureOnkillReputation
{
    /// <summary>
    /// Creature Identifier
    /// </summary>
    public uint CreatureId { get; set; }

    public short RewOnKillRepFaction1 { get; set; }

    public short RewOnKillRepFaction2 { get; set; }

    public sbyte MaxStanding1 { get; set; }

    public sbyte IsTeamAward1 { get; set; }

    public float RewOnKillRepValue1 { get; set; }

    public sbyte MaxStanding2 { get; set; }

    public sbyte IsTeamAward2 { get; set; }

    public float RewOnKillRepValue2 { get; set; }

    public byte TeamDependent { get; set; }
}
