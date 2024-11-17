namespace FuncFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // an array of numbers
            int[] inputArray = { 1, 3, 4 };

            // utilize the input array to invoke funcFour.
            int[,] multiplicationTable = FuncFour(inputArray);

            // output the multiplication table that results.
            Console.WriteLine("Resulting Multiplication Table: ");
            Print2DArray(multiplicationTable);

            Console.WriteLine("--------------------------------------------------");

            Console.ReadLine();
        }

        static int[,] FuncFour(int[] inputArray)
        {
            int length = inputArray.Length;

            // Construct the multiplication table's 2D array.
            int[,] multiplicationTable = new int[length, length];

            // Using the values listed in the input array, populate the multiplication table.
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    multiplicationTable[i, j] = inputArray[i] * inputArray[j];
                }
            }
            return multiplicationTable;
        }

        //The method that outputs the two-dimensional array to the console
        static void Print2DArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}