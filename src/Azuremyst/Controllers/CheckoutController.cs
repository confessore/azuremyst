using Microsoft.AspNetCore.Mvc;
using Stripe;

namespace Azuremyst.Controllers
{
    [Route("[controller]/[action]")]
    public class CheckoutController : ControllerBase
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
