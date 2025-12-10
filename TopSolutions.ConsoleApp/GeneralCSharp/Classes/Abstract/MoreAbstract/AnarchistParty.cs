using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Classes.Abstract.MoreAbstract
{
    public class AnarchistParty : PoliticalParty
    {
        public override void FormGovernment()
        {
            Console.WriteLine("Anarchist parties do not form governments.");
        }

        public override void HoldElection()
        {
            Console.WriteLine("Anarchist parties do not hold elections.");
        }
        public override void Campaign()
        {
            base.Campaign();
            Console.WriteLine("Campaigning through grassroots movements...");
        }
        public override void RaiseFunds()
        {
            base.RaiseFunds();
            Console.WriteLine("Raising funds through community donations...");
        }
    }
}
