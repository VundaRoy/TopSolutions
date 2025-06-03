using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.SOLID.DIP.Basic.DIPCompliant.Contract
{
    public interface IEmployeeOverseas
    {
        bool IsAForeignCountry(string country);
        double ProcessForeignPay(int EmployeeID, string country, double pay);
        void RegisterWithConsulate(int EmployeeID, string Country);
        void CheckVisaStatus(int EmployeeID);
    }
}
