using PayPalCheckoutSdk.Orders;

namespace azuremyst.services.interfaces
{
    public interface IDonationService
    {
        Task<Order> CreateOrderAsync();
        Task<Order> CaptureOrderAsync(string orderId);
    }
}
