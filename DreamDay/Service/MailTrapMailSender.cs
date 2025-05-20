using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;

namespace DreamDay.Service
{
    public class MailTrapMailSender(IOptions<GmailSettings> emailSettings) : IEmailSender
    {
        private readonly GmailSettings _emailSettings = emailSettings.Value;

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SmtpClient(_emailSettings.SmtpServer, _emailSettings.SmtpPort)
            {
                Credentials = new NetworkCredential(_emailSettings.ClientId, _emailSettings.ClientSecret),
                EnableSsl = true
            };
            client.Send(_emailSettings.FromEmail, email, subject, htmlMessage);
            return Task.CompletedTask;
        }
    }
}
