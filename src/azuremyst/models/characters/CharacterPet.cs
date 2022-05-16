using System;
using System.Collections.Generic;

namespace azuremyst.models.characters
{
    /// <summary>
    /// Pet System
    /// </summary>
    public partial class CharacterPet
    {
        public uint Id { get; set; }
        public uint Entry { get; set; }
        public uint Owner { get; set; }
        public uint? Modelid { get; set; }
        public uint CreatedBySpell { get; set; }
        public byte PetType { get; set; }
        public uint Level { get; set; }
        public uint Exp { get; set; }
        public byte Reactstate { get; set; }
        public int Loyaltypoints { get; set; }
        public uint Loyalty { get; set; }
        public uint XpForNextLoyalty { get; set; }
        public int Trainpoint { get; set; }
        public string? Name { get; set; }
        public byte Renamed { get; set; }
        public uint Slot { get; set; }
        public uint Curhealth { get; set; }
        public uint Curmana { get; set; }
        public uint Curhappiness { get; set; }
        public ulong Savetime { get; set; }
        public uint ResettalentsCost { get; set; }
        public ulong ResettalentsTime { get; set; }
        public string? Abdata { get; set; }
        public string? Teachspelldata { get; set; }
    }
}
