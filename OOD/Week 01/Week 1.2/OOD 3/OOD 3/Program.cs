namespace repetition3
{
    internal class repetition3
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;
            int number = 1;

            do
            {
                sum += number;
                number++;

            } while (number <= 100);

            average = (double)sum / upperbound;
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The Average is: " + average);
            Console.WriteLine();
            Console.WriteLine("Current number: " + number + " The sum is: " + sum);
            Console.ReadKey();
            // The for loop offers a succinct method of expressing initialization, condition, and iteration in a single line and is used when the number of iterations is known.
            // When the number of iterations is unknown ahead of time and the condition is verified before each iteration, the while loop makes sense.
            // Since the condition is tested after the first iteration, the do...while loop ensures that the function will be executed at least once inside the loop.
        }
    }
}