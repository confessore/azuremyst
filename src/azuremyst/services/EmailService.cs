using azuremyst.models.options;
using azuremyst.services.interfaces;
using Serilog;
using System.Net;
using System.Net.Mail;

namespace azuremyst.services
{
    sealed class EmailService : IEmailService
    {
        readonly SmtpOptions _options;

        public EmailService(
            SmtpOptions options)
        {
            _options = options;
        }

        public async Task SendEmailAsync(string recipient, string subject, string body)
        {
            try
            {
                using var smtpClient = new SmtpClient()
                {
                    Host = _options.Host,
                    Port = int.TryParse(_options.Port, out var port) ? port : 465,
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(_options.Username, _options.Password),
                    DeliveryMethod = SmtpDeliveryMethod.Network
                };
                using var message = new MailMessage(_options.FromAddress, recipient)
                {
                    From = new MailAddress(_options.FromAddress, _options.FromName),
                    Subject = subject,
                    Body = body,
                    IsBodyHtml = true
                };
                await smtpClient.SendMailAsync(message);
            }
            catch (Exception e)
            {
                Log.Error(e.Message);
            }
        }
    }
}