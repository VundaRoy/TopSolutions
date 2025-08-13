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
            //Assign managers to mills
            encapMain.AssignManagersToMills();
            //Show all mills and their managers
            for(int i = 0; i < SugarMills.Count; i++)
            {
                Console.WriteLine($"The manager for {SugarMills[i].MillName} is {SugarMills[i].GetMillManager()}");
            }
            
        }
        private void SetupMillManagers()
        {
            List<string> names = new () { "Galuinadi", "Pramod", "Barrack", "Gonelevu", "RamLakhan","Sivathamby P" };
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
            SugarMills.Add(sugar1);
            sugar1 = new SugarMill() { Location = "Labasa", MillName = "Labasa" };
            SugarMills.Add(sugar1);
            sugar1 = new SugarMill() { Location = "Sigatoka", MillName = "Sigatoka" };
            SugarMills.Add(sugar1);
            sugar1 = new SugarMill() { Location = "Seaqaqa", MillName = "Seaqaqa" };
            SugarMills.Add(sugar1);
        }
        private void AssignManagersToMills()
        {
            int i = 0;
            foreach(var mill in SugarMills)
            {
                mill.SetMillManager(SugarMillManagers[i]);
                i++;
            }
        }
    }
}
