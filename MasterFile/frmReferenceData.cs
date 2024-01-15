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
    public partial class frmReferenceData : Form
    {
        public frmReferenceData()
        {
            InitializeComponent();
        }

        //Button Functions
        private void NewForm()
        {
            DialogResult dr = MessageBox.Show("This will create a new record. Would you like to continue?", "New form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clsUI.ComponentStatus(groupBox3, true, true);

                string ErrMsg = string.Empty;

                DataTable dtAllRecords = clsDatabase.GetReferenceDataRecords(out ErrMsg, "");

                if (dtAllRecords.Rows.Count > 0)
                    tbID.Text = (int.Parse(dtAllRecords.Rows[dtAllRecords.Rows.Count - 1]["ID"].ToString()) + 1).ToString();
                else
                    tbID.Text = "1";

                tbModuleName.Focus();

                cbIsEnabled.Enabled = true;
                cbIsEnabled.Checked = true;
            }
        }
        private void EditForm()
        {
            DialogResult dr = MessageBox.Show("This will edit your information. Would you like to continue?", "Edit entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                //Validation for Edit
                if (tbID.Text == "0")
                {
                    MessageBox.Show("Error: Cannot edit the record. Please select first on the list.", "Edit Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                clsUI.ComponentStatus(groupBox3, false, false);
                tbModuleName.Focus();
                cbIsEnabled.Enabled = true;

                clsUI.ComponentStatus(groupBox3, true, false);

            }
        }
        private void SaveForm()
        {
            //Check tbID if not 0;
            if (tbID.Text == "0")
            {
                MessageBox.Show("Error: Cannot save information. Please check your entry first.", "Invalid Record ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Would you like to save this information?", "Save entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string, string> ReferenceData = new Dictionary<string, string>();

                foreach (Control ctrl in this.groupBox3.Controls)
                {

                    if (ctrl is TextBox)
                    {
                        if (ctrl.Name != "tbCriteria")
                            ReferenceData.Add(ctrl.Name, ctrl.Text);
                    }
                }

                List<string> IntValue = new List<string>()
                {
                    "tbID","tbCreditLimit","tbTerms"
                };

                string ErrMsg = string.Empty;

                bool isInsert = clsDatabase.GetReferenceDataRecords(out ErrMsg, "where ID=" + tbID.Text.Trim() + "").Rows.Count == 0 ? true : false;

                if (clsDatabase.InsertUpdateCompany(ReferenceData, IntValue, cbIsEnabled.Checked, isInsert))
                {
                    MessageBox.Show("Record successfully saved.", tbModuleName.Text + " saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsUI.ComponentStatus(groupBox3, true, true);

                    string ErrorMessage = string.Empty;
                    DataTable dtResult = clsDatabase.GetReferenceDataRecords(out ErrorMessage, "");

                    dgRecords.DataSource = dtResult;
                    dgRecords.Refresh();

                    clsUI.ComponentStatus(groupBox3, false, true);
                    cbIsEnabled.Checked = false;
                }
                else
                {
                    clsUI.ComponentStatus(groupBox3, false, true);
                }

                cbIsEnabled.Enabled = false;
                cbIsEnabled.Checked = false;
            }
        }
        private void ClearForm()
        {
            DialogResult dr = MessageBox.Show("This will clear all your input. Would you like to continue?", "Clear entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clsUI.ComponentStatus(groupBox3, false, true);
                tbModuleName.Focus();
            }
        }

        //End Here

        private void Initialization()
        {
            string ErrMsg = string.Empty;

            DataTable dtAllRecords = clsDatabase.GetReferenceDataRecords(out ErrMsg, "");


            tssTotalRecords.Text = "Total Record(s) : " + dtAllRecords.Rows.Count;

            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Active Reference Data Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tssTotalActive.Text = "Total Active : " + dtAllRecords.Select("isEnabled = true").Count();

            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Total Referece Data Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load all records in the list
            dgRecords.DataSource = dtAllRecords;
            dgRecords.Refresh();

            clsUI.ComponentStatus(groupBox3, false, true);

            cbIsEnabled.Checked = false;
            cbIsEnabled.Enabled = false;
        }

        private void frmReferenceData_Load(object sender, EventArgs e)
        {
            Initialization();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            NewForm();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || tbID.Text.Trim() == "0")
            {
                MessageBox.Show("Warning: Cannot edit empty information. Kindly create a new entry", "Edit Client information Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditForm();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || tbID.Text.Trim() == "0")
            {
                MessageBox.Show("Warning: Cannot save empty information. Kindly create a new entry", "Saving Client information Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveForm();
        }
    }
}
