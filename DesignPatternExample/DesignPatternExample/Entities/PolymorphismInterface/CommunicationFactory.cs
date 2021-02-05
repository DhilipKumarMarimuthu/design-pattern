using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInterface
{
    class CommunicationFactory
    {
        public static ICommunication Create(int mode)
        {
            if (mode == 1)
            {
                return new VoiceMode();
            }
            else if (mode == 2)
            {
                return new TextMode();
            }
            else 
                return new EmailMode();
        }
    }
}
