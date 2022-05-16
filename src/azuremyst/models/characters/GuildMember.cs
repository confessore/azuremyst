using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Guild System
    /// </summary>
    public partial class GuildMember
    {
        public uint Guildid { get; set; }
        public uint Guid { get; set; }
        public byte Rank { get; set; }
        public string Pnote { get; set; } = null!;
        public string Offnote { get; set; } = null!;
        public uint BankResetTimeMoney { get; set; }
        public uint BankRemMoney { get; set; }
        public uint BankResetTimeTab0 { get; set; }
        public uint BankRemSlotsTab0 { get; set; }
        public uint BankResetTimeTab1 { get; set; }
        public uint BankRemSlotsTab1 { get; set; }
        public uint BankResetTimeTab2 { get; set; }
        public uint BankRemSlotsTab2 { get; set; }
        public uint BankResetTimeTab3 { get; set; }
        public uint BankRemSlotsTab3 { get; set; }
        public uint BankResetTimeTab4 { get; set; }
        public uint BankRemSlotsTab4 { get; set; }
        public uint BankResetTimeTab5 { get; set; }
        public uint BankRemSlotsTab5 { get; set; }
    }
}
