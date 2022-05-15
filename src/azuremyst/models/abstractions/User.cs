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

        public UserType UserType { get; set; }
        public virtual ICollection<Token>? Tokens { get; set; }
    }
}
