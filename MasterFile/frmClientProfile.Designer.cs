namespace DisburstmentJournal.MasterFile
{
    partial class frmClientProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbCriteria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgRecords = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pbCompanyLogo = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnBrowseLogo = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbIsEnabled = new System.Windows.Forms.CheckBox();
            this.tbPOCNumber = new System.Windows.Forms.TextBox();
            this.tbPOC = new System.Windows.Forms.TextBox();
            this.tbRemarks = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbTIN = new System.Windows.Forms.TextBox();
            this.tbClientCode = new System.Windows.Forms.TextBox();
            this.tbID = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssTotalRecords = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssActiveClient = new System.Windows.Forms.ToolStripStatusLabel();
            this.filler1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssShortCuts = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.shorcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "&Category:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lblResult);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.tbCriteria);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbFilterBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 118);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Here";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(6, 97);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Result:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(131, 65);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(70, 23);
            this.btnClear.TabIndex = 30;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(55, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 28;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbCriteria
            // 
            this.tbCriteria.Location = new System.Drawing.Point(55, 39);
            this.tbCriteria.Name = "tbCriteria";
            this.tbCriteria.Size = new System.Drawing.Size(168, 20);
            this.tbCriteria.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "&Text:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "Client Code",
            "Client Name",
            "TIN",
            "Point Of Contact",
            "Address"});
            this.cbFilterBy.Location = new System.Drawing.Point(55, 15);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(168, 21);
            this.cbFilterBy.TabIndex = 27;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgRecords);
            this.groupBox2.Location = new System.Drawing.Point(13, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(838, 190);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client Lists";
            // 
            // dgRecords
            // 
            this.dgRecords.AllowUserToAddRows = false;
            this.dgRecords.AllowUserToDeleteRows = false;
            this.dgRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRecords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgRecords.Location = new System.Drawing.Point(3, 16);
            this.dgRecords.Name = "dgRecords";
            this.dgRecords.ReadOnly = true;
            this.dgRecords.Size = new System.Drawing.Size(832, 171);
            this.dgRecords.TabIndex = 4;
            this.dgRecords.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRecords_CellContentDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Controls.Add(this.btnClear2);
            this.groupBox3.Controls.Add(this.btnSave);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.cbIsEnabled);
            this.groupBox3.Controls.Add(this.tbPOCNumber);
            this.groupBox3.Controls.Add(this.tbPOC);
            this.groupBox3.Controls.Add(this.tbRemarks);
            this.groupBox3.Controls.Add(this.tbAddress);
            this.groupBox3.Controls.Add(this.tbClientName);
            this.groupBox3.Controls.Add(this.tbTIN);
            this.groupBox3.Controls.Add(this.tbClientCode);
            this.groupBox3.Controls.Add(this.tbID);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(8, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(862, 573);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Data Entry";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.pbCompanyLogo);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Controls.Add(this.btnBrowseLogo);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox4.Location = new System.Drawing.Point(656, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(181, 180);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Company Logo";
            // 
            // pbCompanyLogo
            // 
            this.pbCompanyLogo.Image = global::DisburstmentJournal.Properties.Resources.CompanyLogo;
            this.pbCompanyLogo.Location = new System.Drawing.Point(15, 16);
            this.pbCompanyLogo.Name = "pbCompanyLogo";
            this.pbCompanyLogo.Size = new System.Drawing.Size(151, 124);
            this.pbCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCompanyLogo.TabIndex = 17;
            this.pbCompanyLogo.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(91, 146);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 20;
            this.btnRemove.Text = "&Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnBrowseLogo
            // 
            this.btnBrowseLogo.Location = new System.Drawing.Point(15, 146);
            this.btnBrowseLogo.Name = "btnBrowseLogo";
            this.btnBrowseLogo.Size = new System.Drawing.Size(75, 23);
            this.btnBrowseLogo.TabIndex = 18;
            this.btnBrowseLogo.Text = "&Browse";
            this.btnBrowseLogo.UseVisualStyleBackColor = true;
            this.btnBrowseLogo.Click += new System.EventHandler(this.btnBrowseLogo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnEdit.Image = global::DisburstmentJournal.Properties.Resources.Edit;
            this.btnEdit.Location = new System.Drawing.Point(596, 253);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(77, 101);
            this.btnEdit.TabIndex = 24;
            this.btnEdit.Text = "&Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnNew
            // 
            this.btnNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnNew.Image = global::DisburstmentJournal.Properties.Resources.New;
            this.btnNew.Location = new System.Drawing.Point(515, 253);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(77, 101);
            this.btnNew.TabIndex = 23;
            this.btnNew.Text = "&New";
            this.btnNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear2.Image = global::DisburstmentJournal.Properties.Resources.Clear;
            this.btnClear2.Location = new System.Drawing.Point(765, 253);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(86, 101);
            this.btnClear2.TabIndex = 26;
            this.btnClear2.Text = "&Clear";
            this.btnClear2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnClear2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.AutoSize = true;
            this.btnSave.Image = global::DisburstmentJournal.Properties.Resources.Save;
            this.btnSave.Location = new System.Drawing.Point(678, 253);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 103);
            this.btnSave.TabIndex = 25;
            this.btnSave.Text = "&Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbIsEnabled
            // 
            this.cbIsEnabled.AutoSize = true;
            this.cbIsEnabled.Checked = true;
            this.cbIsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsEnabled.Location = new System.Drawing.Point(333, 147);
            this.cbIsEnabled.Name = "cbIsEnabled";
            this.cbIsEnabled.Size = new System.Drawing.Size(72, 17);
            this.cbIsEnabled.TabIndex = 16;
            this.cbIsEnabled.Text = "is &Active?";
            this.cbIsEnabled.UseVisualStyleBackColor = true;
            // 
            // tbPOCNumber
            // 
            this.tbPOCNumber.Location = new System.Drawing.Point(462, 84);
            this.tbPOCNumber.Name = "tbPOCNumber";
            this.tbPOCNumber.Size = new System.Drawing.Size(182, 20);
            this.tbPOCNumber.TabIndex = 14;
            // 
            // tbPOC
            // 
            this.tbPOC.Location = new System.Drawing.Point(462, 114);
            this.tbPOC.Name = "tbPOC";
            this.tbPOC.Size = new System.Drawing.Size(175, 20);
            this.tbPOC.TabIndex = 15;
            // 
            // tbRemarks
            // 
            this.tbRemarks.Location = new System.Drawing.Point(102, 165);
            this.tbRemarks.Multiline = true;
            this.tbRemarks.Name = "tbRemarks";
            this.tbRemarks.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbRemarks.Size = new System.Drawing.Size(225, 72);
            this.tbRemarks.TabIndex = 13;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(102, 86);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tbAddress.Size = new System.Drawing.Size(225, 67);
            this.tbAddress.TabIndex = 12;
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(102, 55);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(501, 20);
            this.tbClientName.TabIndex = 11;
            // 
            // tbTIN
            // 
            this.tbTIN.Location = new System.Drawing.Point(386, 23);
            this.tbTIN.Name = "tbTIN";
            this.tbTIN.Size = new System.Drawing.Size(217, 20);
            this.tbTIN.TabIndex = 10;
            // 
            // tbClientCode
            // 
            this.tbClientCode.Location = new System.Drawing.Point(134, 23);
            this.tbClientCode.Name = "tbClientCode";
            this.tbClientCode.Size = new System.Drawing.Size(172, 20);
            this.tbClientCode.TabIndex = 9;
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(32, 24);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(64, 20);
            this.tbID.TabIndex = 8;
            this.tbID.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 171);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "&Remarks:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "&Point of Contact Number:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(333, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "P&oint of Contact:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "&Address:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(312, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "&TIN Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "&Company Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "&Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID:";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssTotalRecords,
            this.toolStripStatusLabel2,
            this.tssActiveClient,
            this.filler1,
            this.tssShortCuts});
            this.statusStrip1.Location = new System.Drawing.Point(0, 580);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssTotalRecords
            // 
            this.tssTotalRecords.Name = "tssTotalRecords";
            this.tssTotalRecords.Size = new System.Drawing.Size(100, 17);
            this.tssTotalRecords.Text = "Total Record(s) : 0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // tssActiveClient
            // 
            this.tssActiveClient.Name = "tssActiveClient";
            this.tssActiveClient.Size = new System.Drawing.Size(52, 17);
            this.tssActiveClient.Text = "Active: 0";
            // 
            // filler1
            // 
            this.filler1.Name = "filler1";
            this.filler1.Size = new System.Drawing.Size(13, 17);
            this.filler1.Text = "  ";
            // 
            // tssShortCuts
            // 
            this.tssShortCuts.Name = "tssShortCuts";
            this.tssShortCuts.Size = new System.Drawing.Size(690, 17);
            this.tssShortCuts.Spring = true;
            this.tssShortCuts.Text = "Shortcut:";
            this.tssShortCuts.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shorcutsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // shorcutsToolStripMenuItem
            // 
            this.shorcutsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.editToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.shorcutsToolStripMenuItem.Name = "shorcutsToolStripMenuItem";
            this.shorcutsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.shorcutsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.shorcutsToolStripMenuItem.Text = "&Shorcuts";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
            this.newToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "&Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // frmClientProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 602);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmClientProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Client Profile Masterfile";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmClientProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgRecords)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCompanyLogo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbCriteria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgRecords;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssTotalRecords;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBrowseLogo;
        private System.Windows.Forms.PictureBox pbCompanyLogo;
        private System.Windows.Forms.TextBox tbPOCNumber;
        private System.Windows.Forms.TextBox tbPOC;
        private System.Windows.Forms.TextBox tbRemarks;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbTIN;
        private System.Windows.Forms.TextBox tbClientCode;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.CheckBox cbIsEnabled;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssActiveClient;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem shorcutsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel filler1;
        private System.Windows.Forms.ToolStripStatusLabel tssShortCuts;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
    }
}