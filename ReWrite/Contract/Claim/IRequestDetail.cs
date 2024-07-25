namespace ReWrite.Contract.Claim
{
    public interface IRequestDetail
    {
        string ChargeAmount { get; }
        DateTime ServiceDate { get; }
        string Provider { get; }
        string ItemCode { get; }
        string ItemType { get; }
    }
}
