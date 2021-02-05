using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.LooselyCoupled
{
    class CreditCardPaymentLC : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Credit card Payment Mode is activated...");
        }
    }
}
