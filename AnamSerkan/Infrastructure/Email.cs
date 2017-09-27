using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace AnamSerkan.Infrastructure
{
    public class Email
    {
        public void SendEmail(string email, string subject, string message)
        {
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("AnamSerkan Server Message", "message@anamserkan.ir"));
            emailMessage.To.Add(new MailboxAddress("Ali Nejati", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart("plain") { Text = message };

            using (var client = new SmtpClient())
            {
                client.Connect("smtp.anamserkan.ir", 25, SecureSocketOptions.None);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("message@anamserkan.ir", "119801");

                
                
                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }
        //public void SendEmail(string emailAddress, string message, string subject)
        //{
            //TODO log email into database
            //MailMessage mailMessage = new MailMessage();
            //mailMessage.To.Add(emailAddress);
            //mailMessage.From = new MailAddress("mail@ayoobfarsh.ir");
            //mailMessage.Subject = subject;
            //mailMessage.Body = message;
            //mailMessage.IsBodyHtml = true;
            //System.Net.Mail.


            //SmtpClient smtpClient = new SmtpClient("smtp.ayoobfarsh.ir", 25);
            //smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtpClient.EnableSsl = false;
            //smtpClient.Credentials = new System.Net.NetworkCredential("mail@ayoobfarsh.ir", "119801");
            //smtpClient.Send(mailMessage);
        //}
    }
}



