using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.Variance.Model
{
    public class Admin : User
    {
        public bool IsSiteEditor { get; set; }
        public bool IsSuperUser { get; set; }
    }
}
