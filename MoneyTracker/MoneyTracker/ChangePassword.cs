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
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text == Properties.Settings.Default.apppassword)
            {
                if (txtNewPassword.Text != txtRepeatPassword.Text)
                {
                    MessageBox.Show("New and repeat password doesn't match!");
                }
                else
                {
                    Properties.Settings.Default.apppassword = txtNewPassword.Text;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Password changed!");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Old password doesn't match!");
            }
        }
    }
}
