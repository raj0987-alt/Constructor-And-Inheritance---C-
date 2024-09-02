using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAndInheritance
{
    internal class Flower : Tree
    {
        //public Flower(string Name)
        //{
        //    Console.WriteLine("This Is Flower: {0}", Name);
        //}
        private string _color { get; set; }
        public Flower(string color):base(color)
        {
            _color = color;
            Console.WriteLine("This color is : {0}", color);
        }
       

        public string name {  get; set; }
    }
}
