using Azuremyst.Contexts;
using Azuremyst.Models.Acore.Auth;
using Microsoft.EntityFrameworkCore;

namespace Azuremyst.Services;

public class AcoreAuthService(IDbContextFactory<AcoreAuthContext> _acoreAuthContextFactory)
{
    public async Task<Account?> GetAccountByUsernameAsync(string username)
    {
        using var context = await _acoreAuthContextFactory.CreateDbContextAsync();
        return await GetAccountByUsernameAsync(context, username);
    }

    public async Task<Account?> GetAccountByUsernameAsync(
        AcoreAuthContext context,
        string username
    ) =>
        await context.Accounts.FirstOrDefaultAsync(account =>
            account.Username.ToUpper() == username.ToUpper()
        );

    public async Task<Account?> GetAccountByIdAsync(AcoreAuthContext context, uint id) =>
        await context.Accounts.FirstOrDefaultAsync(x => x.Id == id);

    public async Task<Account?> GetAccountByIdAsync(uint id)
    {
        using var context = await _acoreAuthContextFactory.CreateDbContextAsync();
        return await GetAccountByIdAsync(context, id);
    }

    public async Task<IEnumerable<Account>> GetAllAccountsAsync(AcoreAuthContext context) =>
        await context.Accounts.ToArrayAsync();

    public async Task<IEnumerable<Account>> GetAllAccountsAsync()
    {
        using var context = await _acoreAuthContextFactory.CreateDbContextAsync();
        return await GetAllAccountsAsync(context);
    }
}
