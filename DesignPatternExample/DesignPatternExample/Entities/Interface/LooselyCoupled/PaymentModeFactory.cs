using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.LooselyCoupled
{
    public enum PaymentMode
    {
        CreditCard,
        DebitCard,
        GooglePay
    }
    class PaymentModeFactory
    {
        public static IPaymentMode Create(PaymentMode paymentMode)
        {
            switch (paymentMode)
            {
                case PaymentMode.DebitCard:
                    return new DebitCardPaymentLC();
                case PaymentMode.CreditCard:
                    return new CreditCardPaymentLC();
                case PaymentMode.GooglePay:
                    return new GooglePayLC();
                default:
                    return new DebitCardPaymentLC();
            }
        }
    }
}
