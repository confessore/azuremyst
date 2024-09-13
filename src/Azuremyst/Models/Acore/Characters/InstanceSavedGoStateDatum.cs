namespace Azuremyst.Models.Acore.Characters;

public partial class InstanceSavedGoStateDatum
{
    /// <summary>
    /// instance.id
    /// </summary>
    public uint Id { get; set; }

    /// <summary>
    /// gameobject.guid
    /// </summary>
    public uint Guid { get; set; }

    /// <summary>
    /// gameobject.state
    /// </summary>
    public byte? State { get; set; }
}
