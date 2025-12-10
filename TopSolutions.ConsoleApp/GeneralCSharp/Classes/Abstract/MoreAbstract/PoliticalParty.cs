using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public abstract class PoliticalParty
    {
        //Basic party information
        public string Name { get; set; }
        public string Leader { get; set; }
        public int FoundedYear { get; set; }
        //Common party functionalities
        
        public abstract void HoldElection();
        public abstract void FormGovernment();
        public virtual void Campaign()
        {
            Console.WriteLine("Campaigning for votes...");
        }
        public virtual void RaiseFunds()
        {
            Console.WriteLine("Raising funds for the party...");
        }
    }
}
