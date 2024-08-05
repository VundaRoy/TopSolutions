﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TopSolutions.ConsoleApp.OOP.Classes;

namespace TopSolutions.ConsoleApp.OOP.Interface
{
    public interface ICreateRecipe
    {
        List<Ingredient> GetIngredients(Ingredient ingredient);
        void Method();       
    }
}