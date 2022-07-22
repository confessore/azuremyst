using azuremyst.models.characters;
using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace azuremyst.pages.account
{
    sealed partial class Manage
    {
        [Inject]
        AuthenticationStateProvider? _authenticationStateProvider { get; set; }

        [Inject]
        ISoapService? _soapService { get; set; }

        [Inject]
        IBoostService? _boostService { get; set; }

        public Manage()
        {
            model = new();
        }

        Model model;

        class Model
        {
            public bool Initialized { get; set; }
            public string? Username { get; set; }
            public string? Email { get; set; }
            public IEnumerable<string?>? CharacterNames { get; set; } = Enumerable.Empty<string?>();
            public IEnumerable<Character?>? Characters { get; set; } = Enumerable.Empty<Character?>();
            public Character? SelectedCharacter { get; set; }
            public IEnumerable<(string?, int?)>? Services { get; set; } = Enumerable.Empty<(string?, int?)>();
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
            if (_boostService != null)
            {
                if (model.Username != null)
                {
                    model.CharacterNames = await _boostService.LookupAccountCharacterNamesAsync(model.Username);
                    model.Characters = await _boostService.LookupAccountCharactersAsync(model.Username);
                    if (model.Characters != null)
                        model.SelectedCharacter = model.Characters.FirstOrDefault();
                }
            }
            model.Services = new List<(string?, int?)>()
            {
                ("level 60 boost", 30),
                ("faction change", 20),
                ("race change", 20),
                ("appearance change", 10),
                ("name change", 10),
                ("dual specialization", 10)
            };
            model.Initialized = true;
        }

        public async Task ExecuteBoostAsync()
        {
            if (_boostService != null)
            {
                if (model.Username != null)
                {
                    model.CharacterNames = await _boostService.LookupAccountCharacterNamesAsync(model.Username);
                    if (model.CharacterNames != null)
                        await _boostService.Boost60Async(model.CharacterNames.FirstOrDefault() ?? string.Empty);
                }
            }
        }

        public async Task DonateAsync()
        {

        }
    }
}
