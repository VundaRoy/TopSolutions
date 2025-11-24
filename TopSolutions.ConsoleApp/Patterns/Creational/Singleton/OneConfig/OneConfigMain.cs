using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.OneConfig
{
    public class OneConfigMain
    {
        public static void Main(string[] args)
        {
            OneConfigToRule config1 = OneConfigToRule.Instance; // Get the singleton instance
            OneConfigToRule config2 = OneConfigToRule.Instance; // Get the singleton instance again
            if (config1 == config2)
            {
                Console.WriteLine($"Both config1 and config2 reference the same instance. And the value is {config1.ConfigValue}"); 
            }
            else
            {
                Console.WriteLine("config1 and config2 reference different instances.");
            }
            Console.ReadLine();
        }
    }
}
