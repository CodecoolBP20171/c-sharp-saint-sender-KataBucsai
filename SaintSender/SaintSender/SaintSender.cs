using Google.Apis.Gmail.v1.Data;
using S22.Imap;
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
        GmailManager gmailManager;
        System.Windows.Forms.Timer timer;

        public SaintSender()
        {
            InitializeComponent();
            gmailManager = new GmailManager();
            gmailManager.InitAccount("tesztelemaproramom@gmail.com", "Tesytelem123");
        }

        private void SaintSeder_Load(object sender, EventArgs e)
        {
            InitLoggedOutView();
        }

        private void Account_Load()
        { 
            IEnumerable<string> mailboxes = gmailManager.GetMailboxes();           
            ShowMailboxes(mailboxes);
            IEnumerable<MailMessage> messages = gmailManager.GetMessages();
            ShowMails(messages);
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 50000;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();

            labelAccount.Text = gmailManager.AccountName;
            btnSearch.Enabled = false;
        }

        private void dataGVListEmails_Click(object sender, EventArgs e)
        {
            MailMessage message = (MailMessage)dataGVListEmails.SelectedRows[0].Tag;
            richTextBox2.Text = message.Body;
            richTextBox2.Tag = message;
            btnReply.Visible = true;
            btnReplyAll.Visible = true;
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Length > 0)
            {
                btnSearch.ForeColor = Color.Black;
                btnSearch.Enabled = true;
            } else
            {
                btnSearch.ForeColor = Color.Gray;
                btnSearch.Enabled = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string pattern = textBoxSearch.Text;
            IEnumerable<MailMessage> messages = gmailManager.GetSearchedMessages(pattern);
            if (messages.Count() > 0)
            {
                ShowMails(messages);
            }
            btnReply.Visible = false;
            btnReplyAll.Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            IEnumerable<MailMessage> messages = gmailManager.GetMessages();
            ShowMails(messages);
        }

        private void ShowMailboxes(IEnumerable<string> mailboxes)
        {
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
        }

        private void ShowMails(IEnumerable<MailMessage> messages)
        {
            int counter = 0;
            dataGVListEmails.Rows.Clear();
            foreach (var message in messages)
            {
                DataGridViewRow row = new DataGridViewRow();
                var From = message.From;
                var Subject = message.Subject;
                var Date = message.Headers["Date"];
                var rowIndex = dataGVListEmails.Rows.Add(new object[] { false, From, Subject, Date });
                dataGVListEmails.Rows[rowIndex].Tag = message;
                counter++;
            }
            dataGVListEmails.Sort(dataGVListEmails.Columns[3], ListSortDirection.Ascending);
        }

        private void labelAccount_Click(object sender, EventArgs e)
        {
            MenuItemSignIn.Visible = false;
            Point ptLowerLeft = new Point(0, labelAccount.Height);
            ptLowerLeft = labelAccount.PointToScreen(ptLowerLeft);
            MenuAccount.Show(ptLowerLeft);

        }

        private void MenuItemLogout_Click(object sender, EventArgs e)
        {
            InitLoggedOutView();
            timer.Stop();
        }

        private void InitLoggedOutView()
        {
            labelAccount.Visible = false;
            labelUsername.Visible = true;
            labelPassword.Visible = true;
            labelInputNotVallid.Visible = false;
            btnCompose.Visible = false;
            btnRefresh.Visible = false;
            btnReply.Visible = false;
            btnReplyAll.Visible = false;
            btnSearch.Visible = false;
            btnSend.Visible = false;
            btnSignIn.Visible = true;
            dataGVListEmails.Visible = false;
            textBoxSearch.Visible = false;
            textBoxPassword.Visible = true;
            textBoxUsername.Visible = true;
            richTextBox2.Visible = false;
            listViewMailboxes.Visible = false;
            splitContainer1.Visible = false;
            checkBSelectAll.Visible = false;

            textBoxSearch.Clear();
            dataGVListEmails.Rows.Clear();
            richTextBox2.Clear();
            listViewMailboxes.Clear();
        }

        private void InitSignedInView()
        {
            labelAccount.Visible = true;
            labelUsername.Visible = false;
            labelPassword.Visible = false;
            labelInputNotVallid.Visible = false;
            btnCompose.Visible = true;
            btnRefresh.Visible = true;
            btnSearch.Visible = true;
            btnSignIn.Visible = false;
            dataGVListEmails.Visible = true;
            textBoxSearch.Visible = true;
            textBoxPassword.Visible = false;
            textBoxUsername.Visible = false;
            richTextBox2.Visible = true;
            listViewMailboxes.Visible = true;
            splitContainer1.Visible = true;
            checkBSelectAll.Visible = true;

            textBoxUsername.Clear();
            textBoxPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string Username = textBoxUsername.Text;
            string Password = textBoxPassword.Text;
            try
            {
                gmailManager.InitAccount(Username, Password);
                Account_Load();
                InitSignedInView();
            }
            catch (InvalidCredentialsException er)
            {
                InitLoggedOutView();
                labelInputNotVallid.Visible = true;
            }
        }

        private void btnCompose_Click(object sender, EventArgs e)
        {
            if (true)
            {
                btnSend.Visible = true;
            }
        }

        private void btnReply_Click(object sender, EventArgs e)
        {

            try
            {              
                gmailManager.SendMail((MailMessage)richTextBox2.Tag, richTextBox2.Text);
                richTextBox2.Clear();
                btnSend.Visible = false;
            }
            catch (Exception)
            {

                
            }
        }

        void timer_Tick(object sender, EventArgs e)
        {
            IEnumerable<MailMessage> messages = gmailManager.GetMessages();
            ShowMails(messages);
        }
    }
}
