namespace Cornucopia.Model
{
    public class Party : IParty
    {
        public int PartyId { get; set; }

        public string PartyName { get; set; }

        public string PartyDescription { get; set; }

        public string PartyType { get; set; }

        public int PartyLeader { get; set; }

        public DateTime PartyFounded { get; set; }

        public Party()
        {
            
        }
        
    }
}
