using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Encapsulation
{
    public class EncapMain
    {
        static void Main(string[] args)
        {
            List<SugarMill> mills = new List<SugarMill>();
            MillStaff millStaff = new()
            {
                StaffName = "Sir Galuinadi"
            };
            millStaff.SetStaffType(2);
            Console.WriteLine(millStaff.GetStaffType());
            
            SugarMill sugarMill = new()
            {
                MillName = "Rarawai",
                Location = "Ba"
            };
            mills.Add(sugarMill);
            sugarMill = new()
            {
                MillName = "Lautoka",
                Location = "Lautoka"
            };
            mills.Add(sugarMill);


        }
    }
}
