﻿namespace Azuremyst.Models.Acore.Characters;

public partial class CharacterAction
{
    public uint Guid { get; set; }

    public byte Spec { get; set; }

    public byte Button { get; set; }

    public uint Action { get; set; }

    public byte Type { get; set; }
}
