using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Facade.Basic
{
    public class Product
    {
        // Subsystem 1
        // The Subsystem can accept requests either from the facade or from the client directly. 
        // In this case, from the Subsystem, the Facade is also a client
        // Facade is not a part of the Subsystem.
        public void GetProductDetails()
        {
            Console.WriteLine("Fetching the Product Details");
        }
    }
}
