using System;
using System.Threading.Tasks;
using MailKit;
using MailKit.Net.Smtp;
using MimeKit;


namespace Portfolio.Misc.Services
{
    public class EmailService : IEmailService
    {
        public async Task SendEmail(string email, string text)
        {
            
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Моя компания", "asd@gmail.com"));
            message.To.Add(new MailboxAddress("",email));
            message.Subject = text;

            using (MailKit.Net.Smtp.SmtpClient client = new MailKit.Net.Smtp.SmtpClient())
            {
                await client.ConnectAsync("smtp.gamil.com", 465, true);
                await client.AuthenticateAsync("bot@gmail.com", Environment.GetEnvironmentVariable("****"));
                await client.SendAsync(message);

                await client.DisconnectAsync(true);
            }

        }
    }
}