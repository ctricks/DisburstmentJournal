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
using static DisburstmentJournal.Helper.clsUI;

namespace DisburstmentJournal
{
    public partial class FrmSplash : Form
    {   
        public FrmSplash()
        {
            InitializeComponent();
        }

        private void FrmSplash_Load(object sender, EventArgs e)
        {
            LoadSplash(this,tmrSplash);
        }

        private void tmrSplash_Tick(object sender, EventArgs e)
        {
            try
            {
                lblCaption.Text = "System Checking...";
                switch (pbProgress.Value)
                {
                    case 10:
                        string DBConnectionString = Utils.GetConnectionString();
                        if (string.IsNullOrEmpty(DBConnectionString))
                        {
                            lblCaption.Text = "Error: Database configuration is invalid. Please check";
                            HaltChecker("Error: Invalid ConnectionString, Please report it on your Administrator.");
                        }
                        else
                        {
                            lblCaption.Text = "Checking Database Connection...";
                            string DBMessage = string.Empty;
                            if(!clsDatabase.CheckDBConnection(DBConnectionString,out DBMessage))
                            {
                                lblCaption.Text = "Error: " + DBMessage;
                                HaltChecker(DBMessage);
                            }else
                            {
                                lblCaption.Text = "Database Status: " + DBMessage;
                            }
                            
                        }
                        break;
                }


                if (pbProgress.Value <= 100)
                    pbProgress.Value += 10;
            }
            catch (Exception)
            {
                //For extra pbProgress Value                
                tmrSplash.Stop();
                tmrSplash.Enabled = false;
            }

            if (pbProgress.Value == 100 && !tmrSplash.Enabled)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }
        }
        private void HaltChecker(string ErrorMessage)
        {
            tmrSplash.Stop();
            tmrSplash.Enabled = false;
            MessageBox.Show(ErrorMessage, "Configuration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Environment.Exit(0);
        }
    }
}
