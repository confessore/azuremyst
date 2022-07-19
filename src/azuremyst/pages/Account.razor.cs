using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace azuremyst.pages
{
    sealed partial class Account
    {
        [Inject]
        AuthenticationStateProvider? _authenticationStateProvider { get; set; }

        [Inject]
        ISoapService? _soapService { get; set; }

        [Inject]
        IBoostService? _boostService { get; set; }

        public Account()
        {
            model = new();
        }

        Model model;

        class Model
        {
            public bool Initialized { get; set; }
            public string? Username { get; set; }
            public string? Email { get; set; }
            public IEnumerable<string?>? Characters { get; set; }
        }

        public async Task ExecuteBoostAsync()
        {
            if (_boostService != null)
            {
                if (model.Username != null)
                {
                    model.Characters = await _boostService.LookupAccountCharactersAsync(model.Username);
                    if (model.Characters != null)
                        await _boostService.Boost60Async(model.Characters.FirstOrDefault() ?? string.Empty);
                }
            }
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();
            if (_authenticationStateProvider != null)
            {
                var authenticationState = await _authenticationStateProvider.GetAuthenticationStateAsync();
                if (authenticationState.User.Identity != null)
                {
                    model.Username = authenticationState.User.Identity.Name;
                }
            }
            model.Initialized = true;
        }
    }
}
