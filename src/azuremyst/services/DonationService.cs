using azuremyst.services.interfaces;
using PayPalCheckoutSdk.Core;
using PayPalCheckoutSdk.Orders;
using Serilog;

namespace azuremyst.services
{
    sealed class DonationService : IDonationService
    {
        readonly PayPalHttpClient _paypalHttpClient;

        public DonationService(
            PayPalHttpClient paypalHttpClient)
        {
            _paypalHttpClient = paypalHttpClient;
        }

        public async Task<Order> CreateOrderAsync()
        {
            // Construct a request object and set desired parameters
            // creates a POST request to /v2/checkout/orders
            var orderRequest = new OrderRequest()
            {
                CheckoutPaymentIntent = "CAPTURE",
                PurchaseUnits = new()
                {
                    new()
                    {
                        AmountWithBreakdown = new()
                        {
                            CurrencyCode = "USD",
                            Value = "100.00"
                        }
                    }
                },
                ApplicationContext = new()
                {
                    ReturnUrl = "https://localhost",
                    CancelUrl = "https://localhost"
                }
            };

            // Call API with your client and get a response for your call
            var request = new OrdersCreateRequest();
            request.Prefer("return=representation");
            request.RequestBody(orderRequest);
            var response = await _paypalHttpClient.Execute(request);
            var orderResult = response.Result<Order>();
            Log.Information("Links:");
            foreach (var link in orderResult.Links)
                Log.Information("\t{0}: {1}\tCall Type: {2}", link.Rel, link.Href, link.Method);
            return response.Result<Order>();
        }

        public async Task<Order> CaptureOrderAsync(string orderId)
        {
            var request = new OrdersCaptureRequest(orderId);
            request.Prefer("return=representation");
            request.RequestBody(new OrderActionRequest());
            var response = await _paypalHttpClient.Execute(request);
            return response.Result<Order>();
        }
    }
}
