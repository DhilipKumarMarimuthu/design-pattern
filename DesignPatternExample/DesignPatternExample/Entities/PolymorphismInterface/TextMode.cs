using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInterface
{
    /*public class TextMode
    {
        public void Communicate()
        {
            Console.WriteLine("Text : Message transmission via text started...");
        }
    }*/

    public class TextMode : ICommunication
    {
        public void Communicate()
        {
            Console.WriteLine("Text : Message transmission via text started...");
        }
    }
}
