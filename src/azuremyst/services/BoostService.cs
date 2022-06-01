using azuremyst.services.interfaces;

namespace azuremyst.services
{
    public class BoostService : IBoostService
    {
        readonly ISoapService _soapService;

        public BoostService(
            ISoapService soapService)
        {
            _soapService = soapService;
        }

        public static readonly int[] mage =
        {
            22062,
            22063, 
            22064,
            22065,
            22066,
            22067,
            22068,
            22069,
            12103,
            12968,
            22335,
            22408,
            22433,
            22339,
            12930,
            18468
        };

        public async Task MailMageSetAsync(string name)
        {
            foreach (var item in mage)
                await _soapService.SendItemAsync(name, item);
        }
    }
}
