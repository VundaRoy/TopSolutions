using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TopSolutions.ConsoleApp.Patterns.Structural.Proxy.ManageUserAccess
{
    public class ManageAccessProxy : IManageAccess
    {
      
        private List<string> accessList;
        public ManageAccessProxy()
        {
           
            accessList = new List<string>();
        }
        public void GrantAccess(string user)
        {
            if (!accessList.Contains(user))
            {
                accessList.Add(user);
                Console.WriteLine($"Granted access to {user}");
            }
            else
            {
                Console.WriteLine($"{user} already has access");
            }
        }
        public void DenyAccess(string user)
        {
            if (accessList.Contains(user))
            {
                accessList.Remove(user);
                Console.WriteLine($"Denied access to {user}");
            }
            else
            {
                Console.WriteLine($"{user} does not have access");
            }
        }
        public void DisplayAccessList()
        {
            Console.WriteLine("Current Access List:");
            foreach (var user in accessList)
            {
                Console.WriteLine(user);
            }
        }
    }
}
