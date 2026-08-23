using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Memory
{
    internal class ReadOnlyMemoryMain
    {
        public static void Main(string[] args)
        {
            ReadOnlyMemory<Car> cars = CreateCarMemory();
            Console.WriteLine("ReadOnlyMemory of Car objects:");
            foreach (var car in cars.Span)
            {
                Console.WriteLine($"Model: {car.Model}, Name: {car.Name}, Price: {car.Price}, Maker: {car.Maker}");
            }
            //prompt to get nth element from the ReadOnlyMemory
            Console.WriteLine("Enter the index of the car you want to retrieve (0-9):");
            //Read the index from the console
            var index = int.Parse(Console.ReadLine());
            Console.WriteLine("Car at index {0}: Model: {1}, Name: {2}, Price: {3}, Maker: {4}", 
                      index, cars.Span[index].Model, cars.Span[index].Name, cars.Span[index].Price, cars.Span[index].Maker);
        }

        private static ReadOnlyMemory<Car> CreateCarMemory()
        {
            //Create a ReadOnlyMemory of Car objects
            return new Car[]
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
        }
                
    }
}
