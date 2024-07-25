using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.MyGen.Model
{
    public class SuperUser<T> : UniversalUser<T> where T : class
    {
        public void ManageUsers(string userName, string superUserCode)
        {
            Console.WriteLine("Managing users with "+ userName +"and using code as "+superUserCode);
        }
        public void RenderSuper()
        {

        }
    }
}
