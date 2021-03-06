using azuremyst.converters;
using azuremyst.models.enums;
using azuremyst.models.interfaces;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace azuremyst.models.abstractions
{
    [JsonConverter(typeof(UserConverter))]
    public abstract class User : IdentityUser, IEntity<string>, IUser
    {
        [JsonConstructor]
        public User() { }

        public long? CreatedAt { get; set; }
        public UserType UserType { get; set; }
        public virtual uint? AccountId { get; set; }
        public virtual ulong? DiscordId { get; set; }
        public virtual ICollection<Token>? Tokens { get; set; }
    }
}
