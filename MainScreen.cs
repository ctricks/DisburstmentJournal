using DisburstmentJournal.Helper;
using DisburstmentJournal.MasterFile;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal
{
    public partial class MainScreen : Form
    {
        private int Counter = 0;

        private void LoadBackground()
        {
            try
            {
                this.BackgroundImage = Image.FromFile(Environment.CurrentDirectory + "\\Resources\\MainBG.jpg");
                this.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {
                
            }            
        }

        private void InitializeForm()
        {
            LoadBackground();
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();

            tssDatabaseStatus.Text = "DATABASE STATUS: Connected";
        }
        public MainScreen()
        {
            InitializeComponent();
        }

        private void MainScreen_FormClosing(object sender, FormClosingEventArgs e)
        {            
            if (Utils.CloseApplication() == DialogResult.No)
                e.Cancel = true;            
        }

        private void MainScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            InitializeForm();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tssDateTime.Text = DateTime.Now.ToString("MMMM dd, yyyy HH:mm:ss");
            Counter++;

            if (Counter == 60)
            {
                string ErrMsg = string.Empty;
                tssDatabaseStatus.Text = "DATABASE STATUS: " + (!clsDatabase.CheckDBConnection(Utils.GetConnectionString(), out ErrMsg) ? ErrMsg : "Connected");

                if(!string.IsNullOrEmpty(ErrMsg) && ErrMsg != "Connected")
                {
                    MessageBox.Show("Error: " + ErrMsg, "Database Connection Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    Application.Exit();
                }
                Counter = 0;
            }
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientProfile clientProfile = new frmClientProfile();
            clientProfile.MdiParent = this;
            clientProfile.Show();
        }

        private void accountReceivablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCompany companyProfile = new frmCompany();
            companyProfile.MdiParent = this;
            companyProfile.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsers userProfile = new frmUsers();
            userProfile.MdiParent = this;
            userProfile.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserRoles userRole = new frmUserRoles();
            userRole.MdiParent = this;
            userRole.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountCreator accountCreator = new frmAccountCreator();
            accountCreator.MdiParent = this;
            accountCreator.Show();
        }

        private void referenceDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReferenceData referenceData = new frmReferenceData();
            referenceData.MdiParent = this;
            referenceData.Show();
        }
    }
}
