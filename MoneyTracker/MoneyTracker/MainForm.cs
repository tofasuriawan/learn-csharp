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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string description = txtDescription.Text;
            DateTime date = dtpDate.Value;
            bool type = false;

            if (rdbIncome.Checked)
            {
                type = true;
            }

            DataSet1TableAdapters.TransactionTableAdapter MyAdapter = new DataSet1TableAdapters.TransactionTableAdapter();
            MyAdapter.Insert(description, amount, type, date);

            MessageBox.Show("Transaction saved!");

            this.transactionTableAdapter.Fill(this.dataSet1.Transaction);

            txtAmount.Clear();
            txtDescription.Clear();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Transaction' table. You can move, or remove it, as needed.
            this.transactionTableAdapter.Fill(this.dataSet1.Transaction);
        }

        private void btnUpdateTransaction_Click(object sender, EventArgs e)
        {
            transactionTableAdapter.Update(dataSet1);
            dgvTransaction.EndEdit();

            this.transactionTableAdapter.Fill(this.dataSet1.Transaction);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword changepassword = new ChangePassword();
            changepassword.Show();
        }
    }
}
