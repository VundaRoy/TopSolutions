using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public class ReligousFundamentalistParty : PoliticalParty
    {
        public override void FormGovernment()
        {
            Console.WriteLine("Forming a government based on religious principles...");
        }
        public override void HoldElection()
        {
            Console.WriteLine("Holding elections with candidates adhering to religious values...");
        }
        public override void Campaign()
        {
            base.Campaign();
            Console.WriteLine("Campaigning through religious gatherings and sermons...");
        }
        public override void RaiseFunds()
        {
            base.RaiseFunds();
            Console.WriteLine("Raising funds through donations from religious followers...");
        }
    }
}
