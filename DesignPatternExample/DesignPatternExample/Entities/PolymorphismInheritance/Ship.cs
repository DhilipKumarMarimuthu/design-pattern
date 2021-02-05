using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInheritance
{
    //Normal Way of implementaion
    /*public class Ship
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public void Start()
        {
            Console.WriteLine("Ship started...");
        }

        public void Stop()
        {
            Console.WriteLine("Ship stopped...");
        }
    }*/

    //Polymorphism with Base class
    public class Ship : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Ship started...");
        }

        public override void Stop()
        {
            Console.WriteLine("Ship stopped...");
        }
    }
}
