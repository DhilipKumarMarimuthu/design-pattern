using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.LooselyCoupled
{
    class GooglePayLC : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Google Pay Mode is activated...");
        }
    }
}
