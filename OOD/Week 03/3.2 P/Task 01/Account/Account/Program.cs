using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class BankSystem
    {
        static void Main(string[] args)
        {
            Account myAccount = new Account("Johnson Corera", 180000m);

            // invalid deposit
            myAccount.Deposit(-10000);

            // valid deposit
            myAccount.Deposit(10000);


            //invalid withdraw
            myAccount.Withdraw(-10000);

            //invalid withdraw
            myAccount.Withdraw(17000);

            // valid withdraw
            myAccount.Withdraw(50000);

            myAccount.Print();
            Console.ReadLine();
        }
    }
}
