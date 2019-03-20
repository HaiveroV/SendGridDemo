using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SendGrid;
using SendGrid.Helpers.Mail;
namespace SendGridIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            Execute().Wait();
        }
        static async Task Execute()
        {
            var apiKey = "Your SendGrid apiKey";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("YourEmail@example.com", ""),
                Subject = "SendGrid Test Email",
                PlainTextContent = "Don't mind me im passing by",
                HtmlContent = "<strong>Hello there friend! " +
                "This is an automated message used to prove " +
                "that the service is working." +
                </strong>"
            };
            var recipients = new List<EmailAddress>
            {
                new EmailAddress("Desired Email u want to send to"),
                
            };
                msg.AddTos(recipients);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
