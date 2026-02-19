using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Plant
{
    public class PlantCompositeMain
    {
        public static void Main()
        {
            var plants = new List<IPlant>();
            var branch = new Branch(new List<IPlant>() { new Leaf(), new Leaf() });
            var anotherBranch = new Branch(new List<IPlant> { new Leaf(), new Leaf(), new Leaf() });
            plants.Add(new Branch(new List<IPlant>() { branch, anotherBranch }));

            plants.Add(new Leaf());
            plants.Add(new Branch(new List<IPlant>() { new Leaf(), new Leaf(), new Leaf(), new Leaf() }));
            plants.Add(new Leaf());

            foreach (IPlant plant in plants)
            {
                plant.Eat();
            }
        }
    }
}
