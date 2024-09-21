using Stripe;
using Stripe.Checkout;

namespace Azuremyst.Services
{
    public sealed class CheckoutService
    {
        private readonly ChargeService _chargeService;
        private readonly SessionService _sessionService;

        public CheckoutService(ChargeService chargeService, SessionService sessionService)
        {
            _chargeService = chargeService;
            _sessionService = sessionService;
        }

        public async Task<Session> CreateSessionAsync(ulong userId, long? amount = 1000)
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
                                Name = "Donation"
                            },
                            UnitAmount = amount,
                            Currency = "USD",
                        },
                        Quantity = 1
                    }
                },
                Mode = "payment",
                Metadata = new Dictionary<string, string>()
                {
                    { "userId",  userId.ToString() },
                },
                SuccessUrl = "https://azuremy.st/",
                CancelUrl = "https://azuremy.st/"
            };
            var session = await _sessionService.CreateAsync(options);
            return session;
        }
    }
}
