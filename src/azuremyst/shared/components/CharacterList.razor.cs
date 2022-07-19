using azuremyst.models.characters;
using Microsoft.AspNetCore.Components;

namespace azuremyst.shared.components
{
    sealed partial class CharacterList
    {
        [Parameter]
        public IEnumerable<Character?>? Characters { get; set; } = Enumerable.Empty<Character?>();

        public CharacterList()
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
    }
}
