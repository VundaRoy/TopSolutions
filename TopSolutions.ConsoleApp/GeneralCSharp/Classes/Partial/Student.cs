using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public partial class Student : IStudentLocal
    {
        private string _nationalID;
        public string FirstName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string NationalID { get => _nationalID; set => _nationalID = value; }

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
        public void RegisterSubject(string NationalId)
        {
            Console.WriteLine($"Student with national ID of {NationalId} is now registered with subjects ");
        }
    }
    public class Demo : DemoBaseMain
    {
    }
}
