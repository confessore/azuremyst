namespace azuremyst.services.interfaces
{
    public interface ISoapService
    {
        Task<bool> SendItemAsync(string name, int id);
        Task<string> ExecuteSOAPCommandAsync(string command);
        Task<bool> ShutdownAsync();
    }
}
