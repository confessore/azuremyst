using System.Security.Claims;
using Azuremyst.Commands;
using Azuremyst.Contexts;
using Azuremyst.Models;
using Azuremyst.Queries;
using MediatR;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Services
{
    public class UserService(
        IDbContextFactory<ApplicationDbContext> _applicationDbContextFactory,
        AuthenticationStateProvider _authenticationStateProvider,
        IMediator _mediator
    )
    {
        public async Task<User?> GetUserByIdAsync(ApplicationDbContext context, ulong id) =>
            await context.Users.FirstOrDefaultAsync(user => user.Id == id);

        public async Task<User?> GetUserByIdAsync(ulong id)
        {
            using var context = await _applicationDbContextFactory.CreateDbContextAsync();
            return await GetUserByIdAsync(context, id);
        }

        public async Task<User?> UpsertUserAsync(ApplicationDbContext context, User user)
        {
            var entity = await context.Users.FirstOrDefaultAsync(x => x.Id == user.Id);

            if (entity is null)
            {
                await context.Users.AddAsync(user);
            }
            else if (entity is not null)
            {
                context.Entry(entity).CurrentValues.SetValues(user);
            }

            await context.SaveChangesAsync();
            return user;
        }

        public async Task<User?> UpsertUserAsync(User user)
        {
            using var context = await _applicationDbContextFactory.CreateDbContextAsync();
            return await UpsertUserAsync(context, user);
        }

        public async Task<User?> InitializeUserAsync()
        {
            var authenticationState =
                await _authenticationStateProvider.GetAuthenticationStateAsync();
            var id = authenticationState.User.Claims.FirstOrDefault(x =>
                x.Type == ClaimTypes.NameIdentifier
            );
            var name = authenticationState.User.Claims.FirstOrDefault(x =>
                x.Type == ClaimTypes.Name
            );
            var email = authenticationState.User.Claims.FirstOrDefault(x =>
                x.Type == ClaimTypes.Email
            );
            if (id is not null && name is not null && email is not null)
            {
                var user = await _mediator.Send(new GetUserByIdQuery(Convert.ToUInt64(id.Value)));
                user ??= new User()
                {
                    Id = Convert.ToUInt64(id.Value),
                    Guid = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = Convert.ToUInt64(id.Value)
                };
                user.Name = name.Value;
                user.Email = email.Value;
                user.UpdatedAt = DateTime.UtcNow;
                user.UpdatedBy = Convert.ToUInt64(id.Value);
                user = await _mediator.Send(new AddUserCommand(user));
                return user;
            }

            return null;
        }
    }
}
