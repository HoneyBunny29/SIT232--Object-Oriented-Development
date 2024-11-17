using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{

    internal class Account
    {
        public decimal balance;
        private String name;

        //constructor
        public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }



        //deposit method
        public bool Deposit(decimal amount)
        {


            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine();
                Console.WriteLine($"Amount deposited successfully");
                Console.WriteLine($"Account Balance after Depositing {amount:C}: {balance:C}");
                return true; 
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for deposit {amount}");
                Console.WriteLine("Invalid deposit amount. Please enter a positive value");
                return false; 
            }
        }

        
        public bool Withdraw(decimal amount)
        {

            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine();
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Account Balance after Withdrawing {amount:C}: {balance:C}");
                return true;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for withdrawal {amount}");
                Console.WriteLine("Your account has Insufficient balance or Invalid withdrawal amount. Please enter a positive value.");
                return false;
            }
        }

        
        public void Print()
        {
            Console.WriteLine("Account Name: {0}, Balance: {1}",
                name, balance.ToString("C"));
        }

       
        public String Name
        {
            get
            {
                return name;
            }
        }

    }
}