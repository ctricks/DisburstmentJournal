using DisburstmentJournal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace DisburstmentJournal.MasterFile
{
    public partial class frmClientProfile : Form
    {
        //Private function for buttons shortcut
        private void CloseForm()
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to close this form?", "Closing form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
                this.Close();
        }
        private void NewForm()
        {
            DialogResult dr = MessageBox.Show("This will create a new form. Would you like to continue?", "New form?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ComponentStatus(true, true);

                string ErrMsg = string.Empty;

                DataTable dtAllRecords = clsDatabase.GetClientProfileRecords(out ErrMsg, "");

                tbID.Text = (int.Parse(dtAllRecords.Rows[dtAllRecords.Rows.Count-1]["ID"].ToString()) + 1).ToString();

                tbClientCode.Focus();

                cbIsEnabled.Enabled = true;
                cbIsEnabled.Checked = true;
            }
        }
        private void SaveForm()
        {
            //Check tbID if not 0;
            if(tbID.Text == "0")
            {
                MessageBox.Show("Error: Cannot save information. Please check your entry first.", "Invalid Record ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult dr = MessageBox.Show("Would you like to save this information?", "Save entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Dictionary<string,string> ClientInfo = new Dictionary<string,string>();

                foreach(Control ctrl in this.groupBox3.Controls)
                {
                    
                    if(ctrl is TextBox)
                    {
                        if(ctrl.Name != "tbCriteria")
                            ClientInfo.Add(ctrl.Name, ctrl.Text);
                    }
                }

                List<string> IntValue = new List<string>()
                {
                    "tbID"
                };

                ClientInfo.Add("tbCompanyLogo", pbCompanyLogo.Tag.ToString());
                string ErrMsg = string.Empty;

                bool isInsert = clsDatabase.GetClientProfileRecords(out ErrMsg, "where ID=" + tbID.Text.Trim() + "").Rows.Count == 0 ? true : false;
                
                    if (clsDatabase.InsertUpdateClientProfile(ClientInfo, IntValue, cbIsEnabled.Checked,isInsert))
                    {
                        MessageBox.Show("Record successfully saved.", tbClientCode.Text + " saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ComponentStatus(true, true);

                        string ErrorMessage = string.Empty;
                        DataTable dtResult = clsDatabase.GetClientProfileRecords(out ErrorMessage, "");

                        dgRecords.DataSource = dtResult;
                        dgRecords.Refresh();

                        ComponentStatus(false, true);

                    }
                    else
                    {
                        ComponentStatus(false, true);
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
                if(tbID.Text == "0")
                {
                    MessageBox.Show("Error: Cannot edit the record. Please select first on the list.", "Edit Record Failed", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return;
                }

                ComponentStatus(false, false);
                tbClientCode.Focus();
                cbIsEnabled.Enabled = true;

                ComponentStatus(true, false);

            }
        }
        private void ClearForm()
        {
            DialogResult dr = MessageBox.Show("This will clear all your input. Would you like to continue?", "Clear entry?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                ComponentStatus(false, true);
                tbClientCode.Focus();
            }
        }

        //Ends here

        //Local Functions
        private void ComponentStatus(bool isEnabled=true,bool isClear = false)
        {
            foreach(Control ctrl in this.groupBox3.Controls)
            {
                if(ctrl is TextBox)
                {
                    ctrl.Enabled = isEnabled;
                    
                    if (ctrl.Name == "tbID")
                        ctrl.Enabled = false;

                    if (isClear)
                        ctrl.Text = String.Empty;
                }
            }

        }

        private void LoadSelectedRecord(int RowIndex, int ColumnIndex,DataGridView dgr)
        {
            try
            {
                foreach (Control ctrl in this.groupBox3.Controls)
                {
                    if (ctrl is TextBox)
                    {
                        if (ctrl.Name == "tbPOC")
                        {
                            ctrl.Text = dgr[ctrl.Name.Replace("tb", "").Replace("POC","PointOfContact"), RowIndex].Value.ToString();
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

        //End Here

        

        private void Initialized()
        {
            //shortcut command
            tssShortCuts.Text = "Shortcut: F9-New , F3-Save, F12-Close";
            string ErrMsg = string.Empty;

            DataTable dtAllRecords = clsDatabase.GetClientProfileRecords(out ErrMsg, "");

            
            tssTotalRecords.Text = "Active: " + dtAllRecords.Rows.Count;
            
            if(!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Active Client Profile Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            tssActiveClient.Text = "Total Record(s) : " + dtAllRecords.Select("isEnabled = true").Count();
            
            if (!string.IsNullOrEmpty(ErrMsg))
            {
                MessageBox.Show("Error: " + ErrMsg, "Error Reading Data - Total Client Profile Records", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Load all records in the list
            dgRecords.DataSource = dtAllRecords;
            dgRecords.Refresh();

            pbCompanyLogo.Tag = Environment.CurrentDirectory + "\\Resources\\CompanyLogo.jpg";
            pbCompanyLogo.Image = Image.FromFile(pbCompanyLogo.Tag.ToString());

            ComponentStatus(false, true);
            cbIsEnabled.Checked = false;
            cbIsEnabled.Enabled = false;
        }

        public frmClientProfile()
        {
            InitializeComponent();
        }

        private void frmClientProfile_Load(object sender, EventArgs e)
        {
            Initialized();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            CloseForm();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewForm();
        }

        private void btnNew_Click(object sender, EventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbID.Text) || tbID.Text.Trim() == "0")
            {
                MessageBox.Show("Warning: Cannot edit empty information. Kindly create a new entry", "Edit Client information Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EditForm();
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            ComponentStatus(false, true);
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

            dtResult = clsDatabase.GetClientProfileRecords(out ErrorMessage, Criteria);

            if (dtResult.Rows.Count == 0)
                MessageBox.Show("No Record Found. Please refine your search again.", "Client Missing", MessageBoxButtons.OK, MessageBoxIcon.Error);

            dgRecords.DataSource = dtResult;
            dgRecords.Refresh();


            ComponentStatus(false,true);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cbFilterBy.Text = String.Empty;
            tbCriteria.Text = String.Empty;

            Initialized();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tbID.Text) || tbID.Text.Trim() == "0")
            {
                MessageBox.Show("Warning: Cannot save empty information. Kindly create a new entry", "Saving Client information Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveForm();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Warning: This will change your company logo. Proceed?", "Change Company Logo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(dr == DialogResult.Yes)
            {
                pbCompanyLogo.Tag = Environment.CurrentDirectory + "\\Resources\\CompanyLogo.jpg";
                pbCompanyLogo.Image = Image.FromFile(pbCompanyLogo.Tag.ToString());
            }
        }

        private void btnBrowseLogo_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;";
            openFileDialog1.Title = "Select logo here";
            openFileDialog1.FilterIndex = 1;
            DialogResult result = openFileDialog1.ShowDialog(); 

            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    pbCompanyLogo.Tag = file;
                    pbCompanyLogo.Image = Image.FromFile(file);
                }
                catch (IOException)
                {
                }
            }
        }

        private void dgRecords_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {   
            ComponentStatus(false, false);
            LoadSelectedRecord(e.RowIndex, e.ColumnIndex, dgRecords);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
