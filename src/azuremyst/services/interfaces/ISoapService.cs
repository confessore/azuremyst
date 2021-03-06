namespace azuremyst.services.interfaces
{
    public interface ISoapService
    {
        Task<bool> SendMoneyAsync(string name, int copper);
        Task<bool> SendItemAsync(string name, int id);
        Task<bool> SendItemsAsync(string name, int[] ids);
        Task<bool> ExecuteSOAPCommandAsync(string command);
        Task<bool> ShutdownAsync();
        Task<bool> CreateAccountAsync(string name, string password);

        Task<bool> SetAddonAsync(string name, int expansion);

        Task<bool> SetGmLevelAsync(string name, int level);
        Task<bool> SetPasswordAsync(string accountId, string newPassword);
        Task<bool> AccountsInitializedAsync();
        Task<bool> RealmlistsInitializedAsync();
        Task<bool> DeleteAccountAsync(string id);
        Task<bool> CharacterLevel(string name, int level);
    }
}
