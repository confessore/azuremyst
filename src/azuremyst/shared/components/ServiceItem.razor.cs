using Microsoft.AspNetCore.Components;

namespace azuremyst.shared.components
{
    sealed partial class ServiceItem
    {
        [Parameter]
        public string? Name { get; set; }

        [Parameter]
        public int? Price { get; set; }

        public ServiceItem()
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
