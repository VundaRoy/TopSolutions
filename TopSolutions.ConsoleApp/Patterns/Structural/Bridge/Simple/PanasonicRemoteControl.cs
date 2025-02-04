using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Bridge.Simple
{
    public class PanasonicRemoteControl : AbstractRemoteControl
    {
        public PanasonicRemoteControl(ILEDTV ledtv)
        {
            this.ledTv = ledtv;
        }
        public override void SetChannel(int channelNumber)
        {
            ledTv.SetChannel(channelNumber);
        }

        public override void SwitchOff()
        {
            ledTv.SwitchOff();
        }

        public override void SwitchOn()
        {
            ledTv.SwitchOn();
        }
    }
}
