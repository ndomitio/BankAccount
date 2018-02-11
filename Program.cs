using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            //*use double for money
            // create base class first
            //create derived classes next
            //create menu 
            
            int userChoice;
            Client Nick = new Client(true, true, true);
            ObjectListPractice Pete = new ObjectListPractice();
            ObjectListPractice Marc = new ObjectListPractice();
            Marc.AllClients.Add(Nick);
            Pete.AllClients.Add(Nick);
            CheckingAccount NickChecking = new CheckingAccount(1001, 150.00, string.Empty);
            SavingsAccount NickSaving = new SavingsAccount(5005, 1000.00);
            Console.WriteLine("Please enter your name");
            NickChecking.AccountHolder = Console.ReadLine(); 

            if ((Nick.HasCheckingAccount == true) || (Nick.HasSavingsAccount == true))
            {
                Nick.GoToBank();
            }
            else
            {
                Console.WriteLine("You need an account first!");
            }


            //Console.WriteLine("Enter your name:");
            //string userName = Console.ReadLine();
            Console.WriteLine("Enter your account number");
            int userID = int.Parse(Console.ReadLine());

            do
            {
                
                Console.WriteLine("\n1. View Client Information");
                Console.WriteLine("2.View Account Balance");
                Console.WriteLine("3. Deposit Funds");
                Console.WriteLine("4. Withdraw Funds");
                Console.WriteLine("5. Exit");
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.WriteLine(NickChecking.AccountHolder + " has account #" + userID + ".  Currently has " + NickChecking.AccountBalance + " in checking account and "
                                + NickSaving.AccountBalance + " in savings account.");
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter: 1 to view checking account balance\nEnter: 2 to view savings account balance");
                            int userAccount = int.Parse(Console.ReadLine());
                            if (userAccount == 1)
                            {
                                Console.WriteLine(NickChecking.AccountBalance);
                            }
                            if (userAccount == 2)
                            {
                                Console.WriteLine(NickSaving.AccountBalance);
                            }

                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter: 1 for Checking Account Deposit\nEnter: 2 for Savings Account Deposit");

                            int accountChoice = int.Parse(Console.ReadLine());
                            if (accountChoice == 1)
                            {
                                NickChecking.DepositMoney();
                            }
                            if (accountChoice == 2)
                            {
                                NickSaving.DepositMoney();
                            }

                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("Enter: 1 for Checking Account Withdrawal\nEnter: 2 for Savings Account Withdrawal");

                            int accountChoice = int.Parse(Console.ReadLine());
                            if (accountChoice == 1)
                            {
                                NickChecking.WithdrawMoney();
                            }
                            if (accountChoice == 2)
                            {
                                NickSaving.WithdrawMoney();
                            }

                            break;
                        }
                }
            } while (userChoice != 5);
        }
    }
}


















