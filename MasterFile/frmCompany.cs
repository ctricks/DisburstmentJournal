using DisburstmentJournal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal.MasterFile
{
    public partial class frmCompany : Form
    {
        public frmCompany()
        {
            InitializeComponent();
        }

        //Private function for buttons shortcut
        private void CloseForm()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this form?", "Closing form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }
        private void NewForm()
        {
            DialogResult dr = MessageBox.Show("This will create a new record. Would you like to continue?", "New form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clsUI.ComponentStatus(groupBox3, true, true);

                string ErrMsg = string.Empty;

                DataTable dtAllRecords = clsDatabase.GetCompanyRecords(out ErrMsg, "");

                if(dtAllRecords.Rows.Count > 0)
                    tbID.Text = (int.Parse(dtAllRecords.Rows[dtAllRecords.Rows.Count-1]["ID"].ToString()) + 1).ToString();

                tbCompanyCode.Focus();

                cbIsEnabled.Enabled = true;
                cbIsEnabled.Checked = true;
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
                Dictionary<string, string> CompanyInfo = new Dictionary<string, string>();

                foreach (Control ctrl in this.groupBox3.Controls)
                {

                    if (ctrl is TextBox)
                    {
                        if (ctrl.Name != "tbCriteria")
                            CompanyInfo.Add(ctrl.Name, ctrl.Text);
                    }
                }

                List<string> IntValue = new List<string>()
                {
                    "tbID","tbCreditLimit","tbTerms"
                };

                string ErrMsg = string.Empty;

                bool isInsert = clsDatabase.GetCompanyRecords(out ErrMsg, "where ID=" + tbID.Text.Trim() + "").Rows.Count == 0 ? true : false;

                if (clsDatabase.InsertUpdateCompany(CompanyInfo, IntValue, cbIsEnabled.Checked, isInsert))
                {
                    MessageBox.Show("Record successfully saved.", tbCompanyCode.Text + " saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clsUI.ComponentStatus(groupBox3, true, true);

                    string ErrorMessage = string.Empty;
                    DataTable dtResult = clsDatabase.GetCompanyRecords(out ErrorMessage, "");

                    dgRecords.DataSource = dtResult;
                    dgRecords.Refresh();

                    clsUI.ComponentStatus(groupBox3, false, true);
                    cbIsEnabled.Checked = false;
                }
                else
                {
                    clsUI.ComponentStatus(groupBox3,false, true);
                }

                cbIsEnabled.Enabled = false;
                cbIsEnabled.Checked = false;
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
                tbCompanyCode.Focus();
                cbIsEnabled.Enabled = true;

                clsUI.ComponentStatus(groupBox3, true, false);

            }
        }
        private void ClearForm()
        {
            DialogResult dr = MessageBox.Show("This will clear all your input. Would you like to continue?", "Clear entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                clsUI.ComponentStatus(groupBox3,false, true);
                tbCompanyCode.Focus();
            }
        }

        //Ends here

        //Local Functions
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

        private void LoadSelectedRecord(int RowIndex, int ColumnIndex, DataGridView dgr)
        {
            try
            {
                foreach (Control ctrl in this.groupBox3.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (ctrl.Name == "tbPOC")
                        {
                            ctrl.Text = dgr[ctrl.Name.Replace("tb", "").Replace("POC", "PointOfContact"), RowIndex].Value.ToString();
                        }
                        else
                        {
                            ctrl.Text = dgr[ctrl.Name.Replace("tb", ""), RowIndex].Value.ToString();
                        }
                    }
                }
                cbIsEnabled.Checked = (dgr["isEnabled", RowIndex].Value.ToString() == "1") ? true : false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Initialized()
        {
            //shortcut command
            tssShortCuts.Text = "Shortcut: F9-New , F3-Save, F12-Close";
            string ErrMsg = string.Empty;

            DataTable dtAllRecords = clsDatabase.GetCompanyRecords(out ErrMsg, "");


            tssTotalRecords.Text = "Active: " + dtAllRecords.Rows.Count;

            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Active Company Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            tssActiveClient.Text = "Total Record(s) : " + dtAllRecords.Select("isEnabled = true").Count();

            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Total Company Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load all records in the list
            dgRecords.DataSource = dtAllRecords;
            dgRecords.Refresh();

            clsUI.ComponentStatus(groupBox3,false, true);

            cbIsEnabled.Checked = false;
            cbIsEnabled.Enabled = false;
        }

        private void frmCompany_Load(object sender, EventArgs e)
        {
            Initialized();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dtResult = new DataTable();
            string ErrorMessage = string.Empty;
            string Criteria = string.Empty;

            if (!string.IsNullOrEmpty(tbCriteria.Text) && !string.IsNullOrEmpty(cbFilterBy.Text))
            {
                if (tbCriteria.Text.Contains("%") || tbCriteria.Text.Contains("*"))
                {
                    Criteria = " where " + cbFilterBy.Text.Trim().Replace(" ", "") + " LIKE '" + tbCriteria.Text + "'";
                }
                else
                {
                    Criteria = " where " + cbFilterBy.Text.Trim().Replace(" ", "") + " = '" + tbCriteria.Text + "'";
                }
            }

            dtResult = clsDatabase.GetCompanyRecords(out ErrorMessage, Criteria);

            if (dtResult.Rows.Count == 0)
                MessageBox.Show("No Record Found. Please refine your search again.", "Company Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dgRecords.DataSource = dtResult;
            dgRecords.Refresh();


            clsUI.ComponentStatus(groupBox3,false, true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFilterBy.Text = String.Empty;
            tbCriteria.Text = String.Empty;

            Initialized();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            tbID.Text = "0";
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

        private void btnClear2_Click(object sender, EventArgs e)
        {
            clsUI.ComponentStatus(groupBox3, false, true);
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || tbID.Text.Trim() == "0")
            {
                MessageBox.Show("Warning: Cannot save empty information. Kindly create a new entry", "Saving Client information Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveForm();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseForm();
        }

        private void tbTerms_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberValidation(e, tbTerms);
        }

        private void tbTerms_Validating(object sender, CancelEventArgs e)
        {
            NumberLeaveValidation(tbTerms);
        }

        private void tbCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumberValidation(e, tbCreditLimit);
        }

        private void tbCreditLimit_Leave(object sender, EventArgs e)
        {

        }

        private void tbCreditLimit_Validating(object sender, CancelEventArgs e)
        {
            NumberLeaveValidation(tbCreditLimit);
        }

        private void dgRecords_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clsUI.ComponentStatus(groupBox3, false, false);
            LoadSelectedRecord(e.RowIndex, e.ColumnIndex, dgRecords);
        }
    }
}
