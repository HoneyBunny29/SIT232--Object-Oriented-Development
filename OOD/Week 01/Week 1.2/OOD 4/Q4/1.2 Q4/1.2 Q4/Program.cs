namespace finderror4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            while (y < 10)
            {
                y = y + 1;
                Console.WriteLine("y: " + y);
            }
            Console.ReadKey();
        }
    }
}
//The problem is that declaring y inside the loop is improper.
//In order to prevent an error from being displayed by the condition provided inside the loop, it should be declared outside of it.