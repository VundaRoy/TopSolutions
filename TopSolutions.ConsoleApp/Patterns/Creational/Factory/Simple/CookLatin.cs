﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple.Contract;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Factory.Simple
{
    public class CookLatin : ICook
    {
        public CookLatin()
        {
            Console.WriteLine("Welcome to Latino cuisine");
        }

        public void CookFood(string ingredient)
        {
            Console.WriteLine($"Boil beans first and then {ingredient}");
        }

        public void GetIngredients()
        {
            Console.WriteLine("Add salsa sauce and habichuelas");
        }

        public void PrepareIngredients()
        {
            Console.WriteLine("Throw in some onion and lime");
        }

        public void ServerFood()
        {
            Console.WriteLine("Serve on large plate");
        }
        public string GetProfile(string name)
        {
            return "Latin cook";
        }
    }
}
