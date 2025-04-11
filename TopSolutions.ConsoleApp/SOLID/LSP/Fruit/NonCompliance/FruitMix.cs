using System;
namespace TopSolutions.ConsoleApp.SOLID.LSP.Fruit.NonCompliance
{
    public class FruitMix
    {
        static void Main(string[] args)
        {
            Apple apple = new Orange();
            Console.WriteLine(apple.GetColor());
        }
    }
}