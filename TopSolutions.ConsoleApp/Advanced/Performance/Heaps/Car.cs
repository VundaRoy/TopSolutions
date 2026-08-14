using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.Advanced.Performance.Heaps
{
    //A car object to be used as an example for a heap data structure
    public class Car
    {
        public int Price { get; set; }
        public string Model { get; set; }
        public string Maker { get; set; }
        public Car(string model, string maker, int price) 
        {
            Model = model;
            Maker = maker;
            Price = price;
        }       

    }
}
