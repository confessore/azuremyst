using azuremyst.converters;
using azuremyst.models.enums;
using azuremyst.models.interfaces;
using Microsoft.AspNetCore.Identity;
using System.Text.Json.Serialization;

namespace azuremyst.models.abstractions
{
    public abstract class Role : IdentityRole, IEntity<string>, IRole
    {
    }
}
