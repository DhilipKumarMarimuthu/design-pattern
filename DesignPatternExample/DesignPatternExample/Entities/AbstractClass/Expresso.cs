using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AbstractClass
{
    class Expresso : CoffeeBase
    {
        private readonly int iceQuan;

        public Expresso() :
            base(1,2,3)
        {
            
        }
        public override void Prepare()
        {
            Console.WriteLine("Expresso Coffee is ready");
        }
    }
}
