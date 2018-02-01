using System;
using System.Windows.Forms;

namespace BankRegisterApp
{
    public partial class BankRegisterApp : Form
    {
        string[] acctName;
        int acctNum;
        decimal iniBal;
        decimal balance;
        decimal depositBalance;
        decimal withdrawBalance;
        private Customer cust1;
        
        public BankRegisterApp()
        {
            InitializeComponent();
        }

        private void BankRegisterApp_Load(object sender, EventArgs e)
        {
            cust1 = new Customer();
        }

        private void createAcctButton_Click(object sender, EventArgs e)
        {
                acctName = acctNameBox.Text.Split(' ');
                if (acctName.Length < 2)
                {
                    MessageBox.Show("What is your full name separated by a space?", "WHAT?!", MessageBoxButtons.OK,
                     MessageBoxIcon.Exclamation);
                    acctNameBox.Focus();
                }
                if (int.TryParse(acctNumBox.Text, out acctNum) == false)
                {
                    MessageBox.Show("Enter your account #", "WHAT?!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); acctNumBox.Focus();
                }
                if (decimal.TryParse(iniBalBox.Text, out iniBal) == false)
                {
                    MessageBox.Show("Enter intital balance", "WHAT?!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    iniBalBox.Focus();
                }

                cust1.AcctName = acctName;
                cust1.AcctNum = acctNum;
                cust1.IniBalance = iniBal;
            
                withdrawLabel.Show();
                withdrawBox.Show();
                depositLabel.Show();
                depositBox.Show();
                balanceLabel.Show();
                balanceBox.Show();
                updateButton.Show();
                resetButton.Show();
        }//end method

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(depositBox.Text, out depositBalance) == false)
            {
                MessageBox.Show("Enter deposit amount or 0 used", "WHAT?!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                depositBox.Focus();
            }
            if (decimal.TryParse(withdrawBox.Text, out withdrawBalance) == false)
            {
                MessageBox.Show("Enter withdraw amount or 0 used", "WHAT?!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                withdrawBox.Focus();
            }
            balance = cust1.WithdrawFrom(withdrawBalance);
            balance = cust1.DepositTo(depositBalance);
            balanceBox.Text = balance.ToString();
        }//end of method

        private void resetButton_Click(object sender, EventArgs e)
        {
            acctNameBox.Clear();
            acctNumBox.Clear();
            iniBalBox.Clear();
            withdrawBox.Clear();
            depositBox.Clear();
            balanceBox.Clear();

            Array.Clear(acctName, 0, 2);
            acctNum = 0;
            iniBal = 0;
            withdrawBalance = 0;
            depositBalance = 0;
            balance = 0;
            
            withdrawLabel.Hide();
            withdrawBox.Hide();
            depositLabel.Hide();
            depositBox.Hide();
            balanceLabel.Hide();
            balanceBox.Hide();
            updateButton.Hide();
            resetButton.Hide();  
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }//end class
}//end namespace
