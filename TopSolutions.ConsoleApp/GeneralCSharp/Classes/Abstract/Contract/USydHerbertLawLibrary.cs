using System;
using System.Collections.Generic;
using System.Text;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.Contract
{
    public class USydHerbertLawLibrary : UniversityLibrary
    {
        public override void ConductResearch(string topic)
        {
            Console.WriteLine($"Conducting research on: {topic} in   of Sydney Herbert Law Library");
        }
        public override void CheckStudentEligibility(string studentName)
        {
            Console.WriteLine($"Checking eligibility for student: {studentName} in University of Sydney Herbert Law Library");
        }
        public void OrganizeLegalSeminar(string seminarName)
        {
            Console.WriteLine($"Organizing legal seminar: {seminarName} in University of Sydney Herbert Law Library");
        }

    }
}
