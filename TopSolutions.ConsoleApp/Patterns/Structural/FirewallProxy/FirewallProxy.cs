using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Patterns.Structural.FirewallProxy
{
    public class FirewallProxy : ISubject
    {
        private RealSubject _realSubject;
        private List<string> _bannedSites;
        public FirewallProxy()
        {
            _bannedSites = new List<string> { "badsite.com", "malicious.com", "gotcha.com", "youLose.com" };
        }
        public void Request(string site)
        {
            if (IsRequestValid(site))
            {
                if (_realSubject == null)
                    _realSubject = new RealSubject();
                _realSubject.Request(site);
            }
            else
            {
                Console.WriteLine("FirewallProxy: Access Denied!");
            }
        }
        private bool IsRequestValid(string siteRequest)
        {
            // Just for the sake of this example, let's imagine we are checking a website domain.
            if (!string.IsNullOrEmpty(siteRequest))
            {
                return !_bannedSites.Contains(siteRequest);
            }
            
            return false;
        }
    }
}
