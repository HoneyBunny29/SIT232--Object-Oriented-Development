namespace NumberGuessing
{
    class NumberGuessing
    {
        static void Main(string[] args)
        {

            int guess = 5;

            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine()); ;

                if (input >= 1 && input <= 10)
                {

                    if (input == guess)
                    {
                        Console.WriteLine("You have guessed the number! Well done!");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your Guess is Wrong");
                    }


                }
                else
                {
                    Console.WriteLine("Sorry, The Numbers only between 1-10");

                }
            }
        }


    }
}