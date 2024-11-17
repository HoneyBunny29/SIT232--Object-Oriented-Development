using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Tiger : Feline 
    {
        private String colorStripes;

        //constructors
        public Tiger(String name, String diet, String location, double weight, int age, String colour, string species, string colorStripes)
            : base(name, diet, location, weight, age, colour, species)
        {
            this.colorStripes = colorStripes;
        }

        // functions to allow tiger to make noise
        public override void makeNoise()
        {
            Console.WriteLine("ROARRRRRRRRR");
        }

        // functions to allow tiger to eat
        public override void eat()
        {
            Console.WriteLine("Tiger: I can eat 20 lbs of meat");
        }

        // functions to allow tiger to mate
        public override void mate()
        {
            Console.WriteLine("The Tiger is Mating to reproduce");
        }
    }
}