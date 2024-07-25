using TopSolutions.ConsoleApp.Samples.Misc.MyGen.Contract;

namespace TopSolutions.ConsoleApp.Samples.Misc.MyGen.Model
{
    public class UniversalUser<T> : IUniversalUser<T> where T : class
    {
        public string UserName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void ChangeProfile(string userName, string password)
        {
            Console.WriteLine("Changed profile for "+userName);
        }

        public void Login(string userName, string password)
        {
            Console.WriteLine("Logged in as " + userName);
        }

        public string SendEmail(string email)
        {
            string content = "Send by " + email;
            return content;
        }
    }
}
