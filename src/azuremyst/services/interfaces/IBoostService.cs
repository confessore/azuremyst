namespace azuremyst.services.interfaces
{
    public interface IBoostService
    {
        Task<bool> Boost60Async(string name);
    }
}
