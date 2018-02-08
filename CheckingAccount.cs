using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class CheckingAccount : Account
    { 
        //fields

        private int checkingAccountNumber;
        private double checkingAccountBalance;
        private string personalCheckingAccount;
        private string userName;

        //properties

        public int CheckingAccountNumber
        {
            get { return this.checkingAccountNumber; }
            set { this.checkingAccountNumber = value; }
        }

        public double CheckingAccountBalance
        {
            get { return this.checkingAccountBalance; }
            set { this.checkingAccountBalance = 100.00; }
        }

        public string PersonalCheckingAccount
        {
            get { return this.personalCheckingAccount; }
            set { this.personalCheckingAccount = "Checking"; }

        }

        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }
        //constructors

        public CheckingAccount ()
        {
            //default constructor
        }

        public CheckingAccount(int checkingAccountNumber, double checkingAccountBalance) : base("nick")
        {
            this.checkingAccountNumber = checkingAccountNumber;
            this.checkingAccountBalance = checkingAccountBalance;
        }
        //methods

        public override void ViewAccount()
        {
            Console.WriteLine("Your checking account balance is currently: $" + checkingAccountBalance);
        }

        public override void DepositMoney()
        {
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = int.Parse(Console.ReadLine());
            checkingAccountBalance += depositAmount;
            Console.WriteLine("You now have " + checkingAccountBalance + " in your checking account.");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawAmount = double.Parse(Console.ReadLine());
            if (checkingAccountBalance > withdrawAmount)
            {
                checkingAccountBalance -= withdrawAmount;
                Console.WriteLine("You now have " + checkingAccountBalance + "remaining.");
            }
            else { Console.WriteLine("You currently do not have enough funds in your checking account to process transaction."); }
        }

    }
}
