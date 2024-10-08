﻿namespace Azuremyst.Models.Acore.Characters;

public partial class ArenaTeamMember
{
    public uint ArenaTeamId { get; set; }

    public uint Guid { get; set; }

    public ushort WeekGames { get; set; }

    public ushort WeekWins { get; set; }

    public ushort SeasonGames { get; set; }

    public ushort SeasonWins { get; set; }

    public short PersonalRating { get; set; }
}
