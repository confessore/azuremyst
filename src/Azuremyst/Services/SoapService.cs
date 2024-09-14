using System.Text;
using System.Xml;
using Azuremyst.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Azuremyst.Services;

internal sealed class SoapService
{
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly IDbContextFactory<AcoreAuthContext> _authDbContextFactory;

    public SoapService(
        IHttpClientFactory httpClientFactory,
        IDbContextFactory<AcoreAuthContext> authDbContextFactory
    )
    {
        _httpClientFactory = httpClientFactory;
        _authDbContextFactory = authDbContextFactory;
    }

    public async Task<bool> SendMoneyAsync(string name, int copper)
    {
        var command =
            $"send money {name.ToUpper()} \"Azuremyst\" \" - The letter glows faintly...\" {copper}";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> SendItemAsync(string name, int id)
    {
        var command =
            $"send items {name.ToUpper()} \"Azuremyst\" \" - The letter glows faintly...\" {id}";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> SendItemsAsync(string name, int[] ids)
    {
        var command =
            $"send items {name.ToUpper()} \"Azuremyst\" \" - The letter glows faintly...\" ";
        var builder = new StringBuilder();
        builder.Append(command);
        foreach (var id in ids)
        {
            builder.Append(string.Concat(id, " "));
        }

        return await ExecuteSOAPCommandAsync(builder.ToString());
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

    public async Task<bool> DeleteAccountAsync(string id)
    {
        var command = $"account delete {id}";
        return await ExecuteSOAPCommandAsync(command);
    }

    private async Task<bool> UpdatePasswordAsync(string oldPassword, string newPassword)
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

    public async Task<bool> UnstuckToInnAsync(string name)
    {
        var command = $"unstuck {name.ToUpper()} inn";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> UnstuckToGraveyardAsync(string name)
    {
        var command = $"unstuck {name.ToUpper()} graveyard";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> CharacterLevel(string name, int level)
    {
        var command = $"character level {name.ToUpper()} {level}";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> UnstuckToStartZoneAsync(string name)
    {
        var command = $"unstuck {name.ToUpper()} startzone";
        return await ExecuteSOAPCommandAsync(command);
    }

    public async Task<bool> ExecuteSOAPCommandAsync(string command)
    {
        try
        {
            var envelope = EnvelopeSOAPCommand(command);
            var httpClient = _httpClientFactory.CreateClient(nameof(SoapService));
            var result = await httpClient.PostAsync(
                string.Empty,
                new StringContent(envelope.OuterXml, Encoding.UTF8)
            );
            if (result.IsSuccessStatusCode)
            {
                using var reader = new StreamReader(await result.Content.ReadAsStreamAsync());
                return !string.IsNullOrEmpty(await reader.ReadToEndAsync());
            }

            return false;
        }
        catch (Exception e)
        {
            Console.WriteLine("soap command failed...");
            Console.WriteLine(e.Message);
            Console.WriteLine(e.InnerException?.Message);
            return false;
        }
    }

    private static XmlDocument EnvelopeSOAPCommand(string command)
    {
        var soapEnvelopeDocument = new XmlDocument();
        soapEnvelopeDocument.LoadXml(
            string.Format(
                @"
                <SOAP-ENV:Envelope  
                    xmlns:SOAP-ENV=""http://schemas.xmlsoap.org/soap/envelope/"" 
                    xmlns:SOAP-ENC=""http://schemas.xmlsoap.org/soap/encoding/"" 
                    xmlns:xsi=""http://www.w3.org/1999/XMLSchema-instance"" 
                    xmlns:xsd=""http://www.w3.org/1999/XMLSchema"" 
                    xmlns:ns1=""urn:AC"">
                    <SOAP-ENV:Body>
	                <ns1:executeCommand>
	                    <command>{0}</command>
	                </ns1:executeCommand>
                    </SOAP-ENV:Body>
                </SOAP-ENV:Envelope>
            ",
                command
            )
        );
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
                            {
                                account.Locked = 1;
                            }
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
            Console.WriteLine("accounts have not been initialized...");
            Console.WriteLine(e.Message);
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
            Console.WriteLine("realmlists have not been initialized...");
            Console.WriteLine(e.Message);
            return false;
        }
    }
}
