using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Span.TypeOf
{
    public class SliceOfCarMain
    {
        public static void Main(string[] args)
        {
            //Create a span of Car objects
            Span<Car> cars = new Car[]
            {
                new () { Model = "Model S", Name = "Tesla", Price = 80000, Maker = "Tesla" },
                new () { Model = "Mustang", Name = "Ford", Price = 55000, Maker = "Ford" },
                new () { Model = "Civic", Name = "Honda", Price = 25000, Maker = "Honda" },
                new () { Model = "Camry", Name = "Toyota", Price = 30000, Maker = "Toyota" },
                new () { Model = "Accord", Name = "Honda", Price = 28000, Maker = "Honda" }
            };
            Console.WriteLine("Span of Car objects:");
            foreach (var car in cars)
            {
                Console.WriteLine($"Model: {car.Model}, Name: {car.Name}, Price: {car.Price}, Maker: {car.Maker}");
            }
            //Slice the span to get the first 3 elements
            Span<Car> slicedCars = cars.Slice(0, 3);
            Console.WriteLine("Sliced span of Car objects:");
            foreach (var car in slicedCars)
            {
                Console.WriteLine($"Model: {car.Model}, Name: {car.Name}, Price: {car.Price}, Maker: {car.Maker}");
            }
        }
    }
}
