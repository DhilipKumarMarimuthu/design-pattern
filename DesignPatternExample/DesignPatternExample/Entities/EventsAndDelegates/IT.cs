using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.EventsAndDelegates
{
    class IT
    {
        private readonly EmployeeSeparator employeeSeparator;

        public IT(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator; employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine($"Employee Name : { e.EmpName }");
        }
    }
}
