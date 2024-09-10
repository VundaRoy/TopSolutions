using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Arrays
{
    public class ArrayMain
    {
        static void Main(string[] args)
        {
            Person[] p1 = new Person[3];
            p1[0] = new Person() { Id = 1, Name = "Jane", Age = 32, Description = "Millen" };
            p1[1] = new Person() { Id = 2, Name = "Job", Age = 55, Description = "Gen x" };
            p1[2] = new Person() { Id = 3, Name = "Bob Jane", Age = 89, Description = "Silent" };

            foreach (Person p in p1) 
            { 
                Console.WriteLine(p.Name);
            }

            //array of classes

            Vehicle v1 = new() { Description = "Sedan", Make="Elantra", Name="Nissan", Year="2005"};
            Person p2 = new () { Id=2, Age = 34, Name="Forbes Milton", Description="Salary man"};
            Person p3 = new() { Id = 10, Age = 41, Name = "Nelson Mandelson", Description = "Politician" };
            object[] mixedTypes = new object[3];
            mixedTypes[0] = v1;
            mixedTypes[1] = p2;
            mixedTypes[2] = p3;

            foreach (var mx in mixedTypes) 
            { 
                Console.WriteLine(mx);
                if (mx is Person person)
                {
                    Console.WriteLine(person.Name + " is aged "+ person.Age);
                }
            }

        }
    }
}
