using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Singleton.Basic
{
    public class OneWay
    {
        private static OneWay _oneTime;
        private OneWay() { }
        public static OneWay OneTime
        {

            get
            {
                if (_oneTime == null)
                    _oneTime = new OneWay();
                return _oneTime;

            }

        }
        public void DoOnewayRun()
        {
            Console.WriteLine("Faye runaway");
        }
    }


}
