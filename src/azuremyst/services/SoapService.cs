using azuremyst.contexts;
using azuremyst.models.options;
using azuremyst.services.interfaces;
using Microsoft.EntityFrameworkCore;
using Serilog;
using System.Net;
using System.Reflection;
using System.Text;
using System.Xml;

namespace azuremyst.services
{
    sealed class SoapService : ISoapService
    {
        readonly IHttpClientFactory _httpClientFactory;
        readonly MangosOptions _options;
        readonly IDbContextFactory<AuthDbContext> _authDbContextFactory;

        public SoapService(
            IHttpClientFactory httpClientFactory,
            MangosOptions options,
            IDbContextFactory<AuthDbContext> authDbContextFactory
        )
        {
            _httpClientFactory = httpClientFactory;
            _options = options;
            _authDbContextFactory = authDbContextFactory;
        }

        public async Task<bool> SendItemAsync(string name, int id)
        {
            var command = $"send items {name.ToUpper()} \"azuremy.st\" \" - the letter glows faintly...\" {id}";
            return await ExecuteSOAPCommandAsync(command);
        }
        public async Task<bool> ShutdownAsync()
        {
            var command = $"server shutdown 5";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> CreateAccountAsync(string name, string password)
        {
            // has optional tbc expansion at end
            var command = $"account create {name} {password} 1";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> DeleteAccountAsync(string name)
        {
            var command = $"account delete {name}";
            return await ExecuteSOAPCommandAsync(command);
        }

        async Task<bool> UpdatePasswordAsync(string oldPassword, string newPassword)
        {
            var command = $"account password {oldPassword} {newPassword}";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> SetPasswordAsync(string accountId, string newPassword)
        {
            // id or name
            var command = $"account set password {accountId} {newPassword}";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> SetAddonAsync(string name, int expansion)
        {
            var command = $"account set addon {name.ToUpper()} {expansion}";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> SetGmLevelAsync(string name, int level)
        {
            var command = $"account set gmlevel {name.ToUpper()} {level}";
            return await ExecuteSOAPCommandAsync(command);
        }

        public async Task<bool> ExecuteSOAPCommandAsync(string command)
        {
            try
            {
                var envelope = EnvelopeSOAPCommand(string.Format($"{command}\n"));
                var httpClient = _httpClientFactory.CreateClient(Assembly.GetExecutingAssembly().GetName().Name);
                var result = await httpClient.PostAsync(string.Empty, new StringContent(envelope.OuterXml, Encoding.UTF8));
                if (result.IsSuccessStatusCode)
                {
                    using var reader = new StreamReader(await result.Content.ReadAsStreamAsync());
                    return !string.IsNullOrEmpty(await reader.ReadToEndAsync());
                }
                return false;
            }
            catch (Exception e)
            {
                Log.Error("soap command failed...");
                Log.Error(e.Message);
                return false;
            }
        }

        XmlDocument EnvelopeSOAPCommand(string command)
        {
            var soapEnvelopeDocument = new XmlDocument();
            soapEnvelopeDocument.LoadXml(string.Format(@"<SOAP-ENV:Envelope xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:SOAP-ENC=""http://schemas.xmlsoap.org/soap/encoding/"" xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/1999/XMLSchema"" xmlns:ns1=""urn:MaNGOS""><SOAP-ENV:Body><ns1:executeCommand><command>{0}</command></ns1:executeCommand></SOAP-ENV:Body></SOAP-ENV:Envelope> ", command));
            return soapEnvelopeDocument;
        }

        public async Task<bool> AccountsInitializedAsync()
        {
            try
            {
                using var context = await _authDbContextFactory.CreateDbContextAsync();
                if (context != null)
                {
                    if (context.Accounts != null)
                    {
                        for (var i = 1; i < 5; i++)
                        {
                            var account = await context.Accounts.FirstOrDefaultAsync(x => x.Id == i);
                            if (account != null)
                            {
                                if (account.Locked == 0)
                                    account.Locked = 1;
                            }
                        }
                        await context.SaveChangesAsync();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Log.Warning("accounts have not been initialized...");
                Log.Warning(e.Message);
                return false;
            }
        }

        public async Task<bool> RealmlistsInitializedAsync()
        {
            try
            {
                using var context = await _authDbContextFactory.CreateDbContextAsync();
                if (context != null)
                {
                    if (context.Realmlists != null)
                    {
                        var realmlist = await context.Realmlists.FirstOrDefaultAsync();
                        if (realmlist != null)
                        {
                            realmlist.Name = "azuremyst";
                            //var ip = Dns.GetHostAddresses(Dns.GetHostName()).FirstOrDefault();
                            //realmlist.Address = ip != null ? ip.ToString() : "0.0.0.0";
                            await context.SaveChangesAsync();
                            return true;
                        }
                    }
                }
                return false;
            }
            catch (Exception e)
            {
                Log.Warning("realmlists have not been initialized...");
                Log.Warning(e.Message);
                return false;
            }
        }
    }
}
