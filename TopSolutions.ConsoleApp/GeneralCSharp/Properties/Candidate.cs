using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopSolutions.ConsoleApp.GeneralCSharp.Properties
{
    public class Candidate
    {
        private int _CandidateId, _Age;
        private string _CandidateName, _PoliticalParty;

        public int CandidateId
        {
           set { _CandidateId = value; }
            get { return _CandidateId; }
        }
        public int Age
        {
            set { _Age = value; }
            get { return _Age; }
        }
        public string CandidateName
        {
            set { _CandidateName = value; }
            get { return _CandidateName; }
        }
        public string PoliticalParty
        {
            set { _PoliticalParty = value; }
            get { return _PoliticalParty; }
        }
    }
}
