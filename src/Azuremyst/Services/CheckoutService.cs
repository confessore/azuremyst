using Stripe;
using Stripe.Checkout;

namespace Azuremyst.Services
{
    internal sealed class CheckoutService
    {
        private readonly ChargeService _chargeService;
        private readonly SessionService _sessionService;

        public CheckoutService(ChargeService chargeService, SessionService sessionService)
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
                                Name = "Donation",
                                Description = "ulong value"
                            },
                            UnitAmount = 1000,
                            Currency = "USD",
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                SuccessUrl = "https://azuremy.st/",
                CancelUrl = "https://azuremy.st/"
            };
            var session = await _sessionService.CreateAsync(options);
            return session;
        }
    }
}
