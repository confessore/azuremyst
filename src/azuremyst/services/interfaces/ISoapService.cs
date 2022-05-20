namespace azuremyst.services.interfaces
{
    public interface ISoapService
    {
        Task<string> TestAsync();
        //Task<string> MailAsync(string name, int id);
    }
}
