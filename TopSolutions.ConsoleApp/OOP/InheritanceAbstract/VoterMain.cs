namespace TopSolutions.ConsoleApp.OOP.InheritanceAbstract
{
    public class VoterMain
    {
        static void Main(string[] args)
        {
            StateVoter state = new StateVoter();
            state.GetVoter(2, "Holden");
            Voter stateVoter = new Voter()
            {
                FirstName ="Diala",
                LastName = "Mboko",
                Location = 3,
                VoterId = 4
            };
            state.UpdateVoter(stateVoter);

            FederalVoter federal = new FederalVoter();
            Voter federalVoter = new Voter()
            {
                FirstName = "Apan",
                LastName = "Jaati",
                Location = 2,
                VoterId = 7
            };
            federal.GetVoter(2, "GDP", "OnemanOneVote");
            federal.UpdateVoter(federalVoter);
        }
    }
}
