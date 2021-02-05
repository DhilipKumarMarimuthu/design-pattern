using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.ActionFuncDelegates
{
    class CustomerFacade
    {
        //Using custom delegate
        /*public delegate void NotifyPresentation();
        public void UpdateData(NotifyPresentation notifyPresentation)
        {
            //This method calls data access layer
            notifyPresentation();
        }*/

        //Using Action delegate

        public void UpdateData(Action<string> notifyPresentation)
        {
            //This method calls data access layer
            notifyPresentation("Message from facede");
        }


        //Using custom delegate for Func
        /*public delegate string NotifyPresentationReturnString(bool returnValue);

        public void UpdateData(NotifyPresentationReturnString notifyPresentationReturnString)
        {
            var returnValue = notifyPresentationReturnString(true);
            Console.WriteLine("Customer Facade : " + returnValue);
        }*/

        //Using Func delegate
        public void UpdateData(Func<bool,string> notifyPresentationReturnString)
        {
            var returnValue = notifyPresentationReturnString(true);
            Console.WriteLine("Customer Facade : " + returnValue);
        }
    }
}
