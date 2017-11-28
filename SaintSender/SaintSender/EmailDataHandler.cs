using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaintSender
{
    class EmailDataHandler
    {
        public static List<Message> GetEmailList()
        {
            List<Message> messages = new List<Message>();
            GmailAPIHandler gmailAPIHandler = new GmailAPIHandler();
            List<Message> baseMessages = gmailAPIHandler.ListMessages();

            foreach (var item in baseMessages)
            {
                Message message = gmailAPIHandler.GetMessage(item.Id);
                messages.Add(message);
            }
            return messages;
        }
    }
}
