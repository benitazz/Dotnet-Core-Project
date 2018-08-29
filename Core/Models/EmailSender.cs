using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MedicalBilingMicroservice.Core.Models {
    public class EmailSender : IEmailSender {
        public EmailSender (IOptions<AuthMessageSenderOptions> optionsAccessor) {
            Options = optionsAccessor.Value;
        }

        public AuthMessageSenderOptions Options { get; } //set only via Secret Manager

        public Task SendEmailAsync (string email, string subject, string message) {
            return Execute (Options.SendGridKey, subject, message, email);
        }

        public async Task Execute (string apiKey, string subject, string message, string email) {
            var client = new SendGridClient (apiKey);
            var from = new EmailAddress ("benitazz@gmail.com", "Example User");
            if (string.IsNullOrEmpty(subject)){
                 subject = "Sending with SendGrid is Fun";
            }
           
            var to = new EmailAddress (email, subject);
            var plainTextContent = message;
            var htmlContent = message;
            var msg = MailHelper.CreateSingleEmail (from, to, subject, plainTextContent, htmlContent);
            var response = await client.SendEmailAsync (msg);

            /*var client = new SendGridClient (apiKey);
            var msg = new SendGridMessage () {
                From = new EmailAddress ("Joe@contoso.com", "Joe Smith"),
                Subject = subject,
                PlainTextContent = message,
                HtmlContent = message
            };

            msg.AddTo (new EmailAddress (email));

            // Disable click tracking.
            // See https://sendgrid.com/docs/User_Guide/Settings/tracking.html
            msg.TrackingSettings = new TrackingSettings {
                ClickTracking = new ClickTracking { Enable = false }
            };

            var response = client.SendEmailAsync (msg);

            return response;*/
        }

        /*public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            throw new System.NotImplementedException();
        }*/
    }
}