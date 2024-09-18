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
        public void LocalRegistration() 
        {
            Console.WriteLine("Local register");
        }
    }
    public partial class Student : IStudentInternational
    {
        public string PassportID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public void OverseasRegister()
        {
            Console.WriteLine("Overseas/International registry");
        }
    }
    public class Demo
    {
        public static void Main(string[] args)
        {
            Student s = new Student();
            s.LocalRegistration();
            s.OverseasRegister();
        }
    }
}
