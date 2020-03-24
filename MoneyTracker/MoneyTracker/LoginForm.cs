using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == Properties.Settings.Default.apppassword)
            {
                MainForm mainform = new MainForm();
                mainform.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Access Denied!");
            }
        }
    }
}
