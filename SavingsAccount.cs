using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class SavingsAccount : Account
    {
        //{//properties

        //    private int savingsAccountNumber;
        //    private double savingsAccountBalance;
        //    private string personalSavingsAccount;

        //    //fields

        //    public int SavingsAccountNumber
        //    {
        //        get { return this.savingsAccountNumber; }
        //        set { this.savingsAccountNumber = value; }
        //    }

        //    public double SavingsAccountBalance
        //    {
        //        get { return this.savingsAccountBalance; }
        //        set { this.savingsAccountBalance = value; }
        //    }

        //    public string PersonalSavingsAccount
        //    {
        //        get { return this.personalSavingsAccount; }
        //        set { this.personalSavingsAccount = value; }

        //    }
        //    //constructors

        public SavingsAccount()
        {
            //default constructor
        }

        public SavingsAccount(int savingsAccountNumber, double savingsAccountBalance)
        {
            this.accountNumber = savingsAccountNumber;
            this.accountBalance = savingsAccountBalance;
        }
        //methods

        public override void ViewAccount()
        {
            Console.WriteLine("Your savings account balance is currently: $" + accountBalance);
        }

        public override void DepositMoney()
        {
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = int.Parse(Console.ReadLine());
            accountBalance += depositAmount;
            Console.WriteLine("You now have " + accountBalance + " in your savings account.");
        }

        public override void WithdrawMoney()
        {
            Console.WriteLine("How much would you like to withdraw?");
            double withdrawAmount = double.Parse(Console.ReadLine());
            if (accountBalance > withdrawAmount)
            {
                accountBalance -= withdrawAmount;
                Console.WriteLine("You now have " + accountBalance + " remaining in your savings account.");
            }
            else { Console.WriteLine("You currently do not have enough funds in your savings account to process transaction."); }
        }


    }
}

