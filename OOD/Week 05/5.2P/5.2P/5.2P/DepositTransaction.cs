using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_1
{
    internal class DepositTransaction
    {
        private readonly Account _account;
        private readonly decimal _amount;
        private bool _executed;
        private bool _success;
        private bool _reversed;


        public DepositTransaction(Account account, decimal amount)
        {
            _account = account ?? throw new ArgumentNullException(nameof(account));
            _amount = amount;

            //Make sure there is a positive deposit amount
            try
            {
                if (_amount <= 0)
                {
                    throw new ArgumentException("Deposit amount must be positive.");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                // Deal with the exception as necessary
            }
        }

        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine(new String('-', 85));
            Console.WriteLine("|{0, -20}|{1, 20}|{2, 20}|{3, 20}|",
                "ACCOUNT", "DEPOSIT AMOUNT", "STATUS", "CURRENT BALANCE");
            Console.WriteLine(new String('-', 85));
            Console.Write("|{0, -20}|{1, 20}|", _account.Name, _amount.ToString("C"));
            if (!_executed)
            {
                Console.Write("{0, 20}|", "Pending");
            }
            else if (_reversed)
            {
                Console.Write("{0, 20}|", "Deposit reversed");
            }
            else if (_success)
            {
                Console.Write("{0, 20}|", "Deposit complete");
            }
            else if (!_success)
            {
                Console.Write("{0, 20}|", "Invalid deposit");
            }
            Console.WriteLine("{0, 20}|", _account.balance.ToString("C"));
            Console.WriteLine(new String('-', 85));
        }

        public void Execute()
        {
            if (_executed)
            {
                throw new InvalidOperationException("Transaction has already been executed.");
            }

            try
            {
                // Make the designated payment into the account
                _account.Deposit(_amount);

                if (_amount > 0)
                {
                    _success = true;
                }

                else
                {
                    _success = false;
                    throw new InvalidOperationException("The deposit amount should be a positive number.");
                }
            }

            catch (InvalidOperationException ex)
            {
                _success = false;
                string errorMessage = "The deposit amount should be a positive number. ";
                Console.WriteLine(errorMessage); // Record the error message or print it to the console
                throw new InvalidOperationException(errorMessage, ex);

            }
            finally
            {
                _executed = true; // Designate the transaction as having been completed
            }
        }

        public void Rollback()
        {
            if (!_executed || _reversed)
            {
                throw new InvalidOperationException("Transaction cannot be rolled back.");
            }

            try
            {
                if (_success)
                {
                    // Withdraw the money that was deposited to reverse the transaction
                    _account.Withdraw(_amount);
                    _reversed = true;
                    Console.WriteLine($"Transaction Status: Executed - {_executed}, Success - {_success}, Reversed - {_reversed}");
                }
                else
                {
                    throw new InvalidOperationException("Original transaction was not successful; cannot be rolled back.");
                }
            }

            catch (InvalidOperationException ex)
            {
                string errorMessage = "Rollback failed. " + ex.Message;
                Console.WriteLine(errorMessage); // Record the error message or print it to the console
                throw new InvalidOperationException(errorMessage, ex);
            }
        }

        public decimal Amount => _amount;

        public Account Account => _account;

        public bool Executed => _executed;
        public bool Success => _success;
        public bool Reversed => _reversed;
    }
}