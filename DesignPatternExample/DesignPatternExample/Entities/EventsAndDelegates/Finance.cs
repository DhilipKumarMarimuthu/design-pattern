using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.EventsAndDelegates
{
    class Finance
    {
        private readonly EmployeeSeparator employeeSeparator;

        public Finance(EmployeeSeparator employeeSeparator)
        {
            this.employeeSeparator = employeeSeparator;
            employeeSeparator.EmployeeSeparated += EmployeeSeparatedEventHandler;
        }

        public void EmployeeSeparatedEventHandler(object sender, EmployeeEventArgs e)
        {
            Console.WriteLine($"Employee Id : { e.EmpId }");
        }
    }
}
