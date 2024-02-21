using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Configuration;
using MimeKit;
using SpaAuth.Services.Interface;
using System;

namespace SpaAuth.Services
{
    public class SimpleMailerService : ISimpleMailerService
    {

        IConfiguration _configuration;

        public SimpleMailerService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void SendEmail(string toEmail, string subject, string body)
        {
          
            try
            {
                string mailerPassword = _configuration["Hostinger:MailPassword"];

                string smtpServer = "smtp.hostinger.com";
                int smtpPort = 587;
                string smtpUsername = "sachaamm@zyndoria.com";
                string smtpPassword = mailerPassword;

                string fromEmail = smtpUsername;
       
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("", fromEmail));
                message.To.Add(new MailboxAddress("", toEmail));
                message.Subject = subject;
                message.Body = new TextPart("plain") { Text = body };

                using (var client = new MailKit.Net.Smtp.SmtpClient())
                {
                    client.Connect(smtpServer, smtpPort, SecureSocketOptions.StartTls);
                    client.Authenticate(smtpUsername, smtpPassword);
                    client.Send(message);
                    client.Disconnect(true);
                }

                Console.WriteLine("Email sent successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex is SmtpCommandException smtpEx)
                {
                    Console.WriteLine($"SMTP Response: {smtpEx.StatusCode}");
                }
            }
        }   

    }
}
