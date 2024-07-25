using ReWrite.Claim.Request;
using ReWrite.Contract.Claim;

namespace ReWrite.Claim
{
    public abstract class BaseClaim : IClaim
    {
        public List<Service> GetService(ClaimDetails request)
        {
            var serviceList = new List<Service>();
            Service service = new()
            {
                ServiceDate = request.ServiceDate
            };
            serviceList.Add(service);
            return serviceList;
        }
        public List<ServiceItem> GetServiceItems(ClaimDetails request)
        {
            var serviceItemList = new List<ServiceItem>();
            ServiceItem serviceItem = new()
            {
                ItemCode = request.ItemCode,
                ItemType = request.ItemType
            };
            serviceItemList.Add(serviceItem);
            return serviceItemList;
        }

    }
}
