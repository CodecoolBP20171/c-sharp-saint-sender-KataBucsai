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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            this.splitContainer1.Panel1.Controls.Add(this.button2);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
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
            this.btnCompose.Size = new System.Drawing.Size(103, 23);
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
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
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
            this.labelAccount.Location = new System.Drawing.Point(793, 12);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.labelAccount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelAccount.Size = new System.Drawing.Size(47, 23);
            this.labelAccount.TabIndex = 6;
            this.labelAccount.Text = "Account";
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
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(40, 36);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(14, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 530);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}