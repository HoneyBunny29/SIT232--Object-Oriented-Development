namespace finderror3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int total = 0;
            while (x <= 10)
            {
                total = total + x;
                x = x + 1;
            }
            Console.WriteLine("Total: " + total);
            Console.WriteLine("X: " + x);
            Console.ReadKey();
        }
    }
}
//The problem was that there was no starting value assigned to the variable total. T
//he code that increases the total by x during loop iterations requires an initial value to increment it; if the initial value is lacking, the code cannot execute and displays an error.
//The fixed code will now function flawlessly.