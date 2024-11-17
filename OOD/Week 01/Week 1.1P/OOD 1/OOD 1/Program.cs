namespace IfStatement
{
    class IfStatement
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number (as an Integer): ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());

                if (number == 1)
                {
                    Console.WriteLine("ONE");
                }
                else if (number == 2)
                {
                    Console.WriteLine("TWO");
                }
                else if (number == 3)
                {
                    Console.WriteLine("THREE");
                }
                else if (number == 4)
                {
                    Console.WriteLine("FOUR");
                }
                else if (number == 5)
                {
                    Console.WriteLine("FIVE");
                }
                else if (number == 6)
                {
                    Console.WriteLine("SIX");
                }
                else if (number == 7)
                {
                    Console.WriteLine("SEVEN");
                }
                else if (number == 8)
                {
                    Console.WriteLine("EIGHT");
                }
                else if (number == 9)
                {
                    Console.WriteLine("NINE");
                }
                else
                {
                    Console.WriteLine("Error: You must Enter Between 1 to 9");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("this variable is not an Integer \n" + e);
            }
        }
    }
}

