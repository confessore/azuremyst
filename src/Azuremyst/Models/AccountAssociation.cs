using Azuremyst.Models.Abstractions;
using Azuremyst.Models.Interfaces;

namespace Azuremyst.Models
{
    public class AccountAssociation : Entity<ulong>, IEntity<ulong>
    {
        public ulong? UserId { get; set; }

        public uint? AccountId { get; set; }
    }
}
