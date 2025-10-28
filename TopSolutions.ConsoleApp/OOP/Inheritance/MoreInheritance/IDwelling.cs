using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.MoreInheritance
{
    public interface IDwelling
    {
        public int NumberOfRooms { get; set; }
        public void Enter();
        public void Exit();
        public double CalculateArea();
        public string GetAddress();
    }
}
