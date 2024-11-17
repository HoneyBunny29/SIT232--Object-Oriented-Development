using System.Security.Principal;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Establishing an object for an account
            Account myAccount = new Account("Kenisha", 150000m);
            Account myAccount2 = new Account("Coreras", 90000m);

            Enum.Menu.Run(myAccount, myAccount2);
            Console.ReadLine();
        }
    }
}