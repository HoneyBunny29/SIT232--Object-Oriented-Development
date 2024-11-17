using System.Net.NetworkInformation;

namespace FuncOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //array including more than ten items
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            //array with ten or less components
            int[] array2 = { 2, 4, 6, 8, 10 };

            // Use the first array to call FuncOne.
            int result1 = FuncOne(array1);
            Console.WriteLine($"The number of odd elements: {result1}");

            //Using the second array, call FuncOne.
            int result2 = FuncOne(array2);
            Console.WriteLine($"The total product of even elements: {result2}");
            Console.ReadLine();
        }

        static int FuncOne<T>(T[] array)
        {
            if (array.Length > 10)
            {
                int oddNum = 0;
                foreach (var element in array)
                {
                    if (Convert.ToInt32(element) % 2 == 0)
                    {
                        oddNum++;
                    }
                }
                return oddNum;
            }

            else
            {
                int evenNum = 1;
                foreach (var element in array)
                {
                    if ((Convert.ToInt32(element) % 2 == 0))
                    {
                        evenNum *= Convert.ToInt32(element);
                    }
                }
                return evenNum;
            }
        }

    }

}