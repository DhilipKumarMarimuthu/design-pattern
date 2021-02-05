using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternExample.Entities.PolymorphismInterface
{
    /*public class CommunicationFacade
    {
        public void StartCommunication(VoiceMode voiceMode)
        {
            voiceMode.Communicate();
        }
        public void StartCommunication(TextMode textMode)
        {
            textMode.Communicate();
        }
        public void StartCommunication(EmailMode emailMode)
        {
            emailMode.Communicate();
        }
    }*/

    class CommunicationFacade
    {
        public void StartCommunication(ICommunication communication)
        {
            communication.Communicate();
        }        
    }
}
