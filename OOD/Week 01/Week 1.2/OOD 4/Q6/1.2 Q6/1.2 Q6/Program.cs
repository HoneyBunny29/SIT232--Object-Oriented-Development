namespace finderror6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int count = 1; count < 100; count++)
            {
                Console.WriteLine("Hello");
            }
            Console.ReadKey();

        }
    }
}

//The problem lies in the fact that each of the conditions inside the for loop should be separated by a semicolon instead of a comma.