﻿namespace SaintSender
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
            this.ColSelected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ColFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnCompose = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBSelectAll = new System.Windows.Forms.CheckBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.MenuAccount = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuItemSignIn = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.Button();
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
            this.splitContainer1.Location = new System.Drawing.Point(0, 102);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewMailboxes);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGVListEmails);
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox2);
            this.splitContainer1.Size = new System.Drawing.Size(747, 313);
            this.splitContainer1.SplitterDistance = 131;
            this.splitContainer1.TabIndex = 0;
            // 
            // listViewMailboxes
            // 
            this.listViewMailboxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewMailboxes.Location = new System.Drawing.Point(0, 0);
            this.listViewMailboxes.Name = "listViewMailboxes";
            this.listViewMailboxes.Size = new System.Drawing.Size(131, 313);
            this.listViewMailboxes.TabIndex = 0;
            this.listViewMailboxes.UseCompatibleStateImageBehavior = false;
            this.listViewMailboxes.View = System.Windows.Forms.View.List;
            // 
            // dataGVListEmails
            // 
            this.dataGVListEmails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVListEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVListEmails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSelected,
            this.ColFrom,
            this.ColSubject,
            this.ColDate});
            this.dataGVListEmails.Location = new System.Drawing.Point(3, 3);
            this.dataGVListEmails.MultiSelect = false;
            this.dataGVListEmails.Name = "dataGVListEmails";
            this.dataGVListEmails.ReadOnly = true;
            this.dataGVListEmails.RowHeadersVisible = false;
            this.dataGVListEmails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGVListEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGVListEmails.Size = new System.Drawing.Size(609, 157);
            this.dataGVListEmails.TabIndex = 2;
            this.dataGVListEmails.Click += new System.EventHandler(this.dataGVListEmails_Click);
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
            // 
            // ColSubject
            // 
            this.ColSubject.HeaderText = "Subject";
            this.ColSubject.Name = "ColSubject";
            this.ColSubject.ReadOnly = true;
            // 
            // ColDate
            // 
            this.ColDate.HeaderText = "Date";
            this.ColDate.Name = "ColDate";
            this.ColDate.ReadOnly = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(2, 166);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(610, 144);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            // 
            // btnCompose
            // 
            this.btnCompose.Location = new System.Drawing.Point(0, 73);
            this.btnCompose.Name = "btnCompose";
            this.btnCompose.Size = new System.Drawing.Size(131, 23);
            this.btnCompose.TabIndex = 1;
            this.btnCompose.Text = "Compose";
            this.btnCompose.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(79, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // checkBSelectAll
            // 
            this.checkBSelectAll.AutoSize = true;
            this.checkBSelectAll.Location = new System.Drawing.Point(159, 77);
            this.checkBSelectAll.Name = "checkBSelectAll";
            this.checkBSelectAll.Size = new System.Drawing.Size(70, 17);
            this.checkBSelectAll.TabIndex = 4;
            this.checkBSelectAll.Text = "Select All";
            this.checkBSelectAll.UseVisualStyleBackColor = true;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(670, 17);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(47, 13);
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
            this.btnRefresh.Location = new System.Drawing.Point(659, 71);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // SaintSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 436);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelAccount);
            this.Controls.Add(this.checkBSelectAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox checkBSelectAll;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.ContextMenuStrip MenuAccount;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSignIn;
        private System.Windows.Forms.ToolStripMenuItem MenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.DataGridView dataGVListEmails;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColSelected;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDate;
        private System.Windows.Forms.ListView listViewMailboxes;
    }
}