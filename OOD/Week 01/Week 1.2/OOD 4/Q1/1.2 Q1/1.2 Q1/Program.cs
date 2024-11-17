namespace finderror1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 0, product = 0;
            while (c <= 5)
            {
                product *= 5;
                c += 1;
            }
            Console.WriteLine("Product: " + product);
            Console.WriteLine("C: " + c);
            Console.ReadKey();
        }
    }
}
//Q1
//The problem was that there were no brackets, therefore only the first line (product = product *5) would be performed and not the second (c=c+1).