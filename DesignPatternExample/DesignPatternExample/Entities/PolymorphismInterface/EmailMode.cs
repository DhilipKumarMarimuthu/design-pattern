using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInterface
{
    /*public class EmailMode
    {
        public void Communicate()
        {
            Console.WriteLine("Email : Message transmission via email started...");
        }
    }*/

    public class EmailMode : ICommunication
    {
        public void Communicate()
        {
            Console.WriteLine("Email : Message transmission via email started...");
        }
    }
}
