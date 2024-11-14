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
            Student foreignStudent1 = new();
            foreignStudent1.ApplyOverseasScholarship();
            //NZ file
            Student nz = new Student();
            nz.RegisterNZCampus();
            nz.ApplyHecsAid();
        }
    }
}