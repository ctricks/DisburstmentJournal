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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            //Load Role from Database
            cbRole.DataSource = clsDatabase.dtGetUserRole("where isEnabled = 1 Order by RoleName");
            cbRole.Refresh();


        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmUserRoles uroles = new frmUserRoles();
            uroles.ShowDialog();
        }
    }
}
