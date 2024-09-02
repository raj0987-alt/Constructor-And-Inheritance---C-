using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndInheritance
{
    internal class Flower : Tree
    {
        public Flower(string Name)
        {
            Console.WriteLine("This Is Flower: {0}", Name);
        }
    }
}
