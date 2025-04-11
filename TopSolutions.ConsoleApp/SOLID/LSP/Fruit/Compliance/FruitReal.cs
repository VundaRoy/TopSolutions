using System;
namespace TopSolutions.ConsoleApp.SOLID.LSP.Fruit.Compliance
{
    public class FruitReal
    {
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            Console.WriteLine($"Color of Orange: {fruit.GetColor()}");
            fruit = new Apple();
            Console.WriteLine($"Color of Apple: {fruit.GetColor()}");
            Console.ReadKey();
            //Apple apple = new Orange(); not allowed
        }
    }
}