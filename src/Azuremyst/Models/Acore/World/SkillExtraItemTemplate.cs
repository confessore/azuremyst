namespace Azuremyst.Models.Acore.World;

/// <summary>
/// Skill Specialization System
/// </summary>
public partial class SkillExtraItemTemplate
{
    /// <summary>
    /// SpellId of the item creation spell
    /// </summary>
    public uint SpellId { get; set; }

    /// <summary>
    /// Specialization spell id
    /// </summary>
    public uint RequiredSpecialization { get; set; }

    /// <summary>
    /// chance to create add
    /// </summary>
    public float AdditionalCreateChance { get; set; }

    public sbyte AdditionalMaxNum { get; set; }
}
