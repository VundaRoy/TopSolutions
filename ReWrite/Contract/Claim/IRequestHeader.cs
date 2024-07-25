using System.Security.Claims;

namespace ReWrite.Contract.Claim
{
    public interface IRequestHeader
    {
        string ClaimType { get; set; }
        string ClientNumber { get; set;}
        string Location { get; set;}
        string InRuleEnabled { get; set;}   
    }
}
