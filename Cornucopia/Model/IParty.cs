namespace Cornucopia.Model
{
    public interface IParty
    {
        int PartyId { get; }       
        string PartyName { get; }
        string PartyDescription { get; }
        string PartyType { get; }
        int PartyLeader {  get; }
        DateTime PartyFounded { get; }

    }
}
