﻿namespace Azuremyst.Models.Acore.Characters;

public partial class GuildBankItem
{
    public uint Guildid { get; set; }

    public byte TabId { get; set; }

    public byte SlotId { get; set; }

    public uint ItemGuid { get; set; }
}
