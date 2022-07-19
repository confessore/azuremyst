using azuremyst.converters;
using azuremyst.models.interfaces;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace azuremyst.models.abstractions
{
    [JsonConverter(typeof(RoleConverter))]
    public abstract class Role : IdentityRole, IEntity<string>, IRole
    {
        [JsonConstructor]
        public Role() { }

        public long? CreatedAt { get; set; }
    }
}
