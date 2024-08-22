using BlazeAwayApp.Services;
using BlazeAwayApp.Domain;

namespace BlazeAwayApp.Components.Pages
{
    public partial class EmployeeOverview
    {
        public List<Employee> Employees { get; set; } = default!;
        protected async override Task OnInitializedAsync()
        {
            Employees = MockDataService.Employees;
        }
    }
}
