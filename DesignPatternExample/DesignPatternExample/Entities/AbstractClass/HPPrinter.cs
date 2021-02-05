using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{
    class HPPrinter : PrintBase
    {
        public override void Print()
        {
            Console.WriteLine("Print using HP");
        }
    }
}
