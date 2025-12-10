using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public class TotalitarianParty : PoliticalParty
    {
        public override void FormGovernment()
        {
            Console.WriteLine("Forming a government with absolute control...");
        }

        public override void HoldElection()
        {
            Console.WriteLine("Holding elections with predetermined outcomes...");
        }
        public override void Campaign()
        {
            base.Campaign();
            Console.WriteLine("Campaigning through propaganda...");
        }
        public override void RaiseFunds()
        {
            base.RaiseFunds();
            Console.WriteLine("Raising funds through state-controlled means...");
        }
    }
}
