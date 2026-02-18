using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Composite.Sample
{
    // This is going to be a class that represents the Composite Component. 
    // A Composite Object is an Object which has Child Component. 
    // The Children Component Can be a Leaf Object or Can be another Composite Object
    // The Composite object delegate the actual work to their children and then combines the result.
    public class Composite : Component
    {
        //The Following ChildComponents variable is going to hold all the child components of a composite object
        private List<Component> ChildComponents = new();
        //The Constructor takes the Composite Component name as the input parameter 
        //and passed that parameter value to the base class constructor
        public Composite(string name, string address, string region) : base(name, address, region)
        {
        }

        //The following Method is used to add Child Components inside the Composite Component
        public void AddComponent(Component[] NewComponent)
        {
            foreach (var component in NewComponent)
                ChildComponents.Add(component);
        }
        //The following Method is used to Remove Child Components from the Composite Component
        public void RemoveComponent(Component RemoveComponent)
        {
            ChildComponents.Remove(RemoveComponent);
        }
        //Override the Component class GetSalary Method
        public override int GetSalary()
        {
            //int TotalSalary = 0;
            //foreach (var component in ChildComponents)
            //{
            //    var salary = component.GetSalary();
            //    TotalSalary += salary;
            //}
            //return TotalSalary;
            // Summarizing the Salary of all children
            return ChildComponents.Sum(x => x.GetSalary());
        }
    }
}
