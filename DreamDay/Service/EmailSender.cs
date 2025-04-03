using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using MimeKit;

namespace DreamDay.Service
{
    public class EmailSettings
    {
        public string ClientId { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpServer { get; set; }
        public string ClientSecret { get; set; }
        public string RefreshToken { get; set; }
        public string FromEmail { get; set; }
    }

    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings _emailSettings;
        private readonly string[] Scopes = ["https://mail.google.com/"];

        public EmailSender(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                await SendEmailInternalAsync(email, subject, message, "html", null);
            }
            catch (System.Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// Internal method to send email. Optionally allows further customization of the MimeMessage.
        /// </summary>
        private async Task SendEmailInternalAsync(string toEmail, string subject, string bodyContent, string mimeType, Action<MimeMessage>? additionalSetup)
        {
            if (string.IsNullOrEmpty(_emailSettings.ClientId) ||
                string.IsNullOrEmpty(_emailSettings.ClientSecret) ||
                string.IsNullOrEmpty(_emailSettings.FromEmail) ||
                string.IsNullOrEmpty(_emailSettings.RefreshToken))
            {
                throw new InvalidOperationException("GmailService is not initialized. Call Initialize() first.");
            }

            // Create a token response with the refresh token.
            var tokenResponse = new TokenResponse { RefreshToken = _emailSettings.RefreshToken };

            // Create the authorization flow.
            var flow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = new ClientSecrets
                {
                    ClientId = _emailSettings.ClientId,
                    ClientSecret = _emailSettings.ClientSecret
                },
                Scopes = Scopes
            });

            // Create a UserCredential and refresh the access token.
            var credential = new UserCredential(flow, "user", tokenResponse);
            bool success = await credential.RefreshTokenAsync(CancellationToken.None);
            if (!success)
            {
                throw new Exception("Failed to refresh access token.");
            }
            string accessToken = credential.Token.AccessToken;

            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Sender", _emailSettings.FromEmail));
            message.To.Add(new MailboxAddress("", toEmail));
            message.Subject = subject;

            // Create a TextPart with the specified mime type ("plain" or "html").
            message.Body = new TextPart(mimeType) { Text = bodyContent };

            additionalSetup?.Invoke(message);

            using var client = new MailKit.Net.Smtp.SmtpClient();

            await client.ConnectAsync(_emailSettings.SmtpServer, _emailSettings.SmtpPort, SecureSocketOptions.StartTls);
            var oauth2 = new SaslMechanismOAuth2(_emailSettings.FromEmail, accessToken);
            await client.AuthenticateAsync(oauth2);

            await client.SendAsync(message);
            await client.DisconnectAsync(true);
        }
    }
}
