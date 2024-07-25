using TopSolutions.ConsoleApp.Samples.Misc.Variance.Contracts;
using TopSolutions.ConsoleApp.Samples.Misc.Variance.Model;

namespace TopSolutions.ConsoleApp.Samples.Misc.Variance
{
    public class Covariance : IExecute
    {
        IExecute _local;
        public Covariance()
        {

        }
        public Covariance(IExecute local)
        {
            _local = local;
        }

        List<Support> GetSupportUsers()
        {
            List<Support> supportList = new List<Support>()
             {
               new Support{IsSupervisor = true,
               Username = "jpaul",
               FirstName = "John",
               LastName = "Paul"},

               new Support{IsSupervisor = false,
               Username = "innocent",
               FirstName=  "Pope",
               LastName="Innocent" }
             };
            return supportList;
        }
        List<Supervisor> GetSupervisorUsers()
        {
            List<Supervisor> supers = new List<Supervisor>()
            {
             new Supervisor{
               FirstName ="Don",
               LastName ="Lemon",
               Username ="Dlemon",
               IsSupervisor = true,
               SupervisorCode = "ACV"
             },
             new Supervisor{
               FirstName ="Chris",
               LastName ="Tucker",
               Username ="CTucker",
               IsSupervisor = true,
               SupervisorCode = "ACV2"
             }
            };
            return supers;
        }
        public void Render()
        {

            IEnumerable<User> userSupportList = GetSupportUsers();

            _local.PrintList(userSupportList);


            IEnumerable<User> userSupervisorList = GetSupervisorUsers();
           
            _local.PrintList(userSupervisorList);


        }

        void IExecute.PrintList(IEnumerable<User> entity)
        {
            foreach (var user in entity)
            {
                Console.WriteLine(user.FirstName + " " + user.LastName + " " + user.Username);
            }
        }
    }
}
