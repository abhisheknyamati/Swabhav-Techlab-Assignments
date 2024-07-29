using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountManager
{
    internal class AccountManager : Account
    {       
        private static List<Account> accounts = new List<Account>();

        public AccountManager () 
        {
            accounts = SerializeDeserialize.Deserialize();
        }

        public void CallMainMenu()
        {
            Console.WriteLine("Welcome!");
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Choose from the options given below:\n1. Create New Account\n2. Work with Existing Account\n3. Exit");
                int userInput;
                if (!int.TryParse(Console.ReadLine(), out userInput) || userInput > 3 )
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                    continue; 
                }
                switch (userInput)
                {
                    case 1:
                        Account account = CreateAccount();
                        accounts.Add(account);
                        Console.WriteLine("Account has been created.");
                        break;
                    case 2:
                        CallSubMenu();
                        break;
                    case 3:
                        Console.WriteLine("Thank You for using our application.");
                        SerializeDeserialize.Serialize(accounts);
                        exit = true;
                        break;
                }
            }
        }

        public static Account CreateAccount()
        {
            Console.WriteLine("Enter the following details to create new account :");
            Console.Write("Enter ID : ");
            int id;
            do
            {
                id = int.Parse(Console.ReadLine());
                if (FindAccount(accounts, id) != null)
                {
                    Console.WriteLine("Account with this ID : {id} already exist, try using other ID.");
                }
                else break;
            } while (true);


            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Balance : ");
            double balance = double.Parse(Console.ReadLine());

            Account newAccount = new Account();
            newAccount.Id = id;
            newAccount.Name = name;
            newAccount.Balance = balance;

            return newAccount;
        }

        public static void CallSubMenu()
        {
            bool exit = false;
            while(!exit)
            {
                Console.WriteLine();
                Console.WriteLine("Choose from the options given below :\n1. Deposit\n2. Withdraw\n3. Exit\n4. Print All Account Details");
                int userInput = int.Parse(Console.ReadLine());
                switch (userInput)
                {
                    case 1:
                        Deposit(accounts);
                        break;
                    case 2:
                        Withdraw(accounts);
                        break;
                    case 3:
                        Console.WriteLine("Thank You for using our services.");
                        exit = true;
                        break;
                    case 4:
                        PrintAllAccounts(accounts);
                        break;
                    default:
                        Console.WriteLine("Enter valid number to choose the options");
                        break;
                }
            }
        }

        public static void Deposit(List<Account> accounts)
        {
            Console.WriteLine("Enter the Account ID to deposit the amount : ");
            int userInput = int.Parse(Console.ReadLine());
            Account account = FindAccount(accounts, userInput);
            if (account != null)
            {
                Console.WriteLine("Enter the amount to deposit : ");
                double amount = double.Parse(Console.ReadLine());
                account.Balance += amount;
                Console.WriteLine($"Amount is sucessfully deposited.");
            }
            else 
            {
                Console.WriteLine("Error 404 : Account NOT FOUND!");
            }
        }

        public static void Withdraw(List<Account> accounts)
        {
            Console.WriteLine("Enter the Account ID to Withdraw the amount : ");
            int userInput = int.Parse(Console.ReadLine());
            Account account = FindAccount(accounts, userInput);
            if (account != null)
            {
                Console.WriteLine("Enter the amount to Withdraw : ");
                double amount = double.Parse(Console.ReadLine());
                account.Balance -= amount;
                Console.WriteLine($"Amount is sucessfully Withdrawn.");
            }
            else
            {
                Console.WriteLine("Error 404 : Account NOT FOUND!");
            }
        }

        public static void PrintAllAccounts(List<Account> accounts)
        {
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"| {"ID",-10} | {"Name",-10} | {"Balance",-10} |");
            Console.WriteLine("---------------------------------------");

            foreach (Account account in accounts)
            {
                Console.WriteLine($"| {account.Id,-10} | {account.Name,-10} | {account.Balance,-10} |");
            }
            Console.WriteLine("---------------------------------------");
        }

        public static Account FindAccount(List<Account> accounts, int accountNumber)
        {
            foreach (Account account in accounts)
            {
                if (account.Id == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }
    }
}
