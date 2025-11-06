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
            //Create instance of AbstractMain to run methods
            AbstractMain abstractMain = new AbstractMain();
            //Run SaaS related operations
            abstractMain.RunSaasRelatedOperations();
            //Run HR related operations
            abstractMain.RunHRRelatedOperations();
        }
        public void RunSaasRelatedOperations()
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
        }
        public void RunHRRelatedOperations()
        {
            //Create instance of HRcompany
            HRcompany hrStaff = new HRcompany();
            //Calculate bonus for HR Company staff
            hrStaff.CalculateBonus();
            //Promote HR Company staff
            hrStaff.Promote("HR Manager", 4000);
            //Terminate HR Company staff
            hrStaff.Terminate();
        }
    }
}
