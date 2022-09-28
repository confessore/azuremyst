using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server;

namespace azuremyst.providers
{
    public sealed class DefaultRevalidatingServerAuthenticationStateProvider : RevalidatingServerAuthenticationStateProvider
    {
        readonly IAuthService _authService;
        readonly ILocalStorageService _localStorageService;

        public DefaultRevalidatingServerAuthenticationStateProvider(
            IAuthService authService,
            ILocalStorageService localStorageService,
            ILoggerFactory loggerFactory)
                : base(loggerFactory)
        {
            _authService = authService;
            _localStorageService = localStorageService;
        }

        protected override TimeSpan RevalidationInterval =>
            TimeSpan.FromHours(1);

        public async override Task<AuthenticationState> GetAuthenticationStateAsync() =>
            await base.GetAuthenticationStateAsync();

        protected override async Task<bool> ValidateAuthenticationStateAsync(
            AuthenticationState authenticationState,
            CancellationToken cancellationToken) =>
                await _authService.TokenAuthenticateAsync(await _localStorageService.GetDefaultUserAsync());
    }
}
