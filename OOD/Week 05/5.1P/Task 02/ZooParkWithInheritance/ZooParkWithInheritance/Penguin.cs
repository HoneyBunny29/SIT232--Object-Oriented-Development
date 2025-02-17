﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    internal class Penguin : Bird /
    {
        //constructors
        public Penguin(String name, String diet, String location, double weight, int age, String colour, string species, double wingSpan)
            : base(name, diet, location, weight, age, colour, species, wingSpan)
        {

        }

        // function to allow PENGUIN lay egg
        public override void layEgg()
        {
            Console.WriteLine("The Penguin is laying the eggs");
        }

        // function to allow penguin fly
        public override void fly()
        {
            Console.WriteLine("The Penguin can't fly");
        }

        // function to allow penguin make noise
        public override void makeNoise()
        {
            Console.WriteLine("Eagle is Squawking");
        }

        // function to allow penguin eat
        public override void eat()
        {
            Console.WriteLine("Eagle: I can eat 2 lbs of Fish");
        }

        // function to allow penguin mate
        public override void mate()
        {
            Console.WriteLine("The Penguin is Mating to reproduce");
        }
    }
}