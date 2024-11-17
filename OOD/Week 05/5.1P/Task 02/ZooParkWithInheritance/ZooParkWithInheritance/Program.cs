namespace _02
{
    internal class ZooPark
    {
        static void Main(string[] args)
        {
            // all of the items featuring animals and birds
            Tiger tonyTiger = new Tiger("Tony the Tiger", "Meat", "Cat Land", 110, 6, "Orange and White", "Siberian", "White");
            Eagle edgarEagle = new Eagle("Edgar the Eagle", "Fish", "Bird Mania", 20, 15, "Black", "Harpy", 98.5);
            Wolf williamWolf = new Wolf("William the Wolf", "Meat", "Dog Village", 50.6, 9, "Grey");
            Feline johnFeline = new Feline("John the Feline", "Meat", "Cat Land", 6, 5, "Brown", "Siberian");
            Penguin jimmyPenguin = new Penguin("Jimmy the Penguin", "Fish", "Bird Mania", 29, 8, "Black and White", "Emperor", 76);
            Animal baseAnimal = new Animal("Corera", "Rice", "Kandy", 60, 25, "Brown");

            // Functions are triggered to verify every method for every entity
            tonyTiger.makeNoise();
            baseAnimal.makeNoise();
            williamWolf.makeNoise();
            edgarEagle.makeNoise();
            johnFeline.makeNoise();
            jimmyPenguin.makeNoise();

            Console.WriteLine();

            tonyTiger.eat();
            baseAnimal.eat();
            williamWolf.eat();
            edgarEagle.eat();
            johnFeline.eat();
            jimmyPenguin.eat();

            Console.WriteLine();

            tonyTiger.mate();
            baseAnimal.mate();
            williamWolf.mate();
            edgarEagle.mate();
            johnFeline.mate();
            jimmyPenguin.mate();

            Console.WriteLine();

            tonyTiger.sleep();
            baseAnimal.sleep();
            williamWolf.sleep();
            edgarEagle.sleep();
            johnFeline.sleep();
            jimmyPenguin.sleep();

            Console.WriteLine();

            edgarEagle.layEgg();
            edgarEagle.fly();
            jimmyPenguin.layEgg();
            jimmyPenguin.fly();

            Console.WriteLine();

            Console.ReadLine();
        }
    }
}