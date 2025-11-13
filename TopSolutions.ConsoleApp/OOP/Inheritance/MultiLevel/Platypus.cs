using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MultiLevel
{
    public class Platypus : IMonotreme
    {
        public void Eat()
        {
            Console.WriteLine("Platypus is eating.");
        }

        public void Electroreception()
        {
            Console.WriteLine("detection in aquatic environment");
        }

        public void HaveBill()
        {
            Console.WriteLine("Platypus has a duck-bill.");
        }

        public void LayEggs()
        {
            Console.WriteLine("Platypus lays eggs.");
        }

        public void MakeSound()
        {
            Console.WriteLine("Platypus makes a low growl sound.");
        }

        public void NurseYoung()
        {
            Console.WriteLine("Platypus nurses its young.");
        }

        public void Sleep()
        {
            Console.WriteLine("Platypus is sleeping.");
        }

        public void Walk()
        {
            Console.WriteLine("Platypus is walking.");
        }
    }
}
