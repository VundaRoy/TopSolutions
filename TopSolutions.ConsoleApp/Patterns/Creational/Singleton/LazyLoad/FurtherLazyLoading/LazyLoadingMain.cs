using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Creational.Singleton.LazyLoad.FurtherLazyLoading
{
    public class LazyLoadingMain
    {
        public static void Main()
        {
            //Lazy load register candidate singleton instance
            RegisterCandidate registerCandidate = RegisterCandidate.Instance;
            //Create another candidate instance
            RegisterCandidate anotherRegisterCandidate = RegisterCandidate.Instance; //Will point to the same instance as registerCandidate
        }
    }
}
