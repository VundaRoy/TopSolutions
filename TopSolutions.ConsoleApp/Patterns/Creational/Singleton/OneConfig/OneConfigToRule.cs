using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.OneConfig
{
    public class OneConfigToRule
    {
        private static OneConfigToRule _instance;
        //Singleton pattern for one config to rule them all
        public static OneConfigToRule Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new OneConfigToRule();
                }
                return _instance;
            }
        }
        
    }
}
