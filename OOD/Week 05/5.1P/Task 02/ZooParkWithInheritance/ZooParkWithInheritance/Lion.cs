using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Lion : Feline 
    {
        private String species;

        // constructor
        public Lion(String name, String diet, String location, double weight, int age, String colour, string species)
            : base(name, diet, location, weight, age, colour, species) // the base class's parameters are being inherited to this class constructor
        {
            this.species = species;
        }

        // function to allow lion to make its specific noise
        public override void makeNoise()
        {
            Console.WriteLine("Lion is Roaring");
        }

        // function to allow lion to eat its specific food diet
        public override void eat()
        {
            Console.WriteLine("Lion: I can eat 25 lbs of Meat");
        }

        // function to allow lion to mate
        public override void mate()
        {
            Console.WriteLine("The Lion is Mating to reproduce");
        }
    }
}
