using DisburstmentJournal.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisburstmentJournal
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Utils.CloseApplication() == DialogResult.Yes)
                Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!clsValidations.isUserLoginValid(tbUsername.Text,tbPassword.Text))
            {
                MessageBox.Show("Error: Username or Password is invalid. Please check your credentials", "User Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string ErrMsg = string.Empty;

            if(!clsDatabase.CheckUserLogin(tbUsername.Text, tbPassword.Text, out ErrMsg))
            {
                MessageBox.Show(ErrMsg, "User Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MainScreen MS = new MainScreen();
            this.Hide();
            MS.ShowDialog();
        }
    }
}
