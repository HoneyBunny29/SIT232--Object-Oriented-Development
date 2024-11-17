using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task5_2P;

namespace TASK_1
{

    internal class Bank
    {
        private readonly List<Account> _accounts;

        public interface ITransaction
        {
            Account Account { get; }
            WithdrawTransaction WithdrawTransaction { get; }
            DepositTransaction DepositTransaction { get; }
            void Execute();
        }

       
        public Bank()
        {
            _accounts = new List<Account>();
        }

        
        public void AddAccount(Account account)
        {
            _accounts.Add(account);
        }

        
        public Account GetAccount(string name)
        {
            return _accounts.FirstOrDefault(a => a.Name == name);
        }

        // Executes a deposit into an account
        public void ExecuteTransaction(DepositTransaction transaction)
        {
            if (_accounts.Contains(transaction.GetAccount()))
            {
                transaction.Execute();
            }
            else
            {
                Console.WriteLine("Error: Account not found.");
            }
        }

        //carries out a WithdrawTransaction for a given account.
        public void ExecuteTransaction(WithdrawTransaction transaction)
        {
            if (_accounts.Contains(transaction._account))
            {
                transaction.Execute();
            }
            else
            {
                Console.WriteLine("Error: Account not found.");
            }
        }

        //Makes money transfers between bank accounts
        public void ExecuteTransaction(TransferTransaction transaction)
        {
            try
            {
                transaction.Execute();
            }
            catch (InvalidOperationException exception)
            {
                Console.WriteLine("An error occured in executing the transaction");
                Console.WriteLine("The error was: " + exception.Message);
            }
        }
    }
}