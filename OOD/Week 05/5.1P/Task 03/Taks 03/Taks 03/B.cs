using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class B : A //Based on base class A, subclass B is interacting.
    {
        public B() { }

        public override void m1()
        {
            Console.WriteLine("B's M1");
        }

        public void m2()
        {
            Console.WriteLine("B's M2");
        }
    }
}