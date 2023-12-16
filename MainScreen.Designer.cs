namespace DisburstmentJournal
{
    partial class MainScreen
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssCaption = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSplitter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDatabaseStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssSplitter2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.disbursementJournalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incomeStatementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trialBalanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vatAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deductionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.collectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.outputVatSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOfAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountReceivablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disbursementJournalToolStripMenuItem,
            this.transactionsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.masterFileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1045, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssCaption,
            this.tssSplitter,
            this.tssDatabaseStatus,
            this.tssSplitter2,
            this.tssDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 467);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1045, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssCaption
            // 
            this.tssCaption.Name = "tssCaption";
            this.tssCaption.Size = new System.Drawing.Size(250, 17);
            this.tssCaption.Text = "Welcome to DISBURSMENT JOURNAL SYSTEM";
            // 
            // tssSplitter
            // 
            this.tssSplitter.Name = "tssSplitter";
            this.tssSplitter.Size = new System.Drawing.Size(313, 17);
            this.tssSplitter.Spring = true;
            this.tssSplitter.Text = " ";
            // 
            // tssDatabaseStatus
            // 
            this.tssDatabaseStatus.Name = "tssDatabaseStatus";
            this.tssDatabaseStatus.Size = new System.Drawing.Size(93, 17);
            this.tssDatabaseStatus.Text = "Database Status:";
            // 
            // tssSplitter2
            // 
            this.tssSplitter2.Name = "tssSplitter2";
            this.tssSplitter2.Size = new System.Drawing.Size(313, 17);
            this.tssSplitter2.Spring = true;
            this.tssSplitter2.Text = "   ";
            // 
            // tssDateTime
            // 
            this.tssDateTime.Name = "tssDateTime";
            this.tssDateTime.Size = new System.Drawing.Size(60, 17);
            this.tssDateTime.Text = "DATETIME";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // disbursementJournalToolStripMenuItem
            // 
            this.disbursementJournalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEntryToolStripMenuItem});
            this.disbursementJournalToolStripMenuItem.Name = "disbursementJournalToolStripMenuItem";
            this.disbursementJournalToolStripMenuItem.Size = new System.Drawing.Size(133, 20);
            this.disbursementJournalToolStripMenuItem.Text = "&Disbursement Journal";
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dataEntryToolStripMenuItem.Text = "Data &Entry";
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tAccountsToolStripMenuItem,
            this.incomeStatementToolStripMenuItem,
            this.trialBalanceToolStripMenuItem,
            this.vatAnalysisToolStripMenuItem,
            this.deductionsToolStripMenuItem,
            this.collectionsToolStripMenuItem});
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.transactionsToolStripMenuItem.Text = "&Transactions";
            // 
            // masterFileToolStripMenuItem
            // 
            this.masterFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chartOfAccountsToolStripMenuItem,
            this.accountReceivablesToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.clientsToolStripMenuItem});
            this.masterFileToolStripMenuItem.Name = "masterFileToolStripMenuItem";
            this.masterFileToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.masterFileToolStripMenuItem.Text = "&MasterFile";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tAccountsToolStripMenuItem
            // 
            this.tAccountsToolStripMenuItem.Name = "tAccountsToolStripMenuItem";
            this.tAccountsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tAccountsToolStripMenuItem.Text = "T-&Account";
            // 
            // incomeStatementToolStripMenuItem
            // 
            this.incomeStatementToolStripMenuItem.Name = "incomeStatementToolStripMenuItem";
            this.incomeStatementToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.incomeStatementToolStripMenuItem.Text = "&Income Statement";
            // 
            // trialBalanceToolStripMenuItem
            // 
            this.trialBalanceToolStripMenuItem.Name = "trialBalanceToolStripMenuItem";
            this.trialBalanceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trialBalanceToolStripMenuItem.Text = "Trial &Balance";
            // 
            // vatAnalysisToolStripMenuItem
            // 
            this.vatAnalysisToolStripMenuItem.Name = "vatAnalysisToolStripMenuItem";
            this.vatAnalysisToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vatAnalysisToolStripMenuItem.Text = "&Vat Analysis";
            // 
            // deductionsToolStripMenuItem
            // 
            this.deductionsToolStripMenuItem.Name = "deductionsToolStripMenuItem";
            this.deductionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deductionsToolStripMenuItem.Text = "&Deductions";
            // 
            // collectionsToolStripMenuItem
            // 
            this.collectionsToolStripMenuItem.Name = "collectionsToolStripMenuItem";
            this.collectionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.collectionsToolStripMenuItem.Text = "&Collections";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputVatSummaryToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem1.Text = "&Reports";
            // 
            // outputVatSummaryToolStripMenuItem
            // 
            this.outputVatSummaryToolStripMenuItem.Name = "outputVatSummaryToolStripMenuItem";
            this.outputVatSummaryToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.outputVatSummaryToolStripMenuItem.Text = "&Output Vat Summary";
            // 
            // chartOfAccountsToolStripMenuItem
            // 
            this.chartOfAccountsToolStripMenuItem.Name = "chartOfAccountsToolStripMenuItem";
            this.chartOfAccountsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.chartOfAccountsToolStripMenuItem.Text = "&Chart of Accounts";
            // 
            // accountReceivablesToolStripMenuItem
            // 
            this.accountReceivablesToolStripMenuItem.Name = "accountReceivablesToolStripMenuItem";
            this.accountReceivablesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.accountReceivablesToolStripMenuItem.Text = "&Account Receivables";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.usersToolStripMenuItem.Text = "&Users";
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.rolesToolStripMenuItem.Text = "&Roles";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.clientsToolStripMenuItem.Text = "C&lients Profile";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 489);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainScreen_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainScreen_FormClosed);
            this.Load += new System.EventHandler(this.MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssCaption;
        private System.Windows.Forms.ToolStripStatusLabel tssSplitter;
        private System.Windows.Forms.ToolStripStatusLabel tssDatabaseStatus;
        private System.Windows.Forms.ToolStripStatusLabel tssSplitter2;
        private System.Windows.Forms.ToolStripStatusLabel tssDateTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem disbursementJournalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeStatementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trialBalanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vatAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deductionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem collectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem outputVatSummaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chartOfAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountReceivablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
    }
}