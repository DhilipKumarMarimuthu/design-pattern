using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.AnonymouseLambdaMethod
{
    // A Method without name
    // Also known as inline delegate
    // It provides us a way to create a delegate object without creating separate method
    class AnonymouseMethodDemo
    {
        private delegate int CalculateDelegate(int x, int y);
        public void Calculate(int l, int b)
        {
            CalculateDelegate calculateDelegate = new CalculateDelegate(AreaOfRectangle);
            Console.WriteLine("Area of rectangle : "+ calculateDelegate(l, b));
        }
        private int AreaOfRectangle(int length, int breadth)
        {
            return length * breadth;
        }

        //Here codewise there is no problem here but we can reduce the number of line of code if we using inline delegate.
        //Also if the method has minimal lines of code then we can use inline delegate else it's better to have a separate method
        // We can right the above code using Anonymouse method ( inline delegate)

        public void CalculateAreaOfRect(int l, int b)
        {
            CalculateDelegate calculateDelegate = delegate (int x, int y)
            {
                return l * b;
            };
            Console.WriteLine("Area of rectangle : " + calculateDelegate(l, b));
        }

        //Anonymous method can be passed to a method that accepts delegate as a parameter

        public delegate void printDelegate(int number);
        public void PrintNumber(printDelegate printDelegate, int number)
        {
            number += 250;
            printDelegate(number);
        }

        //Anonumous method can be used as an event handler
        public event EventHandler saveEventHandler;
        public void Save()
        {
            //Save logic
            saveEventHandler?.Invoke(this, EventArgs.Empty);
        }

        private delegate int CalculateLambdaDelegate(int x, int y);
        public void CalculateAreaOfRectLambda(int l, int b)
        {
            CalculateLambdaDelegate calculateDelegate = (x, y) =>
            {
                return l * b;
            };

            /*Func<int, int, int> calculateDelegate = (x, y) =>
            {
                return l * b;
            };*/
            Console.WriteLine("Area of rectangle : " + calculateDelegate(l, b));
        }
    }
}
