using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInheritance
{
    //Four pillars of Object oriented programming
    //1.Encapsulation
    //2.Abstraction
    //3.Inheritance
    //4.Polymorphism

    //Polymorphism
    //General Definition : Something that can occur in sevaral different forms
    //Ability of a variable, fucntion or object to take on multiple forms
    //Polymorphism greatly helps in writing extensible application
    //1. Static Polymorphism - easy to understand when compare to runtime Polymorphism
    //                       -  Also known as Compile time Polymorphism. This means tha actual method call is determined at compile time.  
    //2. Dynamic Polymorphism - Also known as Runtime Polymorphism. This means tha actual method call is determined at run time.

    //Difference between abstract and concrete class
    //Abstract class                                                            Concrete class
    //1. Incomplete, with atleast one property or method not implemented        It's a normal class with all attributes implemented
    //2. Cannot be instantiated. It can only be inherited                       Can be instantiated, It's a nomal class
    //3. Intended to be used as a base class [It's not real business entity.    Can be used as a base class


    /*public class Machine
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public void Start()
        {
            Console.WriteLine("Machine has started");
        }

        public void Stop()
        {
            Console.WriteLine("Machine has stopped");
        }
    }*/

    //Abstract class with abstract methods
    /*
    public abstract class Machine
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public abstract void Start();

        public abstract void Stop();

        public virtual void 
    }*/

    
    //Abstract class with default implementation using virtual

    public abstract class Machine
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public virtual void Start()
        {
            Console.WriteLine("Machine has started");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Machine has stopped");
        }
    }
}
