using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Davis_Week10
{
    public partial class Form1 : Form
    {
        private SavingsAccount savings;
        private CheckingAccount checking;
        public Form1()
        {
            InitializeComponent();
            savings = new SavingsAccount(100.0m, 0.4m);
            checking = new CheckingAccount(200.0m, 0.5m);
            balanceAmount.Text = checking.Balance.ToString("C");
            accountBox.DataSource = new List<string>()
            {
                "Checking",
                "Savings"
            };
            accountBox.SelectedIndex = 0;
        }

        private void creditButton_Click(object sender, EventArgs e)
        {
            decimal amount = decimal.Parse(transactionBox.Text);
            if (accountBox.SelectedIndex.Equals(0))
            {
                checking.Credit(amount);
                balanceAmount.Text = checking.Balance.ToString("C");
            }
            else if (accountBox.SelectedIndex.Equals(1))
            {
                savings.Credit(amount);
                balanceAmount.Text = savings.Balance.ToString("C");
            }
            transactionBox.Text = "";
        }

        private void debitButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal amount = decimal.Parse(transactionBox.Text);
                if (accountBox.SelectedIndex.Equals(0))
                {
                    bool success = checking.Debit(amount);
                    if (success)
                    {
                        balanceAmount.Text = checking.Balance.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Unable to debit account for entered amount", "Unable to debit Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    balanceAmount.Text = checking.Balance.ToString("C");
                }
                else if (accountBox.SelectedIndex.Equals(1))
                {
                    bool success = savings.Debit(amount);
                    if (success)
                    {
                        balanceAmount.Text = savings.Balance.ToString("C");
                    }
                    else
                    {
                        MessageBox.Show("Unable to debit account for entered amount", "Unable to debit Account", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    balanceAmount.Text = savings.Balance.ToString("C");
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            transactionBox.Text = "";
        }

        private void intRateBtn_Click(object sender, EventArgs e)
        {
            savings.Credit(savings.CalculateInterest());
            MessageBox.Show(savings.CalculateInterest().ToString("C"), "Account Interest Rate", MessageBoxButtons.OK, MessageBoxIcon.Information);
            balanceAmount.Text = savings.Balance.ToString("C");
        }

        private void accountBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(accountBox.SelectedIndex.Equals(0))
            {
                balanceAmount.Text = checking.Balance.ToString("C");
                intRateBtn.Hide();
            } 
            else if (accountBox.SelectedIndex.Equals(1))
            {
                balanceAmount.Text = savings.Balance.ToString("C");
                intRateBtn.Show();
            }
        }
    }
}
