using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndInheritance
{
    internal class Tree
    {
        private string _color {  get; set; }
        public Tree(string color)
        {
            _color = color;
            Console.WriteLine("This color is: {0} ", color);

        }
        public string pata {  get; set; }
        public string shikor {  get; set; }
        public string dal {  get; set; }

    
    }
}
