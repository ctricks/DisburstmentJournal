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
        private void InitializeForm()
        {
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

                if(!string.IsNullOrEmpty(ErrMsg))
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
    }
}
