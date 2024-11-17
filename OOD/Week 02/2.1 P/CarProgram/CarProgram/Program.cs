namespace CarProgram
{
    internal class CarProgram
    {
        static void Main(string[] args)
        {
            Car car1 = new Car(30);
            Car car2 = new Car(10);
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("");

            car1.printFuelCost();
            car1.addFuel(5);
            car1.calcCost(5);
            car1.Drive(20);
            Console.WriteLine("");

            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("");

            car2.printFuelCost();
            car2.addFuel(10);
            car2.calcCost(10);
            car2.Drive(30);

            Console.ReadLine();
        }
    }
}