namespace azuremyst.models.interfaces
{
    public interface IEntity<TId>
        where TId : IEquatable<TId>
    {
        public TId? Id { get; set; }
    }
}
