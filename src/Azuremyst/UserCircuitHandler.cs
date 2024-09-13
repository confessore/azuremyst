using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.Circuits;

namespace Azuremyst;

public sealed class UserCircuitHandler(AuthenticationStateProvider _authenticationStateProvider)
    : CircuitHandler
{
    public override async Task OnConnectionUpAsync(
        Circuit circuit,
        CancellationToken cancellationToken
    )
    { }
}
