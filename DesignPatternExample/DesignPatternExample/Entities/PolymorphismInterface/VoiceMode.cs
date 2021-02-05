using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInterface
{
    /*public class VoiceMode
    {
        public void Communicate()
        {
            Console.WriteLine("Voice : Message transmission via voice started...");
        }
    }*/

    public class VoiceMode : ICommunication
    {
        public void Communicate()
        {
            Console.WriteLine("Voice : Message transmission via voice started...");
        }
    }
}
