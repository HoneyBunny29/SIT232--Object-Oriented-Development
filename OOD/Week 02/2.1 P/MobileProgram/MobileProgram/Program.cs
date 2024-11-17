namespace MobileProgram
{
    internal class MobileProgram
    {
        static void Main(string[] args)
        {
            Mobile jimMoblie = new Mobile("Monnthly", "Samsung Galaxy S6", "07712223344");

            jimMoblie.setAccType("PAYG");
            jimMoblie.setDevice("iPhone 6S");
            jimMoblie.setNumber("07713334466");
            jimMoblie.setBalance(15.50);

            Console.WriteLine("Account Type: " + jimMoblie.getAccType()
                + "\nMobile Number: " + jimMoblie.getNumber()
                + "\nDevice: " + jimMoblie.getDevice()
                + "\nBalance: " + jimMoblie.getBalance());

            jimMoblie.AddCredit(10.0);
            jimMoblie.MakeCall(5);
            jimMoblie.SendText(2);


            Console.WriteLine("--------------------------------------------------------------------------------");

            Mobile KeniMobile = new Mobile("PAYG", "Galaxy F42", "07714445566");

            KeniMobile.setAccType("PAYG");
            KeniMobile.setDevice("Galaxy F42");
            KeniMobile.setNumber("07714445566");
            KeniMobile.setBalance(10.50);

            Console.WriteLine
                ("Account Type: " + KeniMobile.getAccType()
                + "\nMobile Number: " + KeniMobile.getNumber()
                + "\nDevice: " + KeniMobile.getDevice()
                + "\nBalance: " + KeniMobile.getBalance());

            KeniMobile.AddCredit(15.0);
            KeniMobile.MakeCall(3);
            KeniMobile.SendText(4);

            Console.ReadLine();


        }

    }
}