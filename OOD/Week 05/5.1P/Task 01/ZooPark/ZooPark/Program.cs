namespace _01
{
    internal class ZooPark
    {
        static void Main(string[] args)
        {
            // Animal objects
            Animal williamWolf = new Animal("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Animal tonyTiger = new Animal("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White");
            Animal edgarEagle = new Animal("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black");

            //using each created object's function call
            williamWolf.eat();
            tonyTiger.eat();
            edgarEagle.eat();

            Console.WriteLine();

            williamWolf.sleep();
            tonyTiger.sleep();
            edgarEagle.sleep();

            Console.WriteLine();

            williamWolf.makeNoise();
            tonyTiger.makeNoise();
            edgarEagle.makeNoise();

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}