using Stripe;
using Stripe.Checkout;

namespace azuremyst.services.interfaces
{
    public interface IDonationService
    {
        Task<Session> CreateSessionAsync();
    }
}
