using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Reflection.ModuleInspection
{
    internal class ModuleInspectionMain
    {
        public static void Main(string[] args)
        {
            // Get the current assembly
            var assembly = typeof(ModuleInspectionMain).Assembly;
            // Get all modules in the assembly
            var modules = assembly.GetModules();
            Console.WriteLine("Modules in the current assembly:");
            foreach (var module in modules)
            {
                Console.WriteLine($"- {module.Name}");
            }
        }
    }
}
