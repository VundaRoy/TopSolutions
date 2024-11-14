using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public partial class Student : IStudentLocal
    {
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NationalID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ApplyHecsAid()
        {
            Console.WriteLine("Eligibilty form for Local HECS application");
        }

        public void LocalRegistration() 
        {
            Console.WriteLine("Local register");
        }
    }
    public partial class Student : StudentBase, IStudentInternational
    {
    }
    public class Demo : DemoBaseMain
    {
    }
}
