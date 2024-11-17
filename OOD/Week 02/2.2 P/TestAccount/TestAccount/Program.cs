using TestAccount;

namespace TestAccount

{
    internal class TestAccount
    {
        static void Main(string[] args)
        {
            Account account = new Account("Johnson", 180000.0m);

            account.Print();
            account.Deposit(12000.0m);
            account.Withdraw(15000.0m);
            account.Print();
            Console.ReadLine();

        }
    }
}