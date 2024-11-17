namespace rewrite2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            for (int x = 0; x < 500; x++)
            {
                Console.WriteLine(x);
                x = x + 5;
                Console.WriteLine("X: " + x);
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}