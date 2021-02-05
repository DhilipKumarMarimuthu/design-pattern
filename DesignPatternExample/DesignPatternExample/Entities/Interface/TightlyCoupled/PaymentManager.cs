using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Interface.TightlyCoupled
{
    //Interface = Reusable - Testable - Scalable
    //Advantages of Interface
    //1.    Flexible - Interfaces are used to build that are flexible. Basically it helps us to achieve loosely coupled. Components can be replaced with alternative implementations.
    //      Interfaces are the reason why we are writing flexible applications using design patterns and solid principles
    //2.    Adaptable to change - You can design the application in a way that It welcome new changes without breaking 
    //3.    Extensible - It helps us to creating the application that you can extend without making any changes in the original code [Ex : Plug-ins or Modules]
    //4.    Testable - It helps to create a design that supports testability
    //5.    Readable

    //First approach - TightlyCoupled way
    //Disadvantages
    // Payment manager class got modified in many places, in our example constructor and make payment methods are got changed. This is because of the application is tightly coupled and it always violates open close principle
    // Ripple effect of changes - In changing one module usually forces ripple effect of changes on other modules
    // Increased effort and time - Implementing new functionality will require more effort and time the increased intermodule dependencies
    // Harder to reuse - A particular module might harder to reuse because the dependent modules nust be included
    // Retesing effort and time - A particular module might harder to test because the dependent modules nust be included


    class PaymentManager
    {
        private readonly DebitCardPayment debitCardPayment;
        private readonly CreditCardPayment creditCardPayment;
        private readonly GooglePay googlePay;

        public PaymentManager(DebitCardPayment debitCardPayment, CreditCardPayment creditCardPayment, GooglePay googlePay)
        {
            this.debitCardPayment = debitCardPayment;
            this.creditCardPayment = creditCardPayment;
            this.googlePay = googlePay;
        }

        public void ManagePayment()
        {
            debitCardPayment.MakePayment();
            creditCardPayment.MakePayment();
            googlePay.MakePayment();
        }
    }
}
