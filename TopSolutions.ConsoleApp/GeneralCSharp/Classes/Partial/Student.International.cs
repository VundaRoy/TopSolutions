namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Partial
{
    public class StudentBase
    {
        public string PassportID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ApplyOverseasScholarship()
        {
            Console.WriteLine("Eligibilty form for Overseas AUSAID application");
        }

        public void OverseasRegister()
        {
            Console.WriteLine("Overseas/International registry");
        }
    }
}