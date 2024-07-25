using ReWrite.Model.Claims;

namespace ReWrite.Model.Contract
{
    public interface IRulesEngine
    {
        Service GetService(ServiceInput serviceInput);
        ServiceItem GetServiceItem(ServiceItemInput serviceItemInput);

    }
}
