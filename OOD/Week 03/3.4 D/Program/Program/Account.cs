﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BucketSort

{
    internal class Account
    {
        private decimal balance;
        private String name;

        //constructor
        /*public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }*/

        //deposit method
        public bool Deposit()
        {
            Console.Write("Enter the amount to deposit: ");
            string amount = Console.ReadLine();
            decimal amount2 = Convert.ToDecimal(amount);

            if (amount2 > 0)
            {
                balance += amount2;
                Console.WriteLine();
                Console.WriteLine($"Amount deposited successfully");
                Console.WriteLine($"Account Balance after Depositing {amount2} LKR: {balance} LKR");
                return true;// The deposit is successful.
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for deposit {amount2}");
                Console.WriteLine("Invalid deposit amount. Please enter a positive value");
                return false; // The deposit was unsuccessful 
            }

        }

        //withdraw method
        public bool Withdraw()
        {
            Console.Write("Enter the amount to withdraw: ");
            string amount = Console.ReadLine();
            decimal amount2 = Convert.ToDecimal(amount);

            if (amount2 > 0 && balance >= amount2)
            {
                balance -= amount2;
                Console.WriteLine();
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Account Balance after Withdrawing {amount2} LKR: {balance} LKR");
                return true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for withdrawal {amount2}");
                Console.WriteLine("Your account has Insufficient balance or Ivalid withdrawal amount. Please enter a positive value.");
                return false;
            }
        }

        // procedure for printing the balance and name
        public void Print()
        {
            Console.WriteLine("");
            Console.WriteLine($"Account Holder Name: {name}");
            Console.WriteLine($"Account Balance: {balance} LKR");
        }

        // property to obtain the account name
        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // New property for balance
        public decimal Balance { get; set; }



    }
}
