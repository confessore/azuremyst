using azuremyst.services.interfaces;
using Serilog;
using Stripe;
using Stripe.Checkout;

namespace azuremyst.services
{
    sealed class DonationService : IDonationService
    {
        readonly ChargeService _chargeService;
        readonly SessionService _sessionService;

        public DonationService(
            ChargeService chargeService,
            SessionService sessionService)
        {
            _chargeService = chargeService;
            _sessionService = sessionService;
        }

        public async Task<Session> CreateSessionAsync()
        {
            var options = new SessionCreateOptions()
            {
                LineItems = new List<SessionLineItemOptions>()
                {
                    new SessionLineItemOptions()
                    {
                        PriceData = new SessionLineItemPriceDataOptions()
                        {
                            ProductData = new SessionLineItemPriceDataProductDataOptions()
                            {
                                Name = "12 azuremyst coins"
                            },
                            UnitAmount = 1000,
                            Currency = "USD"
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = "https://localhost/",
                CancelUrl = "https://localhost/"
            };
            var session = await _sessionService.CreateAsync(options);
            return session;
        }
    }
}
