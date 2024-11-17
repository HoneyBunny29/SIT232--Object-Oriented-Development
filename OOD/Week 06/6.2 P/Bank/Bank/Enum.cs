using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5_2P;

namespace TASK_1
{
    internal class Enum
    {
        public enum MenuOption
        {
            WITHDRAW = 1,
            DEPOSIT = 2,
            PRINT = 3,
            TRANSFER = 4,
            NEWACCOUNT = 5,
            QUIT
        }

        public class Menu
        {
            private Bank _bank;

           
            public static void Run(Account myAccount, Account myAccount2)
            {
                Bank bank = new Bank();
                MenuOption userChoice;
                do
                {
                    
                    userChoice = ReadUserOption();

                    
                    switch (userChoice)
                    {
                        case MenuOption.WITHDRAW:
                            {
                                DoWithdraw(bank);
                                break;
                            }
                        case MenuOption.DEPOSIT:
                            {
                                DoDeposit(bank);
                                break;
                            }
                        case MenuOption.PRINT:
                            {
                                DoPrint(bank);
                                break;
                            }
                        case MenuOption.TRANSFER:
                            {
                                DoTransfer(bank);
                                break;
                            }
                        case MenuOption.NEWACCOUNT: // New option for adding accounts
                            {
                                CreateAccount(bank);
                                break;
                            }
                        case MenuOption.QUIT:
                            {
                                Console.WriteLine("Exiting the bank system. GoodBye!");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option. Please choose a valid option.");
                                break;
                            }
                    }
                } while (userChoice != MenuOption.QUIT);
            }

            private static MenuOption ReadUserOption()
            {
                MenuOption userChoice;

                do
                {
                    //display menu
                    Console.WriteLine("\nMenu Options:");
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Print");
                    Console.WriteLine("4. Transfer");
                    Console.WriteLine("5. Open account");
                    Console.WriteLine("6. Quit");

                    //prompting input from user
                    Console.WriteLine("Choose Choices (1 - 6): ");
                    string userInput = Console.ReadLine();

                    if (int.TryParse(userInput, out int userInput2) && userInput2 >= 1 && userInput2 <= 6)
                    {
                        userChoice = (MenuOption)userInput2;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Option. Please enter from (1 - 6)");
                    }
                } while (true);
                return userChoice;
            }

            public static String ReadString(String prompt)
            {
                Console.Write(prompt + ": ");
                return Console.ReadLine();
            }

            
            public static decimal ReadDecimal(String prompt)
            {
                decimal number = 0;
                string numberInput = ReadString(prompt);
                while (!(decimal.TryParse(numberInput, out number)) || number < 0)
                {
                    Console.WriteLine("Please enter a decimal number, $0.00 or greater");
                    numberInput = ReadString(prompt);
                }
                return Convert.ToDecimal(numberInput);
            }

            
            public static int ReadInteger(String prompt)
            {
                int number = 0;
                string numberInput = ReadString(prompt);
                while (!(int.TryParse(numberInput, out number)))
                {
                    Console.WriteLine("Please enter a whole number");
                    numberInput = ReadString(prompt);
                }
                return Convert.ToInt32(numberInput);
            }


            
            public static int ReadInteger(String prompt, int minimum, int maximum)
            {
                int number = ReadInteger(prompt);
                while (number < minimum || number > maximum)
                {
                    Console.WriteLine("Please enter a whole number from " +
                                      minimum + " to " + maximum);
                    number = ReadInteger(prompt);
                }
                return number;
            }

            
            static void DoDeposit(Bank bank)
            {
                Account account = FindAccount(bank);
                if (account != null)
                {
                    decimal amount = ReadDecimal("Enter the amount");
                    DepositTransaction transaction = new DepositTransaction(account, amount);
                    try
                    {
                        bank.ExecuteTransaction(transaction);
                    }
                    catch (InvalidOperationException)
                    {
                        transaction.Print();
                        return;
                    }
                    transaction.Print();
                }
            }
        }

        
        static void DoWithdraw(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                decimal amount = Menu.ReadDecimal("Enter the amount");
                WithdrawTransaction transaction = new WithdrawTransaction(account, amount);
                try
                {
                    bank.ExecuteTransaction(transaction);
                }
                catch (InvalidOperationException)
                {
                    transaction.Print();
                    return;
                }
                transaction.Print();
            }
        }

        
        static void DoPrint(Bank bank)
        {
            Account account = FindAccount(bank);
            if (account != null)
            {
                account.Print();
            }
        }

        
        static void DoTransfer(Bank bank)
        {
            Console.WriteLine("Transfer from:");
            Account from = FindAccount(bank);
            Console.WriteLine("Transfer to:");
            Account to = FindAccount(bank);
            if (from != null && to != null)
            {
                decimal amount = Menu.ReadDecimal("Enter the amount");
                try
                {
                    TransferTransaction transaction = TransferTransaction.Builder
                        .FromAccount(from)
                        .ToAccount(to)
                        .Amount(amount)
                        .Build();
                    bank.ExecuteTransaction(transaction);
                    transaction.Print();
                }
                catch (Exception)
                {
                   
                }
            }
        }

        
        static void CreateAccount(Bank bank)
        {
            string name = Menu.ReadString("Enter account name");
            decimal balance = Menu.ReadDecimal("Enter the opening balance");
            bank.AddAccount(new Account(name, balance));
        }

        private static Account FindAccount(Bank bank)
        {
            string name = Menu.ReadString("Enter the account name");
            Account account = bank.GetAccount(name);
            if (account == null)
            {
                Console.WriteLine("That account name does not exist at this bank");
            }
            return account;
        }



    }
}