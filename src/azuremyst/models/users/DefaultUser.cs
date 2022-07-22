using azuremyst.models.abstractions;

namespace azuremyst.models.users
{
    public sealed class DefaultUser : User
    {
        public int? Coins { get; set; }
    }
}
