using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{
    //Abstract method must be implemented by derived class, Is this just a reminder to a derived class or something else?
    //Yes, it's reminder that all the clients should implemented the abstract method 
    public abstract class PrintBase
    {
        public abstract void Print();
    }
}
