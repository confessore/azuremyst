using azuremyst.models.characters;

namespace azuremyst.services.interfaces
{
    public interface IBoostService
    {
        Task<IEnumerable<string?>> LookupAccountCharacterNamesAsync(string username);
        Task<IEnumerable<Character?>> LookupAccountCharactersAsync(string username);
        Task<bool> Boost60Async(string name);
    }
}
