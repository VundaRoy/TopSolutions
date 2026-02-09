using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.Proxy.ManageUserAccess
{
    public class ManageAccessMain
    {
        public static void Main(string[] args)
        {
            // Create the proxy
            ManageAccessProxy proxy = new ();
            //Grant access to a user
            proxy.GrantAccess("Alice");
            //Grant access to another user
            proxy.GrantAccess("Bob");
            //Display the access list
            proxy.DisplayAccessList();
            //Deny access to a user
            proxy.DenyAccess("Alice");
        }
    }
}
