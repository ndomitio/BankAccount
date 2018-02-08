using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public abstract class Account
    {
        //properties

        private int accountNumber;
        private double accountBalance;
        private string accountType;

        //fields

        public int AccountNumber
        {
            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }

        public double AccountBalance
        {
            get { return this.accountBalance; }
            set { this.accountBalance = value; }
        }

        public string AccountType
        {
            get { return this.accountType; }
            set { this.accountType = value; }

        }
        //constructors

        public Account()
        {
            //default constructor
        }

        public Account(int accountNumber, int accountBalance, string accountType)
        {
            this.accountNumber = accountNumber;
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }
        //methods

        public virtual void ViewAccount()
        {
            Console.WriteLine("Your account balance is currently: $" + accountBalance);
        }

        public virtual void DepositMoney()
        {
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = int.Parse(Console.ReadLine());
            accountBalance += depositAmount;
            Console.WriteLine("You now have " +accountBalance+ "in your account.");
        }

        public virtual void WithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawAmount = double.Parse(Console.ReadLine());
            if (accountBalance>withdrawAmount)
            { accountBalance -= withdrawAmount;
                Console.WriteLine("You now have " + accountBalance + "remaining.");
            }
            else { Console.WriteLine("You currently do not have enough funds to process transaction."); }
        }


    }
}
