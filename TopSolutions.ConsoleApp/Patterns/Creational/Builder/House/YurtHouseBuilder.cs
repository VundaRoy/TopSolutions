using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.House
{
    public class YurtHouseBuilder : IHouseBuilder
    {
        private House house;
        public YurtHouseBuilder()
        {
            this.house = new House();
        }
        public void BuildBasement()
        {
            house.SetBasement("Wooden Poles");
        }
        public void BuildStructure()
        {
            house.SetStructure("Wood and Fabric");
        }
        public void BuildRoof()
        {
            house.SetRoof("Fabric and Insulation");
        }
        public void BuildInterior()
        {
            house.SetInterior("Carpeted Floor and Low Furniture");
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
