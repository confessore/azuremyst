﻿namespace Azuremyst.Models.Acore.Characters;

public partial class CharacterArenaStat
{
    public uint Guid { get; set; }

    public byte Slot { get; set; }

    public ushort MatchMakerRating { get; set; }

    public short MaxMmr { get; set; }
}
