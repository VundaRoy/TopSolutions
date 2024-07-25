using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Misc.MyGen.Contract
{
    public interface IUniversalUser<T> where T : class
    {
        void Login(string userName, string password);
        string UserName { get; set; }
        string Password { get; set; }
        void ChangeProfile(string userName, string password);
        string SendEmail(string email);
    }
}
