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

            Vehicle v1 = new Vehicle();
            Person p2 = new Person();
            object[] mixedTypes = new object[2];
            mixedTypes[0] = v1;
            mixedTypes[1] = p2;

            foreach (var mx in mixedTypes) 
            { 
                Console.WriteLine(mx);
            }

        }
    }
}
