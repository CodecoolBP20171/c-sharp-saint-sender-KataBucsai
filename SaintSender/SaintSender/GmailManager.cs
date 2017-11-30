using S22.Imap;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class GmailManager
    {

        public string AccountName { get; set; }
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


        private ImapClient GetClient()
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
    }
}
