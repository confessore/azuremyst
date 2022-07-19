namespace azuremyst.services.interfaces
{
    public interface IBoostService
    {
        Task<IEnumerable<string?>> LookupAccountCharactersAsync(string username);
        Task<bool> Boost60Async(string name);
    }
}
