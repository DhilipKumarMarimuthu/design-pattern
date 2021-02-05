using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.TightlyCoupled
{
    class GooglePay
    {
        public void MakePayment()
        {
            Console.WriteLine("Google Pay Mode is activated...");
        }
    }
}
