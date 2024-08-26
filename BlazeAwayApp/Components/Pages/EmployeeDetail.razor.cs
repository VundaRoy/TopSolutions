using Microsoft.AspNetCore.Components;
using BlazeAwayApp.Domain;
using BlazeAwayApp.Services;

namespace BlazeAwayApp.Components.Pages
{
    public partial class EmployeeDetail : ComponentBase
    {
        [Parameter]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; } = new Employee();
        protected override void OnInitialized()
        {
            Employee = MockDataService.Employees.Single(e => e.EmployeeId == EmployeeId);
        }

        private void ChangeHolidayState()
        {
            Employee.IsOnHoliday = !Employee.IsOnHoliday;
        }
    }
}
