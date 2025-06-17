namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public class DemoBaseMain
    {
        public static void Main(string[] args)
        {
            Student s = new();
            s.LocalRegistration();
            s.OverseasRegister();
            s.ApplyHecsAid();
            s.RegisterSubject("forbes123");
            Student foreignStudent1 = new();
            foreignStudent1.ApplyOverseasScholarship();
            foreignStudent1.RegisterSubject("am123");
            //NZ file
            Student nz = new();
            nz.RegisterNZCampus();
            nz.ApplyHecsAid();
            nz.RegisterSubject("nzStd112");
            Demo demo = new();
            demo.TestCreateStudentDetails("freitag");
        }
    }
}