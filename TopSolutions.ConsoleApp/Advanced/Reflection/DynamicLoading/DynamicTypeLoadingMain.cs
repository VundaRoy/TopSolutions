using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Reflection.DynamicLoading
{
    internal class DynamicTypeLoadingMain
    {
        public static void Main(string[] args)
        {
            // Load an assembly dynamically
            var assemblyPath = "C:\\source\\private\\TopSolutions\\TopSolutions.ConsoleApp\\bin\\Debug\\net6.0\\TopSolutions.ConsoleApp.dll"; // Replace with the actual path to your assembly
            var assembly = System.Reflection.Assembly.LoadFrom(assemblyPath);
            // Get a type from the loaded assembly
            var typeName = "YourNamespace.YourClass"; // Replace with the actual type name
            var type = assembly.GetType(typeName);
            if (type != null)
            {
                // Create an instance of the type
                var instance = Activator.CreateInstance(type);
                Console.WriteLine($"Successfully created an instance of {type.FullName}");
            }
            else
            {
                Console.WriteLine($"Type {typeName} not found in assembly {assembly.FullName}");
            }
        }
    }
}
