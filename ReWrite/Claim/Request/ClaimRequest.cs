using ReWrite.Contract.Claim;

namespace ReWrite.Claim.Request
{
    public class ClaimRequest : IRequestHeader
    {
        public ClaimRequest()
        {
           LineDetails = new List<ClaimDetails>();
        }
        public string ClaimType { get; set; }
        public string ClientNumber { get; set; }
        public string Location { get; set; }
        public string InRuleEnabled { get; set; }
     
        public List<ClaimDetails> LineDetails { get; set; }
    }
}
