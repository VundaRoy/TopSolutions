using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public class MarrickvilleLibrary : PublicLibrary
    {
        public override void OrganizeCommunityEvent(string eventName)
        {
            Console.WriteLine($"Organizing community event: {eventName} at Marrickville Library");
        }
    }
}
