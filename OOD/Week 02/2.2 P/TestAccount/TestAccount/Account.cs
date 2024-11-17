using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAccount
{
        internal class Account
        {
            private decimal balance;
            private String name;

            public Account(String name, decimal balance)
            {
            Console.WriteLine("");
            this.name = name;
                this.balance = balance;
            }

            //deposit method
            public void Deposit(decimal amount)
            {
                Console.WriteLine("---------------------------------------------------------------------");
                balance += amount;
                Console.WriteLine($"Account Balance after Depositing {amount} LKR: {balance} LKR");

            }

            //withdraw method
            public void Withdraw(decimal amount)
            {
            Console.WriteLine("");
            if (balance >= amount)
                {
                    balance -= amount;
                    Console.WriteLine($"Account Balance after Withdrawing {amount} LKR: {balance} LKR");
                }

                else
                {
                    Console.WriteLine("Your account has Insufficient balance");
                }
            }

            // method to print the name and balance
            public void Print()
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine($"Account Holder Name: {name}");
                Console.WriteLine($"Account Balance: {balance} LKR");
            }

            // property to get account name
            public String Name
            {
                get
                {
                    return name;
                }
            }
        }
}
