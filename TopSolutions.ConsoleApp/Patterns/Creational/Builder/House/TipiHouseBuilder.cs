using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Builder.House
{
    public class TipiHouseBuilder : IHouseBuilder
    {
        private House house;
        public TipiHouseBuilder(House house)
        {
            this.house = new House();
        }
        public void BuildBasement()
        {
            house.SetBasement("Wooden Poles");
        }
        public void BuildStructure()
        {
            house.SetStructure("Wood and Canvas");
        }
        public void BuildRoof()
        {
            house.SetRoof("Wood, caribou and seal skins");
        }
        public void BuildInterior()
        {
            house.SetInterior("Fireplace and Fur Rugs");
        }
        public House GetHouse()
        {
            return house;
        }
    }
}
