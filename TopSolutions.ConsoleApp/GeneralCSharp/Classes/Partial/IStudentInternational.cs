using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public interface IStudentInternational
    {
        string FirstName { set; get; }
        string LastName { set; get; }
        string PassportID {  set; get; }
    }
}
