namespace BankSystem
{
    internal class Account
    {

        private decimal balance;
        private String name;

        //Builder
        public Account(String name, decimal balance)
        {
            this.name = name;
            this.balance = balance;
        }

        //method of deposit

        public bool Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine();
                Console.WriteLine($"Amount deposited successfully");
                Console.WriteLine($"Account Balance after Depositing {amount} LKR: {balance} LKR");
                Console.WriteLine("--------------------------------------------------------------------");
                return true;
                //The deposite is successful
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for deposit {amount}");
                Console.WriteLine("Invalid deposit amount. Please enter a positive value");
                return false;
                // The deposite was unsuccessfull
            }
        }

        //withdraw technique
        public bool Withdraw(decimal amount)
        {
            if (amount > 0 && balance >= amount)
            {
                balance -= amount;
                Console.WriteLine();
                Console.WriteLine("Withdraw successful");
                Console.WriteLine($"Account Balance after Withdrawing {amount} LKR: {balance} LKR");
                Console.WriteLine("---------------------------------------------------------------------");
                return true;
            }

            else
            {
                Console.WriteLine();
                Console.WriteLine($"Amount entered for withdrawal {amount}");
                Console.WriteLine("Your account has Insufficient balance or Ivalid withdrawal amount. Please enter a positive value.");
                return false;
            }
        }

        // how the name and balance are printed
        public void Print()
        {
            Console.WriteLine("");
            Console.WriteLine($"Account Holder Name: {name}");
            Console.WriteLine($"Account Balance: {balance} LKR");
        }

        // attribute to obtain the account name
        public String Name
        {
            get
            {
                return name;
            }
        }
    }
}