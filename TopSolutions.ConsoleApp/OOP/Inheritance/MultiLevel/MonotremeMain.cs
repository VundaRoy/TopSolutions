using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class MonotremeMain
    {
        public static void Main()
        {
            Platypus platypus = new Platypus();
            platypus.LayEggs();
            platypus.HaveBill();
            platypus.Electroreception();
            platypus.NurseYoung();
            platypus.Walk();
            platypus.MakeSound();
            platypus.Sleep();
            platypus.Eat();
        }
    }
}
