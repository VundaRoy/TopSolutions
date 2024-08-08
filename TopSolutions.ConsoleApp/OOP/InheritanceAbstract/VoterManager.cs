using TopSolutions.ConsoleApp.OOP.InheritanceAbstract.Contract;

namespace TopSolutions.ConsoleApp.OOP.InheritanceAbstract
{
    public abstract class VoterManager : IVoterDetails
    {
        public VoterManager() { }
        public Voter GetVoter(int VoterId)
        {
            Voter voter = new Voter();
            Console.WriteLine("Voter " + VoterId + " is registered.");
            return voter;
        }
        public void UpdateVoter(Voter voter)
        {
            Console.WriteLine("Commence update of voter details");
        }
    }
}
