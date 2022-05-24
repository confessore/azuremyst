using azuremyst.models.options;
using Microsoft.AspNetCore.Identity.UI.Services;
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

        public Task SendEmailAsync(string recipient, string subject, string body)
        {
            return Execute(recipient, subject, body);
        }

        async Task Execute(string recipient, string subject, string body)
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
    }
}