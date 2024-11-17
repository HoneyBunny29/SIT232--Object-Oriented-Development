namespace repetition2
{
    internal class repetition2
    {
        static void Main(string[] args)
        {
            int sum = 0;
            double average;
            int upperbound = 100;
            int number = 1;

            while (number <= upperbound)
            {
                sum += number;
                number++;
            }

            average = (double)sum / upperbound;
            Console.WriteLine("The Sum is: " + sum);
            Console.WriteLine("The Average is: " + average);
            Console.WriteLine();
            Console.WriteLine("Current number: " + number + " The sum is: " + sum);
            Console.ReadKey();
            // The for loop contains initialization, condition, and iteration expressions within the loop header and is frequently used to loop over a particular range or series of values.
            // Because it relies on a condition that is tested before each iteration, the while loop is more flexible and is usually used when the number of iterations is unknown.
        }
    }
}