﻿namespace Azuremyst.Models.Acore.World;

public partial class CreatureTemplateSpell
{
    public uint CreatureId { get; set; }

    public byte Index { get; set; }

    public uint? Spell { get; set; }

    public int? VerifiedBuild { get; set; }
}
