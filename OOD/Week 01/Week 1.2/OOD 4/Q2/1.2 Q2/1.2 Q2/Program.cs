namespace finderror2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 31, b = 0, sum = 0;
            while (a >= b)
            {
                sum += a;
                b += 2;
            }
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("B: " + b);
            Console.ReadKey();
        }
    }
}

//Q2
//The condition that was stated inside the brackets was the problem.
//The condition reads (a!= b), which will continue to loop indefinitely as both a and b are constants that will never cease to be true.
//So, no output will be printed by this. Consequently, I've specified the condition as (a >= b) to stop it at a specific point.
//Under these circumstances, the iteration will eventually end and produce an output.