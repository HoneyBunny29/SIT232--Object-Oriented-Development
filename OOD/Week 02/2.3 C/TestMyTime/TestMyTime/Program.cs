using TestMyTime;

namespace TestMyTime
{
    internal class TestMyTime
    {
        static void Main(string[] args)
        {
            
            MyTime myTime = new MyTime(11, 38, 27);

            Console.WriteLine("=================================================");

            Console.WriteLine("First Time: " + myTime.ToString());

            myTime.SetTime(14, 58, 59);
            Console.WriteLine("Modified Time : " + myTime.ToString());

            Console.WriteLine("--------------------------------------------------");
            myTime.NextHour();
            myTime.NextMinute();
            myTime.NextSecond();
            Console.WriteLine("Added Time: " + myTime.ToString());

            myTime.PreviousHour();
            myTime.PreviousMinute();
            myTime.PreviousSecond();
            Console.WriteLine("Reduce Time: " + myTime.ToString());

            Console.WriteLine("====================================================");
            Console.ReadLine();
        }
    }
}