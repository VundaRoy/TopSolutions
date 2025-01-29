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

            Vehicle v1 = new() { Description = "Sedan", Make="Elantra", Name="Nissan", Year="2005" };
            Vehicle v2 = new() { Description ="Hatchback", Make ="Mazda", Name="Uzi", Year="2009"};
            Vehicle v3 = new() { Description = "AWD", Make = "Toyota", Name = "Hylux", Year = "2011" };

            Person p2 = new () { Id=2, Age = 34, Name="Forbes Milton", Description="Salary man"};
            Person p3 = new() { Id = 10, Age = 41, Name = "Nelson Mandelson", Description = "Politician" };
            Person p4 = new() { Id = 11, Age = 47,Name = "Milton Obote", Description= "Politician" };
            Device d1 = new() { DeviceId = 1, DeviceDescription = "Fridge", DeviceName = "Coolie" };
            Device d2 = new() { DeviceId = 2, DeviceDescription = "Watch", DeviceName = "Timer" };
            object[] mixedTypes = new object[10];
            mixedTypes[0] = v1;
            mixedTypes[1] = p2;
            mixedTypes[2] = p3;
            mixedTypes[3] = v2;
            mixedTypes[4] = v3;
            mixedTypes[5] = p4;
            mixedTypes[6] = d1;
            mixedTypes[7] = d2;

            foreach (var mx in mixedTypes) 
            { 
               // Console.WriteLine(mx);
                if (mx is Person person)
                {
                    Console.WriteLine($"The person is {person.Name} who is aged {person.Age}");
                }
                else if(mx is Vehicle vehicle)
                {
                    Console.WriteLine($"The vehicle is a {vehicle.Make} and year is {vehicle.Year}");
                }
                else if(mx is Device device)
                {
                    Console.WriteLine($"The device is a {device.DeviceDescription} and is called {device.DeviceName}");
                }
            }

        }
    }
}
