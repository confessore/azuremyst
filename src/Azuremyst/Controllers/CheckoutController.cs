using Azuremyst.Models;
using Azuremyst.Services;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using Stripe.Checkout;

namespace Azuremyst.Controllers
{
    [Route("[controller]/[action]")]
    public class CheckoutController(
        SessionService _sessionService,
        UserService _userService) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> WebhookAsync()
        {
            var json = await new StreamReader(HttpContext.Request.Body).ReadToEndAsync();
            try
            {
                var stripeEvent = EventUtility.ConstructEvent(
                    json,
                    Request.Headers["Stripe-Signature"],
                    Environment.GetEnvironmentVariable("STRIPE_ENDPOINT_SECRET")
                        ?? throw new Exception("STRIPE_ENDPOINT_SECRET")
                );

                // Handle the event
                if (stripeEvent.Type == Events.CheckoutSessionCompleted)
                {
                    Console.WriteLine("session completed");
                    var session = stripeEvent.Data.Object as Session;
                    var lineItems = _sessionService.ListLineItems(session.Id);
                    foreach (var item in lineItems)
                    {
                        var price = item.Price.UnitAmount / 100m;
                        var metadataUserId = session.Metadata["userId"];
                        var userId = ulong.Parse(metadataUserId);
                        var user = await _userService.GetUserByIdAsync(userId);
                        user.Soj += Convert.ToInt32(Math.Ceiling(price ?? 0m));
                    }
                }
                // ... handle other event types
                else
                {
                    Console.WriteLine("Unhandled event type: {0}", stripeEvent.Type);
                }

                return Ok();
            }
            catch (StripeException ex)
            {
                Console.WriteLine(ex.Message);
                return BadRequest();
            }
        }
    }
}
