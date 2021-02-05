using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.TightlyCoupled
{
    class CreditCardPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Credit card Payment Mode is activated...");
        }
    }
}
