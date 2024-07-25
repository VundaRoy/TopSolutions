using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.Samples.Patterns.Primera
{
    public class Trustee : IBank
    {
        public int TrusteeId { get; set; }
        public string TrusteeName { get; set; } = string.Empty;
        public void AddBank(IBank bank)
        {
            Console.WriteLine("my trusteeship");
        }

        public void DeleteBank(IBank bank)
        {
            throw new NotImplementedException();
        }

        public void UpdateBank(IBank bank)
        {
            Console.WriteLine("update trust");
        }
    }
}
