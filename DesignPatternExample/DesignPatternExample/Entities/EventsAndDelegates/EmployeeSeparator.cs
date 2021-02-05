using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.EventsAndDelegates
{
    class EmployeeEventArgs : EventArgs
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }    
    }
    class EmployeeSeparator
    {
        //Delegate is a class that holds the reference of the method. Also, it's a contract between publisher and subscriber.
        //public delegate void EmployeeSeparatedEventHandler();
        public event EventHandler<EmployeeEventArgs> EmployeeSeparated;
        public void Separate()
        {
            EmployeeEventArgs employeeEventArgs = new EmployeeEventArgs { EmpId = 1, EmpName = "Dhilip" };
            //Some code implementation here...
            if (EmployeeSeparated != null)
                EmployeeSeparated(this, employeeEventArgs);
        }
    }
}
