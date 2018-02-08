using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class Client : Account
    {
        //fields

        private bool hasCheckingAccount;
        private bool hasSavingsAccount;
        private bool hasMoneyInWallet;
         
        //properties

        public bool HasCheckingAccount
        {
            get { return this.hasCheckingAccount; }
            set { this.hasCheckingAccount = value; }
        }

        public bool HasSavingsAccount
        {
            get { return this.hasSavingsAccount; }
            set { this.hasSavingsAccount = value; }
        }

        public bool HasMoneyInWallet
        {
            get { return this.hasMoneyInWallet; }
            set { this.hasMoneyInWallet = value; }

        }
        //constructors

        public Client()
        {
            //default constructor
        }

        public Client(bool hasSavingsAccount, bool hasCheckingAccount, bool hasMoneyInWallet)
        {
            this.hasSavingsAccount = hasSavingsAccount;
            this.hasCheckingAccount = hasCheckingAccount;
            this.hasMoneyInWallet = true;
        }
        //methods
        public void GoToBank ()
            {
            if ((hasSavingsAccount == true)||(hasCheckingAccount == true))
            { Console.WriteLine("Time to go to the bank!"); }
                    }

}

}

