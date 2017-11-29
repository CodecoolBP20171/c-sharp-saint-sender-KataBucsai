using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace SaintSender
{
    class EmailDataHandler
    {
        public static IEnumerable<MailMessage> GetEmailList()
        {
            List<MailMessage> messages = new List<MailMessage>();
            
            IEnumerable<MailMessage> baseMessages = GmailManager.GetMessages();

            return baseMessages;
        }
    }
}
