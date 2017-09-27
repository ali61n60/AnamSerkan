using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using AnamSerkan.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace AnamSerkan.Infrastructure
{
    public class Email
    {
        public void SendEmail(string emailAddress, Message message)
        {
            MimeMessage emailMessage = new MimeMessage();
            BodyBuilder bodyBuilder = new BodyBuilder();

            bodyBuilder.HtmlBody = $"<h1>{message.Title}</h1><br/>" +
                                   $"متن پیام" +
                                   $"<br/>" +
                                   $"{message.MessageDetail}" +
                                   $"<br/>" +
                                   $"نام فرستنده" +
                                   $"<br/>" +
                                   $"{message.Name}" +
                                   $"<br/>" +
                                   $"شماره تلفن" +
                                   $"<br/>" +
                                   $"{message.PhoneNumber}" +
                                   $"<br/>" +
                                   $"ایمیل" +
                                   $"<br/>"+
                                   $"{message.Email}<br/>";

            emailMessage.Body = bodyBuilder.ToMessageBody();



            emailMessage.From.Add(new MailboxAddress("AnamSerkan Server Message", "message@anamserkan.ir"));
            emailMessage.To.Add(new MailboxAddress("", emailAddress));
            emailMessage.Subject = message.Title;

            using (var client = new SmtpClient())
            {
                client.Connect("mail.anamserkan.ir", 25);
                // Note: since we don't have an OAuth2 token, disable
                // the XOAUTH2 authentication mechanism.
                client.AuthenticationMechanisms.Remove("XOAUTH2");

                // Note: only needed if the SMTP server requires authentication
                client.Authenticate("message@anamserkan.ir", "119801");



                client.Send(emailMessage);
                client.Disconnect(true);
            }
        }

    }
}



