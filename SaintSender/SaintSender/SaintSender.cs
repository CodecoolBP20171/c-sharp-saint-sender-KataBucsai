using Google.Apis.Gmail.v1.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaintSender
{
    public partial class SaintSender : Form
    {

        public SaintSender()
        {
            InitializeComponent();
        }

        private void SaintSeder_Load(object sender, EventArgs e)
        {
            IEnumerable<string> mailboxes = GmailManager.GetMailboxes();
            foreach (var mailbox in mailboxes)
            {
                string mailboxName = mailbox;
                if (!mailbox.Equals("INBOX"))
                {                    
                    mailboxName = mailbox.Substring(mailbox.IndexOf('/') + 1);
                }
                ListViewItem listViewItem = new ListViewItem(mailboxName);
                listViewItem.Tag = mailbox;
                listViewMailboxes.Items.Add(listViewItem);
            }
            IEnumerable<MailMessage> messages = EmailDataHandler.GetEmailList();
            int counter = 0;
            foreach (var message in messages)
            {
                DataGridViewRow row = new DataGridViewRow();
                var From = message.From;
                var Subject = message.Subject;
                var Date = message.Headers["Date"];               
                var rowIndex = dataGVListEmails.Rows.Add(new object[] {false, From, Subject, Date});
                dataGVListEmails.Rows[rowIndex].Tag = message;
                counter++;
            }
        }

        private void dataGVListEmails_Click(object sender, EventArgs e)
        {
            MailMessage message = (MailMessage)dataGVListEmails.SelectedRows[0].Tag;
            richTextBox2.Text = message.Body;
        }
    }
}
