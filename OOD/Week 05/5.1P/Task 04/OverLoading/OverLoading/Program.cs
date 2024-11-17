namespace Overloading
{
    internal class Overloading
    {
        static void Main(string[] args)
        {
            methodToBeOverloaded("Kenisha");
            Console.WriteLine();
            methodToBeOverloaded("Corera", 20);

            Console.ReadLine();
        }

        // method for methodToBeOverLoaded function to accept name as the single parameter
        public static void methodToBeOverloaded(String name)
        {
            Console.WriteLine("Name: " + name);
        }

        // method to enable the methodToBeOverLoaded function with the same name to accept name and age as parameters

        

        // Adding an additional parameter causes the function to become overloaded, allowing it to retain its previous name.
        public static void methodToBeOverloaded(String name, int age)
        {
            Console.WriteLine("Name: " + name + "\nAge: " + age);
        }
    }
}