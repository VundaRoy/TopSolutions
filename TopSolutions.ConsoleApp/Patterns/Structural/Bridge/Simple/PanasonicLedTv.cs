using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Bridge.Simple
{
    public class PanasonicLedTv : ILEDTV
    {
        public void SetChannel(int channelNumber)
        {
            Console.WriteLine("Setting channel Number " + channelNumber + " on Panasonic TV");
        }

        public void SwitchOff()
        {
            Console.WriteLine("Turning OFF : Panasonic TV");
        }

        public void SwitchOn()
        {
            Console.WriteLine("Turning ON : Panasonic TV");
        }
    }
}
