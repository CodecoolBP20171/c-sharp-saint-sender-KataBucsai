namespace SaintSender
{
    partial class SaintSender
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewMailboxes = new System.Windows.Forms.ListView();
            this.dataGVListEmails = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCompose = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBSelectAll = new System.Windows.Forms.CheckBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.ColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReply = new System.Windows.Forms.Button();
            this.btnReplyAll = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.labelInputNotVallid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListEmails)).BeginInit();
            this.MenuAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 100);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnReplyAll);
            this.splitContainer1.Panel1.Controls.Add(this.btnReply);
            this.splitContainer1.Panel1.Controls.Add(this.listViewMailboxes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGVListEmails);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(928, 395);
            this.splitContainer1.SplitterDistance = 103;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewMailboxes
            // 
            this.listViewMailboxes.Location = new System.Drawing.Point(0, 0);
            this.listViewMailboxes.Name = "listViewMailboxes";
            this.listViewMailboxes.Size = new System.Drawing.Size(100, 157);
            this.listViewMailboxes.TabIndex = 0;
            this.listViewMailboxes.UseCompatibleStateImageBehavior = false;
            this.listViewMailboxes.View = System.Windows.Forms.View.List;
            // 
            // dataGVListEmails
            // 
            this.dataGVListEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelected,
            this.ColFrom,
            this.ColSubject,
            this.ColDate});
            this.dataGVListEmails.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGVListEmails.Location = new System.Drawing.Point(0, 0);
            this.dataGVListEmails.MultiSelect = false;
            this.dataGVListEmails.Name = "dataGVListEmails";
            this.dataGVListEmails.ReadOnly = true;
            this.dataGVListEmails.RowHeadersVisible = false;
            this.dataGVListEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGVListEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVListEmails.Size = new System.Drawing.Size(821, 157);
            this.dataGVListEmails.TabIndex = 2;
            this.dataGVListEmails.Click += new System.EventHandler(this.dataGVListEmails_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBox2.Location = new System.Drawing.Point(0, 163);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(821, 232);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(12, 73);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(100, 23);
            this.btnCompose.TabIndex = 1;
            this.btnCompose.Text = "Compose";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(121, 9);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(239, 20);
            this.textBoxSearch.TabIndex = 2;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Gray;
            this.btnSearch.Location = new System.Drawing.Point(40, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(72, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBSelectAll
            // 
            this.checkBSelectAll.AutoSize = true;
            this.checkBSelectAll.Location = new System.Drawing.Point(137, 77);
            this.checkBSelectAll.Name = "checkBSelectAll";
            this.checkBSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBSelectAll.TabIndex = 4;
            this.checkBSelectAll.Text = "Select All";
            this.checkBSelectAll.UseVisualStyleBackColor = true;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccount.ForeColor = System.Drawing.Color.Teal;
            this.labelAccount.Location = new System.Drawing.Point(793, 12);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAccount.Size = new System.Drawing.Size(54, 23);
            this.labelAccount.TabIndex = 6;
            this.labelAccount.Text = "Account";
            this.labelAccount.Click += new System.EventHandler(this.labelAccount_Click);
            // 
            // MenuAccount
            // 
            this.MenuAccount.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemSignIn,
            this.MenuItemSettings,
            this.MenuItemLogout});
            this.MenuAccount.Name = "Me";
            this.MenuAccount.Size = new System.Drawing.Size(117, 70);
            // 
            // MenuItemSignIn
            // 
            this.MenuItemSignIn.Name = "MenuItemSignIn";
            this.MenuItemSignIn.Size = new System.Drawing.Size(116, 22);
            this.MenuItemSignIn.Text = "Sign in";
            // 
            // MenuItemSettings
            // 
            this.MenuItemSettings.Name = "MenuItemSettings";
            this.MenuItemSettings.Size = new System.Drawing.Size(116, 22);
            this.MenuItemSettings.Text = "Settings";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(116, 22);
            this.MenuItemLogout.Text = "Log out";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(40, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(72, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ColSelected
            // 
            this.ColSelected.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ColSelected.HeaderText = "Selected";
            this.ColSelected.Name = "ColSelected";
            this.ColSelected.ReadOnly = true;
            this.ColSelected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSelected.Width = 55;
            // 
            // ColFrom
            // 
            this.ColFrom.HeaderText = "From";
            this.ColFrom.Name = "ColFrom";
            this.ColFrom.ReadOnly = true;
            this.ColFrom.Width = 248;
            // 
            // ColSubject
            // 
            this.ColSubject.HeaderText = "Subject";
            this.ColSubject.Name = "ColSubject";
            this.ColSubject.ReadOnly = true;
            this.ColSubject.Width = 249;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            this.ColDate.Width = 249;
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(0, 163);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(100, 23);
            this.btnReply.TabIndex = 1;
            this.btnReply.Text = "Reply";
            this.btnReply.UseVisualStyleBackColor = true;
            // 
            // btnReplyAll
            // 
            this.btnReplyAll.Location = new System.Drawing.Point(0, 192);
            this.btnReplyAll.Name = "btnReplyAll";
            this.btnReplyAll.Size = new System.Drawing.Size(100, 23);
            this.btnReplyAll.TabIndex = 2;
            this.btnReplyAll.Text = "Reply All";
            this.btnReplyAll.UseVisualStyleBackColor = true;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(293, 45);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(365, 42);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(164, 20);
            this.textBoxUsername.TabIndex = 10;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(365, 68);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(164, 20);
            this.textBoxPassword.TabIndex = 12;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(295, 71);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "Password";
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(552, 66);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 13;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // labelInputNotVallid
            // 
            this.labelInputNotVallid.AutoSize = true;
            this.labelInputNotVallid.Location = new System.Drawing.Point(362, 17);
            this.labelInputNotVallid.Name = "labelInputNotVallid";
            this.labelInputNotVallid.Size = new System.Drawing.Size(168, 13);
            this.labelInputNotVallid.TabIndex = 14;
            this.labelInputNotVallid.Text = "Username or password is not valid";
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 530);
            this.Controls.Add(this.labelInputNotVallid);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.checkBSelectAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.btnCompose);
            this.Controls.Add(this.splitContainer1);
            this.Name = "SaintSender";
            this.Text = "SaintSender";
            this.Load += new System.EventHandler(this.SaintSeder_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVListEmails)).EndInit();
            this.MenuAccount.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnCompose;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBSelectAll;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ContextMenuStrip MenuAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSignIn;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGVListEmails;
        private System.Windows.Forms.ListView listViewMailboxes;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.Button btnReplyAll;
        private System.Windows.Forms.Button btnReply;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Label labelInputNotVallid;
    }
}