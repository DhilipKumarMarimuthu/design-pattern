using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.Delegates
{
    class DelegateDemo
    {
        //Deligate is a class that represents a method with a specific signature and return type
        //Delegate is a pointer to a method, which menas an instance of a delegate holds the address of the method and hence it can call the method from anywhere.

        public delegate void PrintMessgaeHandler(string message);

        public delegate void UpdatePrintMessage(int itemNumber);
        public void Print(string message)
        {
            PrintMessgaeHandler printMessgaeHandler = new PrintMessgaeHandler(PrintMessgae);
            printMessgaeHandler(message);
        }
        private void PrintMessgae(string message)
        {
            Console.WriteLine("Print message from delegate : " + message);
        }

        public void DoLongOperation(UpdatePrintMessage updatePrintMessage)
        {
            for(int i = 0; i < 1000; i++)
            {
                updatePrintMessage(i);
                Thread.Sleep(2000);
            }
        }
    }
}
