

/* Q4
 * There is now a brak; statement in every case block. 
Modify the switch variable declaration from Switch to Switch ('int n=0')..*/

namespace swichStatement
{
    class SwitchStatement
    {
        static void Main(string[] args)

        {
            int n = 0;
            switch (n)
            {
                case 1:
                    Console.WriteLine("The number is 1");
                    break;
                case 2:
                    Console.WriteLine("The number is 2");
                    break;
                default:
                    Console.WriteLine("this number is not 1 or 2 ");
                    break;
            }
        }
    }
}
