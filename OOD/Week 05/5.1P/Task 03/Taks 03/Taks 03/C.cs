using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    internal class C : B //Subclass C is deriving from Subclass B through inheritance
    {
        public C()
        {
        }

        public void m1()
        {
            Console.WriteLine("C's M1");
        }
    }
}
