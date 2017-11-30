using S22.Imap;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class GmailManager
    {

        public string AccountName { get; set; }
        public bool IsSignedIn { get; set; }
        string Username;
        string Password;
        string Hostname;

        public GmailManager()
        { 
            this.Hostname = "imap.gmail.com";
        }

        public void InitAccount(string username, string password)
        {
            this.Username = username;
            AccountName = username.Split('@')[0];
            this.Password = password;
        }


        public ImapClient GetClient()
        {
            // The default port for IMAP over SSL is 993.
            ImapClient client = new ImapClient(Hostname, 993, Username, Password, AuthMethod.Login, true);
            return client;
        }

        public IEnumerable<MailMessage> GetMessages()
        {
            IEnumerable<MailMessage> messages;
            ImapClient client = GetClient();
            using (client)
            {
                IEnumerable<uint> uids = client.Search( SearchCondition.All() );
                messages = client.GetMessages(uids);
            }

            return messages;
        }

        public IEnumerable<string> GetMailboxes()
        {
            ImapClient client = GetClient();
            using (client)
            {
                IEnumerable<string> mailboxes = client.ListMailboxes();
                return mailboxes;
            }
        }

        public IEnumerable<MailMessage> GetSearchedMessages(string pattern)
        {
            IEnumerable<MailMessage> messages;
            ImapClient client = GetClient();
            using (client)
            {
                IEnumerable<uint> uids = client.Search(SearchCondition.From(pattern).Or(
                    SearchCondition.Subject(pattern)));
                messages = client.GetMessages(uids);
            }
            return messages;
        }

        public MailMessage CreateMail(MailMessage originalMail, string newMail)
        {
            MailMessage reply = new MailMessage(new MailAddress(Username, AccountName), originalMail.From);
            string id = originalMail.Headers["Message-ID"];
            reply.Headers.Add("In-Reply-To", id);
            string references = originalMail.Headers["References"];

            if (!string.IsNullOrEmpty(references))
                references += ' ';

            reply.Headers.Add("References", references + id);
            if (!originalMail.Subject.StartsWith("Re:", StringComparison.OrdinalIgnoreCase))
                reply.Subject = "Re: ";

            reply.Subject += originalMail.Subject;

            StringBuilder body = new StringBuilder();

            body.Append(newMail);
            if (originalMail.Date().HasValue)
                body.AppendFormat("On {0}, ", originalMail.Date().Value.ToString(CultureInfo.InvariantCulture));

            body.Append(originalMail.From);
            body.AppendLine(" wrote:");

            if (!string.IsNullOrEmpty(originalMail.Body))
            {
                body.AppendLine();
                body.Append("> " + originalMail.Body.Replace("\r\n", "\r\n> "));
            }
            reply.Body = body.ToString();

            return reply;
        }

        internal void SendMail(MailMessage originalMail, string newMailText)
        {
            MailMessage message = CreateMail(originalMail, newMailText);
            using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
            {
                // Set SMTP client properties 
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(Username, Password);
                client.DeliveryFormat = SmtpDeliveryFormat.International;

                client.Send(message);
                message.Dispose();
            }
        }
    }
}
