namespace Azuremyst.Models.Acore.Characters;

/// <summary>
/// Player System
/// </summary>
public partial class CharacterSkill
{
    /// <summary>
    /// Global Unique Identifier
    /// </summary>
    public uint Guid { get; set; }

    public ushort Skill { get; set; }

    public ushort Value { get; set; }

    public ushort Max { get; set; }
}
