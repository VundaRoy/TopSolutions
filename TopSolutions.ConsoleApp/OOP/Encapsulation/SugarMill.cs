using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Encapsulation
{
    public class SugarMill
    {
        public string MillName { get; set; }
        public string Location { get; set; }

        private string manager;
        private string Manager 
        { 
            get { return manager; } 
            set { manager = value; } 
        }
        public string GetMillManager() { return Manager; }
        public void SetMillManager(string value)
        {
            Manager = value;
        }

    }
}
