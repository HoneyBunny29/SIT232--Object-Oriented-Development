using System.Security.Principal;

namespace TASK_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Account object created
            Account myAccount = new Account("Kenisha Corera", 150000m);
            Account myAccount2 = new Account("Jeno Fernando", 90000m);

            Enum.Menu.Run(myAccount, myAccount2);
            Console.ReadLine();
        }
    }
}