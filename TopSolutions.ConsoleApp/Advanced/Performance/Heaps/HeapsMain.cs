using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Heaps
{
    class HeapsMain
    {
        public static void Main(string[] args)
        {
            //Create a car as a heap example
            Car car = new Car("Model S", "Tesla", 80000); // Create a car object with model, maker, and price
            Console.WriteLine(car);
            Console.WriteLine($"The maker is {car.Maker}");
            //Struct example
            NumberOfDoorsAndWheels numberOfDoorsAndWheels = new NumberOfDoorsAndWheels(4, 4); // Create a struct object with number of doors and wheels
            Console.WriteLine(numberOfDoorsAndWheels);
            Console.WriteLine($"The number of doors is {numberOfDoorsAndWheels.NumberOfDoors}");
        }
        struct NumberOfDoorsAndWheels
        {
            public int NumberOfDoors { get; set; }
            public int NumberOfWheels { get; set; }
            public NumberOfDoorsAndWheels(int numberOfDoors, int numberOfWheels)
            {
                NumberOfDoors = numberOfDoors;
                NumberOfWheels = numberOfWheels;
            }
        }
    }
}
