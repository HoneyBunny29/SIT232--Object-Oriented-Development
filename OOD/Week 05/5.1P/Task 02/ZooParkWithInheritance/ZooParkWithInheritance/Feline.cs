using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Feline : Animal 
    {
        private String species;

        // constructors
        public Feline(String name, String diet, String location, double weight, int age, String colour, string species)
            : base(name, diet, location, weight, age, colour)
        {
            this.species = species;
        }

        // function to allow feline to make noise
        public override void makeNoise()
        {
            Console.WriteLine("Feline is purring");
        }

        // function to allow feline to eat
        public override void eat()
        {
            Console.WriteLine("Feline: I can eat 15 lbs of Meat");
        }

        // function to allow feline to mate
        public override void mate()
        {
            Console.WriteLine("The Feline is Mating to reproduce");
        }
    }
}
