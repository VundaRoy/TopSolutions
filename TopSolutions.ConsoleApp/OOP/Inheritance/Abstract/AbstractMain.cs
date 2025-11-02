using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Inheritance.Abstract
{
    public class AbstractMain
    {
        public static void Main()
        {
            //Create instance of SaasCompany
            SaasCompany saasStaff = new SaasCompany();
            //Calculate bonus for SaaS Company staff
            saasStaff.CalculateBonus();
            //Display SaaS Company staff info
            saasStaff.DisplaySaasInfo();
            //Promote SaaS Company staff
            saasStaff.Promote("Senior Developer", 5000);
            //Terminate SaaS Company staff
            saasStaff.Terminate();
            //Create instance of EToroTraders
            EToroTraders etoroTrader = new EToroTraders();
            //Calculate bonus for eToro Trader
            etoroTrader.CalculateBonus();
            //Promote eToro Trader
            etoroTrader.Promote("Senior Trader", 7000);
            //Terminate eToro Trader - this will call the sealed method from SaasCompany
            etoroTrader.Terminate();
        }
    }
}
