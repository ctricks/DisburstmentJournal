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

        private void NewRecord(GroupBox gpAccount,bool isEnabled = false)
        {
            foreach (Control ctrl in gpAccount.Controls)
            {
                if(ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;
                    if (ctrl.Name.Contains("ID"))
                        ctrl.Enabled = isEnabled;
                }
            }
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
            NewRecord(gbAccountCategory, true);
        }

        private void frmAccountCreator_Load(object sender, EventArgs e)
        {
            NewRecord(gbAccountCategory);
            NewRecord(gbAccountType);
            NewRecord(gbAccountStatement);
        }

        private void btnAccountTypeNew_Click(object sender, EventArgs e)
        {
            NewRecord(gbAccountType, true);
        }

        private void btnAccountStatementNew_Click(object sender, EventArgs e)
        {
            NewRecord(gbAccountStatement, true);
        }
    }
}
