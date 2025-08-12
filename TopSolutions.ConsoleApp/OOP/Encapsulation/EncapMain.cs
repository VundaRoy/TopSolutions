using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.OOP.Encapsulation
{
    public class EncapMain
    {
        static List<string> SugarMillManagers;
        static List<SugarMill> SugarMills;
        
        static void Main(string[] args)
        {
            //Setup managers
            EncapMain encapMain = new EncapMain();
            encapMain.SetupMillManagers();
            //Setup sugar mills 
            encapMain.SetupMills();
            SugarMills[0].SetMillManager(SugarMillManagers[0]);
            SugarMills[1].SetMillManager(SugarMillManagers[1]);

            Console.WriteLine($"The manager for {SugarMills[0].MillName} is {SugarMills[0].GetMillManager()}");
            Console.WriteLine($"The manager for {SugarMills[1].MillName} is {SugarMills[1].GetMillManager()}");
        }
        private void SetupMillManagers()
        {
            List<string> names = new () { "Galuinadi", "Pramod", "Barrack" };
            SugarMillManagers = new List<string>();
            foreach(string manager in names)
            {
                SugarMillManagers.Add(manager);
            }
        }
        private void SetupMills()
        {
            SugarMills = new();
            var sugar1 = new SugarMill() { Location = "Raki Raki", MillName = "Penang" };
            SugarMills.Add(sugar1);
            sugar1 = new SugarMill() { Location = "Ba", MillName = "Rarawai" };
            SugarMills.Add(sugar1);
            sugar1 = new SugarMill() { Location = "Lautoka", MillName = "Lautoka" };
            
        }
    }
}
