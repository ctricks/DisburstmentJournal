namespace DisburstmentJournal.MasterFile
{
    partial class frmAccountCreator
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
            this.gbAccountCategory = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnACEdit = new System.Windows.Forms.Button();
            this.btnACNew = new System.Windows.Forms.Button();
            this.tbACRemarks = new System.Windows.Forms.TextBox();
            this.tbACDescription = new System.Windows.Forms.TextBox();
            this.tbACAccountName = new System.Windows.Forms.TextBox();
            this.tbACAccountNumber = new System.Windows.Forms.TextBox();
            this.tbAC_ID = new System.Windows.Forms.TextBox();
            this.cbACisEnabled = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbAccountType = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.btnATEdit = new System.Windows.Forms.Button();
            this.btnAccountTypeNew = new System.Windows.Forms.Button();
            this.tbATRemarks = new System.Windows.Forms.TextBox();
            this.tbATDescription = new System.Windows.Forms.TextBox();
            this.tbATAccountName = new System.Windows.Forms.TextBox();
            this.tbATAccountNumber = new System.Windows.Forms.TextBox();
            this.tbATID = new System.Windows.Forms.TextBox();
            this.cbATisEnabled = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbAccountStatement = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.btnASEdit = new System.Windows.Forms.Button();
            this.btnAccountStatementNew = new System.Windows.Forms.Button();
            this.tbASRemarks = new System.Windows.Forms.TextBox();
            this.tbASDescription = new System.Windows.Forms.TextBox();
            this.tbASAccountName = new System.Windows.Forms.TextBox();
            this.tbASAccountNumber = new System.Windows.Forms.TextBox();
            this.tbASID = new System.Windows.Forms.TextBox();
            this.cbASisEnabled = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gbAccountCategory.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbAccountType.SuspendLayout();
            this.gbAccountStatement.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbAccountCategory
            // 
            this.gbAccountCategory.Controls.Add(this.button4);
            this.gbAccountCategory.Controls.Add(this.button3);
            this.gbAccountCategory.Controls.Add(this.btnACEdit);
            this.gbAccountCategory.Controls.Add(this.btnACNew);
            this.gbAccountCategory.Controls.Add(this.tbACRemarks);
            this.gbAccountCategory.Controls.Add(this.tbACDescription);
            this.gbAccountCategory.Controls.Add(this.tbACAccountName);
            this.gbAccountCategory.Controls.Add(this.tbACAccountNumber);
            this.gbAccountCategory.Controls.Add(this.tbAC_ID);
            this.gbAccountCategory.Controls.Add(this.cbACisEnabled);
            this.gbAccountCategory.Controls.Add(this.label5);
            this.gbAccountCategory.Controls.Add(this.label4);
            this.gbAccountCategory.Controls.Add(this.label3);
            this.gbAccountCategory.Controls.Add(this.label2);
            this.gbAccountCategory.Controls.Add(this.label1);
            this.gbAccountCategory.Location = new System.Drawing.Point(10, 9);
            this.gbAccountCategory.Name = "gbAccountCategory";
            this.gbAccountCategory.Size = new System.Drawing.Size(332, 259);
            this.gbAccountCategory.TabIndex = 0;
            this.gbAccountCategory.TabStop = false;
            this.gbAccountCategory.Text = "Account Category";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(187, 209);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Save";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnACEdit
            // 
            this.btnACEdit.Location = new System.Drawing.Point(130, 209);
            this.btnACEdit.Name = "btnACEdit";
            this.btnACEdit.Size = new System.Drawing.Size(51, 23);
            this.btnACEdit.TabIndex = 12;
            this.btnACEdit.Text = "Edit";
            this.btnACEdit.UseVisualStyleBackColor = true;
            this.btnACEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnACNew
            // 
            this.btnACNew.Location = new System.Drawing.Point(73, 209);
            this.btnACNew.Name = "btnACNew";
            this.btnACNew.Size = new System.Drawing.Size(51, 23);
            this.btnACNew.TabIndex = 11;
            this.btnACNew.Text = "New";
            this.btnACNew.UseVisualStyleBackColor = true;
            this.btnACNew.Click += new System.EventHandler(this.btnAccountCategoryNew);
            // 
            // tbACRemarks
            // 
            this.tbACRemarks.Location = new System.Drawing.Point(73, 152);
            this.tbACRemarks.Multiline = true;
            this.tbACRemarks.Name = "tbACRemarks";
            this.tbACRemarks.Size = new System.Drawing.Size(227, 51);
            this.tbACRemarks.TabIndex = 10;
            // 
            // tbACDescription
            // 
            this.tbACDescription.Location = new System.Drawing.Point(73, 95);
            this.tbACDescription.Multiline = true;
            this.tbACDescription.Name = "tbACDescription";
            this.tbACDescription.Size = new System.Drawing.Size(227, 51);
            this.tbACDescription.TabIndex = 9;
            // 
            // tbACAccountName
            // 
            this.tbACAccountName.Location = new System.Drawing.Point(73, 69);
            this.tbACAccountName.Name = "tbACAccountName";
            this.tbACAccountName.Size = new System.Drawing.Size(227, 20);
            this.tbACAccountName.TabIndex = 8;
            // 
            // tbACAccountNumber
            // 
            this.tbACAccountNumber.Location = new System.Drawing.Point(73, 43);
            this.tbACAccountNumber.Name = "tbACAccountNumber";
            this.tbACAccountNumber.Size = new System.Drawing.Size(102, 20);
            this.tbACAccountNumber.TabIndex = 7;
            // 
            // tbAC_ID
            // 
            this.tbAC_ID.Location = new System.Drawing.Point(73, 17);
            this.tbAC_ID.Name = "tbAC_ID";
            this.tbAC_ID.ReadOnly = true;
            this.tbAC_ID.Size = new System.Drawing.Size(42, 20);
            this.tbAC_ID.TabIndex = 6;
            // 
            // cbACisEnabled
            // 
            this.cbACisEnabled.AutoSize = true;
            this.cbACisEnabled.Checked = true;
            this.cbACisEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbACisEnabled.Location = new System.Drawing.Point(246, 16);
            this.cbACisEnabled.Name = "cbACisEnabled";
            this.cbACisEnabled.Size = new System.Drawing.Size(72, 17);
            this.cbACisEnabled.TabIndex = 5;
            this.cbACisEnabled.Text = "isEnabled";
            this.cbACisEnabled.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Remark(s):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(10, 274);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1049, 286);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Account";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 267);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbAccountType
            // 
            this.gbAccountType.Controls.Add(this.button5);
            this.gbAccountType.Controls.Add(this.button6);
            this.gbAccountType.Controls.Add(this.btnATEdit);
            this.gbAccountType.Controls.Add(this.btnAccountTypeNew);
            this.gbAccountType.Controls.Add(this.tbATRemarks);
            this.gbAccountType.Controls.Add(this.tbATDescription);
            this.gbAccountType.Controls.Add(this.tbATAccountName);
            this.gbAccountType.Controls.Add(this.tbATAccountNumber);
            this.gbAccountType.Controls.Add(this.tbATID);
            this.gbAccountType.Controls.Add(this.cbATisEnabled);
            this.gbAccountType.Controls.Add(this.label6);
            this.gbAccountType.Controls.Add(this.label7);
            this.gbAccountType.Controls.Add(this.label8);
            this.gbAccountType.Controls.Add(this.label9);
            this.gbAccountType.Controls.Add(this.label10);
            this.gbAccountType.Location = new System.Drawing.Point(348, 12);
            this.gbAccountType.Name = "gbAccountType";
            this.gbAccountType.Size = new System.Drawing.Size(332, 256);
            this.gbAccountType.TabIndex = 3;
            this.gbAccountType.TabStop = false;
            this.gbAccountType.Text = "Account Type";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(244, 209);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "Refresh";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(187, 209);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(51, 23);
            this.button6.TabIndex = 17;
            this.button6.Text = "Save";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // btnATEdit
            // 
            this.btnATEdit.Location = new System.Drawing.Point(130, 209);
            this.btnATEdit.Name = "btnATEdit";
            this.btnATEdit.Size = new System.Drawing.Size(51, 23);
            this.btnATEdit.TabIndex = 16;
            this.btnATEdit.Text = "Edit";
            this.btnATEdit.UseVisualStyleBackColor = true;
            this.btnATEdit.Click += new System.EventHandler(this.btnATEdit_Click);
            // 
            // btnAccountTypeNew
            // 
            this.btnAccountTypeNew.Location = new System.Drawing.Point(73, 209);
            this.btnAccountTypeNew.Name = "btnAccountTypeNew";
            this.btnAccountTypeNew.Size = new System.Drawing.Size(51, 23);
            this.btnAccountTypeNew.TabIndex = 15;
            this.btnAccountTypeNew.Text = "New";
            this.btnAccountTypeNew.UseVisualStyleBackColor = true;
            this.btnAccountTypeNew.Click += new System.EventHandler(this.btnAccountTypeNew_Click);
            // 
            // tbATRemarks
            // 
            this.tbATRemarks.Location = new System.Drawing.Point(73, 152);
            this.tbATRemarks.Multiline = true;
            this.tbATRemarks.Name = "tbATRemarks";
            this.tbATRemarks.Size = new System.Drawing.Size(227, 51);
            this.tbATRemarks.TabIndex = 10;
            // 
            // tbATDescription
            // 
            this.tbATDescription.Location = new System.Drawing.Point(73, 95);
            this.tbATDescription.Multiline = true;
            this.tbATDescription.Name = "tbATDescription";
            this.tbATDescription.Size = new System.Drawing.Size(227, 51);
            this.tbATDescription.TabIndex = 9;
            // 
            // tbATAccountName
            // 
            this.tbATAccountName.Location = new System.Drawing.Point(73, 69);
            this.tbATAccountName.Name = "tbATAccountName";
            this.tbATAccountName.Size = new System.Drawing.Size(227, 20);
            this.tbATAccountName.TabIndex = 8;
            // 
            // tbATAccountNumber
            // 
            this.tbATAccountNumber.Location = new System.Drawing.Point(73, 43);
            this.tbATAccountNumber.Name = "tbATAccountNumber";
            this.tbATAccountNumber.Size = new System.Drawing.Size(102, 20);
            this.tbATAccountNumber.TabIndex = 7;
            // 
            // tbATID
            // 
            this.tbATID.Location = new System.Drawing.Point(73, 17);
            this.tbATID.Name = "tbATID";
            this.tbATID.ReadOnly = true;
            this.tbATID.Size = new System.Drawing.Size(42, 20);
            this.tbATID.TabIndex = 6;
            // 
            // cbATisEnabled
            // 
            this.cbATisEnabled.AutoSize = true;
            this.cbATisEnabled.Checked = true;
            this.cbATisEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbATisEnabled.Location = new System.Drawing.Point(246, 16);
            this.cbATisEnabled.Name = "cbATisEnabled";
            this.cbATisEnabled.Size = new System.Drawing.Size(72, 17);
            this.cbATisEnabled.TabIndex = 5;
            this.cbATisEnabled.Text = "isEnabled";
            this.cbATisEnabled.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Remark(s):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Description:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID:";
            // 
            // gbAccountStatement
            // 
            this.gbAccountStatement.Controls.Add(this.button9);
            this.gbAccountStatement.Controls.Add(this.button10);
            this.gbAccountStatement.Controls.Add(this.btnASEdit);
            this.gbAccountStatement.Controls.Add(this.btnAccountStatementNew);
            this.gbAccountStatement.Controls.Add(this.tbASRemarks);
            this.gbAccountStatement.Controls.Add(this.tbASDescription);
            this.gbAccountStatement.Controls.Add(this.tbASAccountName);
            this.gbAccountStatement.Controls.Add(this.tbASAccountNumber);
            this.gbAccountStatement.Controls.Add(this.tbASID);
            this.gbAccountStatement.Controls.Add(this.cbASisEnabled);
            this.gbAccountStatement.Controls.Add(this.label11);
            this.gbAccountStatement.Controls.Add(this.label12);
            this.gbAccountStatement.Controls.Add(this.label13);
            this.gbAccountStatement.Controls.Add(this.label14);
            this.gbAccountStatement.Controls.Add(this.label15);
            this.gbAccountStatement.Location = new System.Drawing.Point(686, 12);
            this.gbAccountStatement.Name = "gbAccountStatement";
            this.gbAccountStatement.Size = new System.Drawing.Size(332, 256);
            this.gbAccountStatement.TabIndex = 4;
            this.gbAccountStatement.TabStop = false;
            this.gbAccountStatement.Text = "Account Statement";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(244, 209);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(56, 23);
            this.button9.TabIndex = 18;
            this.button9.Text = "Refresh";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(187, 209);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 23);
            this.button10.TabIndex = 17;
            this.button10.Text = "Save";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // btnASEdit
            // 
            this.btnASEdit.Location = new System.Drawing.Point(130, 209);
            this.btnASEdit.Name = "btnASEdit";
            this.btnASEdit.Size = new System.Drawing.Size(51, 23);
            this.btnASEdit.TabIndex = 16;
            this.btnASEdit.Text = "Edit";
            this.btnASEdit.UseVisualStyleBackColor = true;
            this.btnASEdit.Click += new System.EventHandler(this.btnASEdit_Click);
            // 
            // btnAccountStatementNew
            // 
            this.btnAccountStatementNew.Location = new System.Drawing.Point(73, 209);
            this.btnAccountStatementNew.Name = "btnAccountStatementNew";
            this.btnAccountStatementNew.Size = new System.Drawing.Size(51, 23);
            this.btnAccountStatementNew.TabIndex = 15;
            this.btnAccountStatementNew.Text = "New";
            this.btnAccountStatementNew.UseVisualStyleBackColor = true;
            this.btnAccountStatementNew.Click += new System.EventHandler(this.btnAccountStatementNew_Click);
            // 
            // tbASRemarks
            // 
            this.tbASRemarks.Location = new System.Drawing.Point(73, 152);
            this.tbASRemarks.Multiline = true;
            this.tbASRemarks.Name = "tbASRemarks";
            this.tbASRemarks.Size = new System.Drawing.Size(227, 51);
            this.tbASRemarks.TabIndex = 10;
            this.tbASRemarks.TextChanged += new System.EventHandler(this.textBox11_TextChanged);
            // 
            // tbASDescription
            // 
            this.tbASDescription.Location = new System.Drawing.Point(73, 95);
            this.tbASDescription.Multiline = true;
            this.tbASDescription.Name = "tbASDescription";
            this.tbASDescription.Size = new System.Drawing.Size(227, 51);
            this.tbASDescription.TabIndex = 9;
            // 
            // tbASAccountName
            // 
            this.tbASAccountName.Location = new System.Drawing.Point(73, 69);
            this.tbASAccountName.Name = "tbASAccountName";
            this.tbASAccountName.Size = new System.Drawing.Size(227, 20);
            this.tbASAccountName.TabIndex = 8;
            // 
            // tbASAccountNumber
            // 
            this.tbASAccountNumber.Location = new System.Drawing.Point(73, 43);
            this.tbASAccountNumber.Name = "tbASAccountNumber";
            this.tbASAccountNumber.ReadOnly = true;
            this.tbASAccountNumber.Size = new System.Drawing.Size(102, 20);
            this.tbASAccountNumber.TabIndex = 7;
            // 
            // tbASID
            // 
            this.tbASID.Location = new System.Drawing.Point(73, 17);
            this.tbASID.Name = "tbASID";
            this.tbASID.ReadOnly = true;
            this.tbASID.Size = new System.Drawing.Size(42, 20);
            this.tbASID.TabIndex = 6;
            // 
            // cbASisEnabled
            // 
            this.cbASisEnabled.AutoSize = true;
            this.cbASisEnabled.Checked = true;
            this.cbASisEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbASisEnabled.Location = new System.Drawing.Point(246, 16);
            this.cbASisEnabled.Name = "cbASisEnabled";
            this.cbASisEnabled.Size = new System.Drawing.Size(72, 17);
            this.cbASisEnabled.TabIndex = 5;
            this.cbASisEnabled.Text = "isEnabled";
            this.cbASisEnabled.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Remark(s):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 98);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Description:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Number:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "ID:";
            // 
            // frmAccountCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 572);
            this.Controls.Add(this.gbAccountStatement);
            this.Controls.Add(this.gbAccountType);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.gbAccountCategory);
            this.Name = "frmAccountCreator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Accounts Creator";
            this.Load += new System.EventHandler(this.frmAccountCreator_Load);
            this.gbAccountCategory.ResumeLayout(false);
            this.gbAccountCategory.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbAccountType.ResumeLayout(false);
            this.gbAccountType.PerformLayout();
            this.gbAccountStatement.ResumeLayout(false);
            this.gbAccountStatement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAccountCategory;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnACEdit;
        private System.Windows.Forms.Button btnACNew;
        private System.Windows.Forms.TextBox tbACRemarks;
        private System.Windows.Forms.TextBox tbACDescription;
        private System.Windows.Forms.TextBox tbACAccountName;
        private System.Windows.Forms.TextBox tbACAccountNumber;
        private System.Windows.Forms.TextBox tbAC_ID;
        private System.Windows.Forms.CheckBox cbACisEnabled;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbAccountType;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button btnATEdit;
        private System.Windows.Forms.Button btnAccountTypeNew;
        private System.Windows.Forms.TextBox tbATRemarks;
        private System.Windows.Forms.TextBox tbATDescription;
        private System.Windows.Forms.TextBox tbATAccountName;
        private System.Windows.Forms.TextBox tbATAccountNumber;
        private System.Windows.Forms.TextBox tbATID;
        private System.Windows.Forms.CheckBox cbATisEnabled;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbAccountStatement;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button btnASEdit;
        private System.Windows.Forms.Button btnAccountStatementNew;
        private System.Windows.Forms.TextBox tbASRemarks;
        private System.Windows.Forms.TextBox tbASDescription;
        private System.Windows.Forms.TextBox tbASAccountName;
        private System.Windows.Forms.TextBox tbASAccountNumber;
        private System.Windows.Forms.TextBox tbASID;
        private System.Windows.Forms.CheckBox cbASisEnabled;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}