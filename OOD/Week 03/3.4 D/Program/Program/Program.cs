using System.Security.Principal;

namespace BucketSort
{
    internal class Program : AccountSorter
    {
        static void Main(string[] args)
        {
            // Use a range of Account objects to test the implementation.
            Account[] accountArray =
            {
                new Account {  Name = "Johnson", Balance = 450 },
                new Account {  Name = "Corera ", Balance = 300 },
                new Account {  Name = "Fernando", Balance = 500 },
                new Account {  Name = "Maria ", Balance = 250 }
            };

           

            Console.WriteLine("Original Array:");
            PrintAccounts(accountArray);

            //AccountsSorter is used to sort the array.Arrange
            AccountsSorter.Sort(accountArray, 3);

            Console.WriteLine("Sorted Array:");
            PrintAccounts(accountArray);

            Console.WriteLine("=====================================================================");
            // Use a List of Account objects to test the implementation.
            List<Account> accountList = new List<Account>
            {
                new Account { Name = "Clavine "  },// The account balance will be set to 0 by default if a null value is entered.
                new Account { Name = "Ronaldo",  Balance = 200 },
                new Account { Name = "Mark",  Balance = 750 },
                new Account { Name = "Joesph",  Balance = 200 }
            };

            Console.WriteLine("Original List:");
            PrintAccounts(accountList);

            // Use AccountsSorter.Sort to sort the list.
            AccountsSorter.Sort(accountList, 3);

            Console.WriteLine("Sorted List:");
            PrintAccounts(accountList);

            Console.WriteLine("The application of bucket sorting was successfully tested.");
            Console.ReadLine();
        }

        // A helpful way to print accounts
        static void PrintAccounts(IEnumerable<Account> accounts)
        {
            foreach (var acc in accounts)
            {
                Console.WriteLine($"Name: {acc.Name} - Balance: {acc.Balance}");
            }
            Console.WriteLine();
        }


    }
}