using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInheritance
{
    //Normal Way of implementaion
    /*public class Car
    {
        public string Name { get; set; }
        public int Price  { get; set; }

        public void Start()
        {
            Console.WriteLine("Car started...");
        }

        public void Stop()
        {
            Console.WriteLine("Car stopped...");
        }
    }*/

    //Polymorphism with Base class
    public class Car : Machine
    {
        public override void Start()
        {
            Console.WriteLine("Car started...");
        }

        public override void Stop()
        {
            Console.WriteLine("Car stopped...");
        }
    }
}
