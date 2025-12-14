using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public class UniversityOfTechnologySydneyLibrary : UniversityLibrary
    {
       
        //override other abstract methods if any
        public override void ConductResearch(string topic)
        {
            Console.WriteLine($"Conducting research on: {topic} in UTS Library");
        }
        public override void CheckStudentEligibility(string studentName)
        {
            Console.WriteLine($"Checking eligibility for student: {studentName} in UTS Library");
        }
    }
}
