using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInheritance
{
    //Normal Implementaion
    /*public class BusinessFacade
    {
        
        public void StartCar(Car car)
        {
            car.Start();
        }
        public void StopCar(Car car)
        {
            car.Stop();
        }
        public void StartShip(Ship ship)
        {
            ship.Start();
        }
        public void StopShip(Ship ship)
        {
            ship.Stop();
        }
    }*/

    //With Base class implementaiton

    /*public class BusinessFacade
    {
        public void StartCar(Machine car)
        {
            //((Car)car).Start(); //This is cumbersome and do this kind of down casting, also error prone in case if it's not cast then throws exception. This makes our code is rigid [Non flexible] and non extensible

        }
        public void StopCar(Machine car)
        {
            //((Car)car).Stop();
        }
        public void StartShip(Machine ship)
        {
            //((Ship)ship).Start();
        }
        public void StopShip(Machine ship)
        {
            //((Ship)ship).Stop();
        }
    }*/

    //Polymorphic way
    public class BusinessFacade
    {
        public void StartMachine(Machine machine)
        {
            machine.Start();
        }
        public void StopMachine(Machine machine)
        {
            machine.Stop();
        }
    }

}
