using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System.Net.Mail;
using System.Net;

namespace server.Helpers.Email
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            var fromAddress = new MailAddress("crypticmessenger.itstep@gmail.com", "Cryptic");
            if (mailRequest.Body != null && mailRequest.ToEmail != null && mailRequest.Subject != null) 
            {
                var toAddress = new MailAddress(mailRequest.ToEmail);
                const string fromPassword = "cgfskiewgbowfcvs";

                var smtp = new System.Net.Mail.SmtpClient
                {
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
                    Timeout = 20000
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = mailRequest.Subject,
                    Body = mailRequest.Body,
                })
                {
                    await smtp.SendMailAsync(message);
                }
            }
        }
    }
}
