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
                new () { Model = "Accord", Name = "Honda", Price = 28000, Maker = "Honda" },
                new () { Model = "Corolla", Name = "Toyota", Price = 20000, Maker = "Toyota" },
                new () { Model = "Model 3", Name = "Tesla", Price = 40000, Maker = "Tesla" },
                new () { Model = "F-150", Name = "Ford", Price = 50000, Maker = "Ford" },
                new () { Model = "Altima", Name = "Nissan", Price = 27000, Maker = "Nissan" },
                new () { Model = "Sentra", Name = "Nissan", Price = 22000, Maker = "Nissan" }
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
            //slice example to get the last 3 elements
            Console.WriteLine("Getting the last 3 elements of the span:");
            slicedCars.Clear();
            slicedCars = cars.Slice(cars.Length - 3, 3);
            foreach (var car in slicedCars)
            {
                Console.WriteLine($"Model: {car.Model}, Name: {car.Name}, Price: {car.Price}, Maker: {car.Maker}");

            }
            //Other slice uses
            //slice example to get the middle 3 elements
            Console.WriteLine("Getting the middle 3 elements of the span:");
            slicedCars.Clear();
            slicedCars = cars.Slice(1, 3);
            foreach (var car in slicedCars)
            {
                //check if not null
                if (car != null)
                {
                    Console.WriteLine($"Model: {car.Model}, Name: {car.Name}, Price: {car.Price}, Maker: {car.Maker}");
                }
                else
                {
                    Console.WriteLine("the car is null"); 
                }
            }
        }
    }
}
