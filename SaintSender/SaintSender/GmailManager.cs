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
        private static ImapClient GetClient()
        {
            string hostname = "imap.gmail.com";
            string username = "tesztelemaprogramom@gmail.com";
            string password = "Tesytelem123";
            // The default port for IMAP over SSL is 993.
            ImapClient client = new ImapClient(hostname, 993, username, password, AuthMethod.Login, true);
            return client;
        }

        public static IEnumerable<MailMessage> GetMessages()
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

        public static IEnumerable<string> GetMailboxes()
        {
            ImapClient client = GetClient();
            using (client)
            {
                IEnumerable<string> mailboxes = client.ListMailboxes();
                return mailboxes;
            }
        }

        public static IEnumerable<MailMessage> GetSearchedMessages(string pattern)
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
