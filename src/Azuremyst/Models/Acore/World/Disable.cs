﻿namespace Azuremyst.Models.Acore.World;

public partial class Disable
{
    public uint SourceType { get; set; }

    public uint Entry { get; set; }

    public byte Flags { get; set; }

    public string Params0 { get; set; } = null!;

    public string Params1 { get; set; } = null!;

    public string Comment { get; set; } = null!;
}
