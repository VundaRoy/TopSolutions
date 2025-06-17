using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public partial class Student : IStudentLocal
    {
        public void RegisterNZCampus()
        {
            Console.WriteLine("Registering NZ campus");
        }
        //public void ApplyHecsAid()   //Student already defines member
        //{
        //    Console.WriteLine("Do something");
        //}
    }
}
