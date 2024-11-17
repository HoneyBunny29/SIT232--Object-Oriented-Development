namespace Microwave
{
    class Microwave
    {
        public static int checkHeat(int Number_of_Items, int time)
        {
            if (Number_of_Items == 5)
            {
                return time;
            }
            else if (Number_of_Items == 2)
            {
                return (int)(time * 1.5);
            }
            else if (Number_of_Items == 8)
            {
                return time * 2;

            }
            else
            {
                Console.WriteLine("Heating more than three items at once is not recommended.");
                return -1;
            }
        }

        static void Main(string[] args)
        {
            int recommendedTime = checkHeat(10, 5);

            Console.WriteLine($"Recommended heating time: {recommendedTime} munites");
        }
    }

}

