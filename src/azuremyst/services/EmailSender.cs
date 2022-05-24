using azuremyst.models.options;
using Microsoft.AspNetCore.Identity.UI.Services;
using Serilog;
using System.Net;
using System.Net.Mail;

namespace azuremyst.services
{
    sealed class EmailSender : IEmailSender
    {
        readonly SmtpOptions _options;

        public EmailSender(
            SmtpOptions options)
        {
            _options = options;
        }

        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            try
            {
                using var smtpClient = new SmtpClient
                {
                    Host = _options.SmtpHost,
                    Port = Convert.ToInt32(_options.SmtpPort),
                    EnableSsl = true,
                    Credentials = new NetworkCredential(_options.SmtpUsername, _options.SmtpPassword)
                };
                using var msg = new MailMessage(_options.SmtpFromAddress, recipient)
                {
                    From = new MailAddress(_options.SmtpFromAddress, _options.SmtpFromName),
                    Subject = subject,
                    Body = body
                };
                msg.IsBodyHtml = true;
                await smtpClient.SendMailAsync(msg);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}