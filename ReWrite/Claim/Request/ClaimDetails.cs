using ReWrite.Contract.Claim;

namespace ReWrite.Claim.Request
{
    public class ClaimDetails : IRequestDetail
    {
        public string ChargeAmount {set;get;}

        public DateTime ServiceDate { set; get; }

        public string Provider { set; get; }

        public string ItemCode { set; get; }

        public string ItemType { set; get; }
    }
}
