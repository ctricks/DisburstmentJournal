using DisburstmentJournal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal.MasterFile
{
    public partial class frmUserRoles : Form
    {
        public frmUserRoles()
        {
            InitializeComponent();
        }

        private void Initialized()
        {
            tbRoleID.Text = tbRoleName.Text = String.Empty;
            dgRecords.DataSource = clsDatabase.dtGetUserRole();
            dgRecords.Refresh();
            tbRoleName.ReadOnly = true;
        }

        private void frmUserRoles_Load(object sender, EventArgs e)
        {
            Initialized();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbRoleID.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Error: No Id Found. Please select it first on the list to proceed", "No Id Found", MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            tbRoleName.Enabled = chkEnabled.Enabled =  true;
            tbRoleName.ReadOnly = false;
            tbRoleName.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Initialized();
        }

        private void dgRecords_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbRoleID.Text = dgRecords["Id", e.RowIndex].Value.ToString();
            tbRoleName.Text = dgRecords["Rolename", e.RowIndex].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbRoleName.Enabled = true;
            tbRoleName.ReadOnly = false;
            DataTable dtRecords = clsDatabase.dtGetUserRole();

            if (dtRecords.Rows.Count > 0) {
                tbRoleID.Text = (int.Parse(dtRecords.Rows[0]["ID"].ToString()) + 1).ToString();
                    }
            tbRoleName.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tbRoleID.Text.Trim() == String.Empty)
            {
                MessageBox.Show("Error: No Id Found. Please select it first on the list to proceed", "No Id Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult drRes = MessageBox.Show("Are you sure you want to save this role?", tbRoleName.Text + " role?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(drRes == DialogResult.Yes)
            {
                bool isIDExist = clsDatabase.dtGetUserRole(" where ID = " + tbRoleID.Text).Rows.Count > 0 ? true : false;
                bool isSuccess = false;
                if(isIDExist)
                {
                    isSuccess = clsDatabase.isInsertUpdateUserRole(false, tbRoleName.Text, int.Parse(tbRoleID.Text));
                }else
                {
                    isSuccess = clsDatabase.isInsertUpdateUserRole(true, tbRoleName.Text);
                }

                if (isSuccess) 
                {
                    MessageBox.Show("Rolename successfully saved.","Done",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cannot save Rolename. Please check if first", "Error saving Rolename", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Initialized();
        }
    }
}
