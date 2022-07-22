using azuremyst.extensions;
using azuremyst.models.characters;
using azuremyst.models.enums;
using Microsoft.AspNetCore.Components;

namespace azuremyst.shared.components
{
    sealed partial class CharacterItem
    {
        [Parameter]
        public Character? Character { get; set; }

        public CharacterItem()
        {
            model = new();
        }

        Model model;

        class Model
        {
            public bool Initialized { get; set; }
        }

        protected override async Task OnInitializedAsync()
        {
            await base.OnInitializedAsync();

            model.Initialized = true;
        }

        public string? BuildClassIconSource(WoWClass @class) =>
            $"icons/{@class.GetDescription().ToLower()}.png";

        public string? BuildRaceIconSource(WoWRace race, WoWGender gender = WoWGender.Male) =>
            $"icons/{race.GetDescription().ToLower()}_{gender.GetDescription().ToLower()}.png";
    }
}
