using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Contravariance.Sample
{
    public class DerivedClass : BaseClass
    {
        public DerivedClass() : base() { }
        public DerivedClass(string name) : base(name) { }
        public string AdditionalProperty { get; set; }
    }
}
