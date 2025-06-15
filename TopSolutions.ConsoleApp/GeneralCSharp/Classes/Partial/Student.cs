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
        private string _firstName;
        private string _lastName;
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
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
        public void TestCreateStudentDetails(string studentID)
        {
            Console.WriteLine($"The student {studentID} is being created...");
        }
    }
}
