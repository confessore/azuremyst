using azuremyst.services.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace azuremyst.controllers
{
    [Route("[controller]")]
    [ApiController]
    public sealed class StripeController : Controller
    {
        readonly IDonationService _donationService;

        public StripeController(
            IDonationService donationService)
        {
            _donationService = donationService;
        }

        [Route("[action]")]
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateCheckoutSessionAsync()
        {
            var session = await _donationService.CreateSessionAsync();
            Response.Headers.Add("Location", session.Url);
            return new StatusCodeResult(303);
        }
    }
}
