using azuremyst.models.interfaces;
using Microsoft.AspNetCore.Identity;

namespace azuremyst.models.abstractions
{
    public abstract class Role : IdentityRole, IEntity<string>, IRole
    {
    }
}
