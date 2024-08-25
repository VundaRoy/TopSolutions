using BlazeAwayApp.Services;
using BlazeAwayApp.Domain;

namespace BlazeAwayApp.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        protected async override Task OnInitializedAsync()
        {
            //await Task.Delay(2000);
            Employees = MockDataService.Employees;
        }
    }
}
