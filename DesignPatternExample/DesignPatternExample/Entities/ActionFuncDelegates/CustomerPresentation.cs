using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.ActionFuncDelegates
{
    // Action delegate : holds a fucntion pointer that can take parameter but doesn't return a value
    // Func delegate   : holds a fucntion pointer that can take parameter and returns a value.
    class CustomerPresentation
    {

        public void Update()
        {
            CustomerFacade customerFacade = new CustomerFacade();
            customerFacade.UpdateData(NotificationCallbackMessage);
        }

        private void NotificationCallback(string message)
        {
            Console.WriteLine("Update data operation has been completed : " + message);
        }

        private string NotificationCallbackMessage(bool returnValue)
        {
            if(returnValue)
                Console.WriteLine("Update was successful");
            else
                Console.WriteLine("Update was not successful");
            return "Message from the callback";
        }
    }
}
