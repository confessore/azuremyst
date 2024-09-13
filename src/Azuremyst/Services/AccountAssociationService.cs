using Azuremyst.Contexts;
using Azuremyst.Models;
using MediatR;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Services;

public class AccountAssociationService(
    IDbContextFactory<ApplicationDbContext> _applicationDbContextFactory,
    AuthenticationStateProvider _authenticationStateProvider,
    IMediator _mediator
)
{
    public async Task<IEnumerable<AccountAssociation>> GetAccountAssociationsByUserIdAsync(
        ApplicationDbContext context,
        ulong id
    ) => await context.AccountAssociations.Where(x => x.UserId == id).ToArrayAsync();

    public async Task<IEnumerable<AccountAssociation>> GetAccountAssociationsByUserIdAsync(ulong id)
    {
        using var context = await _applicationDbContextFactory.CreateDbContextAsync();
        return await GetAccountAssociationsByUserIdAsync(context, id);
    }

    public async Task<AccountAssociation?> GetAccountAssociationByAccountIdAsync(
        ApplicationDbContext context,
        uint id
    ) => await context.AccountAssociations.FirstOrDefaultAsync(x => x.AccountId == id);

    public async Task<AccountAssociation?> GetAccountAssociationByAccountIdAsync(uint id)
    {
        using var context = await _applicationDbContextFactory.CreateDbContextAsync();
        return await GetAccountAssociationByAccountIdAsync(context, id);
    }

    public async Task<AccountAssociation?> UpsertAccountAssociationAsync(
        ApplicationDbContext context,
        AccountAssociation accountAssociation
    )
    {
        var entity = await context.AccountAssociations.FirstOrDefaultAsync(x =>
            x.Id == accountAssociation.Id
        );
        if (entity is null)
        {
            await context.AccountAssociations.AddAsync(accountAssociation);
        }
        else if (entity is not null)
        {
            context.Entry(entity).CurrentValues.SetValues(accountAssociation);
        }

        await context.SaveChangesAsync();
        return accountAssociation;
    }

    public async Task<AccountAssociation?> UpsertAccountAssociationAsync(
        AccountAssociation accountAssociation
    )
    {
        using var context = await _applicationDbContextFactory.CreateDbContextAsync();
        return await UpsertAccountAssociationAsync(context, accountAssociation);
    }
}
