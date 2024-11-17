namespace finderror7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i > 2)
                {
                    Console.WriteLine("Flower");
                }
                Console.WriteLine("--------");
            }
            Console.WriteLine("finish");
            Console.ReadKey();
        }
    }
}
//Q7
//The problem was that the i inside the for loop was either written in capital letters or was not the same as the other i's.
//Change that I to a simple letter, and everything will work out.