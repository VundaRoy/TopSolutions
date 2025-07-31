using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Interface.InterfaceExtension
{
    public class MammalMain
    {
        public static void Main(string[] args)
        {
            DomesticCat cat = new();
            //Call using reflection
            InvokeAllParameterlessMethods(cat);

            Lion lion = new Lion();
            InvokeAllParameterlessMethods(lion);

            lion.MarksTerritory("Serengeti");
        }

        public static void InvokeAllParameterlessMethods(Object animal)
        {
            if (animal == null) throw new ArgumentNullException(nameof(animal));

            Type typeOfAnimal = animal.GetType();

            MethodInfo[] methods = typeOfAnimal.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            Console.WriteLine($"Invoking parameterless methods for {animal}");
            foreach (var method in methods)
            {
                if (method.GetParameters().Length == 0) // Only invoke parameterless methods
                {
                    method.Invoke(animal, null);
                }
            }

        }
    }
}
