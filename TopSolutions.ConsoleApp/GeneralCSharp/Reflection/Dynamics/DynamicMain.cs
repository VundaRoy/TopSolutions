using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Reflection.Dynamics
{
    public class DynamicMain
    {
        static void Main(string[] args)
        {
            Student student1 = new()
            {
                Name = "Anurag",
                Branch = "CSE",
                Roll = 1001
            };

            // Student type to dynamic conversion
            dynamic dynamicStudent = student1;
            Console.WriteLine($"Name = {dynamicStudent.Name}");
            Console.WriteLine($"Branch = {dynamicStudent.Branch}");
            Console.WriteLine($"Roll = {dynamicStudent.Roll}");

            Console.ReadKey();

            //convert from dynamic to student type
            dynamic dynamicStudent2 = new Student()
            {
                Name = "Anurag",
                Branch = "CSE",
                Roll = 1001
            };
            // dynamic to Student type conversion
            Student student2 = dynamicStudent2;
            Console.WriteLine("Convert from dynamic to student");
            Console.WriteLine($"Name = {student2.Name}");
            Console.WriteLine($"Branch = {student2.Branch}");
            Console.WriteLine($"Roll = {student2.Roll}");

            Console.ReadKey();

        }
    }
}
