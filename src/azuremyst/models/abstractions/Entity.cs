using azuremyst.models.interfaces;

namespace azuremyst.models.abstractions
{
    public abstract class Entity<TId> : IEntity<TId>
        where TId : IEquatable<TId>
    {
        public TId? Id { get; set; }
        public long? CreatedAt { get; set; }
    }
}
