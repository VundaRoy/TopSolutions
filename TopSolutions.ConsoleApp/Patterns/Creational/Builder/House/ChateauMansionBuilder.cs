using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.House
{
    public class ChateauMansionBuilder : IHouseBuilder
    {
        private House house;
        public ChateauMansionBuilder()
        {
            this.house = new House();
        }
        public void BuildBasement()
        {
            house.SetBasement("Stone Basement");
        }
        public void BuildStructure()
        {
            house.SetStructure("Stone and Marble Structure");
        }
        public void BuildRoof()
        {
            house.SetRoof("Slate Roof");
        }
        public void BuildInterior()
        {
            house.SetInterior("Luxury Interior");
        }
        public House GetHouse()
        {
            return house;
        }
    
    }
}
