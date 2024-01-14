using DisburstmentJournal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal.MasterFile
{
    public partial class frmAccountCreator : Form
    {
        public frmAccountCreator()
        {
            InitializeComponent();
        }

        //Private Functions
        private void RefreshRecord(GroupBox gpAccount)
        {
            foreach(Control ctrl in gpAccount.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tbAccount = (TextBox)ctrl;
                    tbAccount.Text = String.Empty;
                    tbAccount.Enabled = false;
                    tbAccount.ReadOnly = true;
                }
            }
            DataTable dtRecord = clsDatabase.GetAccountRecords(gpAccount.Name.Replace("gb", ""));
            dgAccounts.DataSource = dtRecord;
            dgAccounts.Refresh();
        }
        private void NewEditRecord(GroupBox gpAccount,bool isEnabled = false,bool isEdit = false)
        {   

            foreach (Control ctrl in gpAccount.Controls)
            {
                if (ctrl is CheckBox)
                {
                    if (ctrl.Name.Contains("isEnabled"))
                    {
                        CheckBox cbEnabled = (CheckBox)ctrl;
                        cbEnabled.Checked = !isEnabled;
                    }
                }

                if(ctrl is TextBox)
                {
                    TextBox tbAccountName = (TextBox)ctrl;
                    if (!isEdit)
                    {
                        ctrl.Text = String.Empty;
                        
                        tbAccountName.ReadOnly = !isEnabled;

                        if (ctrl.Name.Contains("ID"))
                        {   tbAccountName.ReadOnly = true;
                            ctrl.Enabled = isEnabled;
                            DataTable dtRecord = clsDatabase.GetAccountRecords(gpAccount.Name.Replace("gb",""));
                            if (dtRecord.Rows.Count > 0)
                            {
                                tbAccountName.Text = (int.Parse(dtRecord.Rows[0]["ID"].ToString()) + 1).ToString();
                            }else
                            {
                                if(isEnabled)
                                    tbAccountName.Text = "1";
                            }
                        }
                    }
                    else
                    {
                        if (ctrl.Name.Contains("ID") && ctrl.Text == String.Empty)
                        {
                            MessageBox.Show("Error: Cannot Edit no ID Selected. Please select first on the record before editting", "Edit Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }


                        if (!ctrl.Name.Contains("ID"))
                        {
                            ctrl.Enabled = isEdit;
                            tbAccountName.ReadOnly = isEnabled;
                            tbAccountName.ReadOnly = isEdit;
                            
                        }
                    }

                }
            }
        }

        private void SaveRecord(GroupBox gpAccount,string ACRO, bool isCategory = false,
            bool isType = false, bool isMainAccount = false, bool isSubAcount = false, bool isStatement = false)
        {
            Dictionary<string, string> AccountInformation = new Dictionary<string, string>();
            string IDFound = string.Empty;

            foreach(Control ctrl in gpAccount.Controls)
            {
                if(ctrl is TextBox)
                {
                    TextBox tbAccount = (TextBox)ctrl;
                    if(tbAccount.Name.Contains("ID"))
                    {
                        if(string.IsNullOrEmpty(tbAccount.Text))
                        {
                            MessageBox.Show("Error in Saving Account information. Please check your ID first", "Error saving " + gpAccount.Name, MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        IDFound = tbAccount.Text;
                    }
                    AccountInformation.Add(tbAccount.Name.Replace("tb",""), tbAccount.Text);
                }
            }
            bool isInsert = !clsDatabase.isRecordFound("ID", "[MASTER_ACCOUNT_TABLE]", " where ID = " + IDFound);
            
            int Result = clsDatabase.SaveAccountRecords(AccountInformation,ACRO,isInsert,isCategory,isType,isMainAccount,isSubAcount,isStatement);
            RefreshRecord(gpAccount);
        }
        private void NumberValidation(KeyPressEventArgs e, TextBox tbField)
        {
            if (e.KeyChar != '\b' && e.KeyChar.ToString().Trim() != "")
            {
                if (!clsValidations.isInteger(e.KeyChar.ToString()))
                {
                    MessageBox.Show("Error: Please input a number", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                tbField.Text = "";
            }
        }
        private void NumberLeaveValidation(TextBox tbField)
        {
            if (!clsValidations.isInteger(tbField.Text.Trim()))
            {
                MessageBox.Show("Error: Please input a number", "Invalid Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbField.Text = String.Empty;
                tbField.Focus();
                return;
            }
        }

        //Ends Here


        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAccountCategoryNew(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountCategory, true,false);
            NewEditRecord(gbAccountStatement);
            NewEditRecord(gbAccountType);
        }

        private void frmAccountCreator_Load(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountCategory,false);
            NewEditRecord(gbAccountType, false);
            NewEditRecord(gbAccountStatement, false);
        }

        private void btnAccountTypeNew_Click(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountType, true,false);
            NewEditRecord(gbAccountStatement);
            NewEditRecord(gbAccountCategory);
        }

        private void btnAccountStatementNew_Click(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountStatement, true,false);
            NewEditRecord(gbAccountCategory);
            NewEditRecord(gbAccountType);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountCategory, true, true);
        }

        private void btnASEdit_Click(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountStatement, true, true);
        }

        private void btnATEdit_Click(object sender, EventArgs e)
        {
            NewEditRecord(gbAccountType, true, true);
        }

        private void btnACSave_Click(object sender, EventArgs e)
        {
            SaveRecord(gbAccountCategory, "AC", true);
        }

        private void btnACRefresh_Click(object sender, EventArgs e)
        {
            RefreshRecord(gbAccountCategory);
        }

        private void btnASRefresh_Click(object sender, EventArgs e)
        {
            RefreshRecord(gbAccountStatement);
        }

        private void btnATRefresh_Click(object sender, EventArgs e)
        {
            RefreshRecord(gbAccountType);
        }
    }
}
