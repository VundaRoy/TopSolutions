using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Prototype
{
    public class ContractEmployee : Employee
    {
        public int Wage { get; set; }
        public override Employee GetClone()
        {
            return (ContractEmployee)this.MemberwiseClone(); ;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Contract Employee");
            Console.WriteLine($" Name:{this.Name}, Department: {this.Department}, Type:{this.Type}, Wage: {this.Wage}\n");
        }
    }
}
