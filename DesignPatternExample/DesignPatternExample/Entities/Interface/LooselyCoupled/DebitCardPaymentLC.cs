using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.LooselyCoupled
{
    class DebitCardPaymentLC : IPaymentMode
    {
        public void MakePayment()
        {
            Console.WriteLine("Debit card Payment Mode is activated...");
        }
    }
}
