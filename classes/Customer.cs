using System;
using System.Windows.Forms;

namespace BankRegisterApp
{
    class Customer
    {
        private string[] acctName;
        private int acctNum;
        private decimal iniBalance;

        public Customer()
        {
        }

        public Customer(string[]aName, int aNum, decimal iniBal)
        {
            acctName = aName;
            acctNum = aNum;
            iniBalance = iniBal;
        }

        public string[] AcctName
        {
            get
            {
                return acctName;
            }

            set
            {
                acctName = value;
            }
        }

        public int AcctNum
        {
            get
            {
                return acctNum;
            }

            set
            {
                acctNum = value;
            }
        }

        public decimal IniBalance
        {
            get
            {
                return iniBalance;
            }

            set
            {
                iniBalance = value;
            }
        }

        public decimal DepositTo(decimal dBal)
        {
            iniBalance = iniBalance + dBal;
            return iniBalance;
        }//end method

    public decimal WithdrawFrom(decimal wBal)
        {
            iniBalance = iniBalance - wBal;
            return iniBalance;
        }//end method
    }//end class
}//end namspace
