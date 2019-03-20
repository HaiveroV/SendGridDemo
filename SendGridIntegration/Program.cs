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
            var apiKey = "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";
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("mhaiverov@gmail.com", "Team Kepler"),
                Subject = "SendGrid Test Email",
                PlainTextContent = "Don't mind me im passing by",
                HtmlContent = "<strong>Hello there friend! " +
                "This is an automated message used to prove " +
                "that the service is working." +
                "Обичам те мила моя !!!</strong>"
            };
            var recipients = new List<EmailAddress>
            {
                new EmailAddress("petq.d.s@gmail.com"),
                
            };
                msg.AddTos(recipients);
            var response = await client.SendEmailAsync(msg);
        }
    }
}
