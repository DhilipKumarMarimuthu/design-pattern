using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.TightlyCoupled
{
    class DebitCardPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Debit card Payment Mode is activated...");
        }
    }
}
