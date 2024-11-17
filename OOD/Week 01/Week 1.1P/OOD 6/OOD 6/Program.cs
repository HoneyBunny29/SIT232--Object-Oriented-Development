namespace MDoCasting
{
    class MDoCasting
    {
        static void Main(string[] args)
        {
            int sum = 10;
            int count = 5;
            int intAverage;
            intAverage = sum / count;
            double doubleAverage;
            doubleAverage = sum / count;

            Console.WriteLine($"Average is: {intAverage}");
            Console.WriteLine($"Average is: {doubleAverage}");
            doubleAverage = (double)sum / count;
            Console.WriteLine($"Average is: {doubleAverage}");
        }
    }

}

