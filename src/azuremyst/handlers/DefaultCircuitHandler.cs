
using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.Circuits;
using Serilog;

namespace azuremyst.handlers
{
    sealed class DefaultCircuitHandler : CircuitHandler
    {
        readonly IAuthService _authService;
        readonly ILocalStorageService _localStorageService;
        readonly IHostEnvironmentAuthenticationStateProvider _hostEnvironmentAuthenticationStateProvider;

        public DefaultCircuitHandler(
            IAuthService authService,
            ILocalStorageService localStorageService,
            IHostEnvironmentAuthenticationStateProvider hostEnvironmentAuthenticationStateProvider)
        {
            _authService = authService;
            _localStorageService = localStorageService;
            _hostEnvironmentAuthenticationStateProvider = hostEnvironmentAuthenticationStateProvider;
        }

        public override async Task OnCircuitClosedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            await base.OnCircuitClosedAsync(circuit, cancellationToken);
        }

        public override async Task OnCircuitOpenedAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            await base.OnCircuitOpenedAsync(circuit, cancellationToken);
        }

        public override async Task OnConnectionDownAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            await base.OnConnectionDownAsync(circuit, cancellationToken);
        }

        public override async Task OnConnectionUpAsync(Circuit circuit, CancellationToken cancellationToken)
        {
            await base.OnConnectionUpAsync(circuit, cancellationToken);
            try
            {
                var user = await _localStorageService.GetDefaultUserAsync();
                if (user != null)
                {
                    if (await _authService.TokenAuthenticateAsync(user))
                        _hostEnvironmentAuthenticationStateProvider.SetAuthenticationState(_authService.BuildAuthenticationStateAsync(user));
                }
            }
            catch (Exception e)
            {
                Log.Warning(e.Message, e);
                await _localStorageService.DeleteDefaultUserAsync();
            }
        }
    }
}
