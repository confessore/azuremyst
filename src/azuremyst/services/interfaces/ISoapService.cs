namespace azuremyst.services.interfaces
{
    public interface ISoapService
    {
        Task<bool> SendItemAsync(string name, int id);
        Task<bool> ExecuteSOAPCommandAsync(string command);
        Task<bool> ShutdownAsync();
        Task<bool> CreateAccountAsync(string name, string password);

        Task<bool> SetAddonAsync(string name, int expansion);

        Task<bool> SetGmLevelAsync(string name, int level);
    }
}
