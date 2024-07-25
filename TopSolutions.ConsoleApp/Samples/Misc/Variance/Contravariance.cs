using TopSolutions.ConsoleApp.Samples.Misc.Variance.Contracts;
using TopSolutions.ConsoleApp.Samples.Misc.Variance.Model;

namespace TopSolutions.ConsoleApp.Samples.Misc.Variance
{
    public class Contravariance : IExecute
    {
        IExecute _local;
        public Contravariance(IExecute local)
        {
            _local = local; 
        }
        public void Render()
        {
            //List<User> users = IExecute<T>//new List<Admin>();
            
            //List<Admin> admins = new List<User>();
        }

       

        public List<string> GetUsers()
        {
            return _local.GetType().GetProperties().Select(p=>p.Name).ToList();
        }
                

        void IExecute.PrintList(IEnumerable<User> entity)
        {
            throw new NotImplementedException();
        }
    }
}
