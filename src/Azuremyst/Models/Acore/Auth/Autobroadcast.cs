﻿namespace Azuremyst.Models.Acore.Auth;

public partial class Autobroadcast
{
    public int Realmid { get; set; }

    public byte Id { get; set; }

    public byte? Weight { get; set; }

    public string Text { get; set; } = null!;
}
