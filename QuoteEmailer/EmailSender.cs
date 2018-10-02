using MailKit.Net.Smtp;
using MimeKit;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.IO;



namespace QuoteEmailer
{
    public class EmailSender
    {
        public static void SendEmailWithSmtp(string emailOfReceiver, string nameOfReceiver, Quote q, WikiPage wikiPage)
        {
            // Compose a message
            MimeMessage mail = new MimeMessage();
            mail.From.Add(new MailboxAddress("Quotes by email", "INSERT POST EMAIL HERE"));
            mail.To.Add(new MailboxAddress(nameOfReceiver, emailOfReceiver));
            mail.Subject = "Quote by email";
            mail.Body = new TextPart("plain")
            {
                Text = @"Hello " + nameOfReceiver +
                ", As requested, here is a famous quote!" +
                "\n" +
                "\n --- Quote and author ---" +
                "\n '" + q.quote + "'" +
                "\n - " + q.author +
                "\n " +
                "\n " +
                "\n  --- About the author ---"
                +  "\n " + wikiPage.wikiText
            };

            // Send it!
            using (var client = new SmtpClient())
            {
                // XXX - Should this be a little different?
                client.ServerCertificateValidationCallback = (s, c, h, e) => true;

                client.Connect("smtp.mailgun.org", 25, false);
                client.AuthenticationMechanisms.Remove("XOAUTH2");
                client.Authenticate("INSERT POST EMAIL HERE", "INSERT PASSWORD HERE");

                client.Send(mail);
                client.Disconnect(true);
            }
        }

    }
}
