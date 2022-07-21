using Microsoft.AspNetCore.Components;

namespace azuremyst.shared.components
{
    sealed partial class ServiceList
    {
        [Parameter]
        public IEnumerable<(string?, int?)>? Services { get; set; } = Enumerable.Empty<(string?, int?)>();

        public ServiceList()
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

        public async Task OnServiceClickedAsync()
        {

        }
    }
}
