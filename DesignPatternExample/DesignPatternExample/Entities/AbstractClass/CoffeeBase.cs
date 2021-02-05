using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{

    //Why abstract class is intended to be used as base class, why not to use a concrete class instead as a base class?
    //Answer
    //1. Abstract classes are not meant to be instantiated as this is an incomplete class
    //   Suppose if C# allows you to create an object for abstract class, then if someone calls abstract method using the object then what will happen?
    //   There would be no actual implementation of the method to invoke
    //2. Abstract classes are not business entity.
    //   As you have seen in the example , In reality there is no Coffee base there are coffee's like expresso, ice coffee
    //   In general abstract classes are there to support Polymorphism also code reusability
    abstract class CoffeeBase
    {
        private readonly int coffeeQuan;
        private readonly int milkQuan;
        private readonly int sugarQuan;

        public CoffeeBase(int coffeeQuan, int sugarQuan, int milkQuan)
        {
            this.coffeeQuan = coffeeQuan;
            this.sugarQuan = sugarQuan;
            this.milkQuan = milkQuan;
        }

        protected virtual void CreateMixer()
        {
            Console.WriteLine($"Created mixer of {coffeeQuan} and {sugarQuan}");
        }
        public abstract void Prepare();

    }
}
