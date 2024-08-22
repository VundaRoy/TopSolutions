using BlazeAwayApp.Components.Pages;
using BlazeAwayApp.Domain;

namespace BlazeAwayApp.Services
{
    public class MockDataService
    {
        private static List<Employee>? _employees = default!;
        private static List<JobCategory>? _jobCategories = default!;
        private static List<Country>? _countries = default!;

        public static List<Employee>? Employees
        {
            get
            {
                _employees ??= InitializeMockEmployees();
                _countries ??= InitializeMockCountries();
                _jobCategories ??= InitializeMockJobCategories();
                return _employees;

            }
        }
        private static List<Employee> InitializeMockEmployees()
        {
            List<Employee> employees = new List<Employee>();
            var employee = new Employee 
            { 
                BirthDate = new DateTime(1980, 2, 11),
                City = "San Salvador",
                FirstName = "Alfredo",
                LastName = "Alfonso",
                EmployeeId = 1
            };
            employees.Add(employee);
            return employees;
        }
        private static List<Country> InitializeMockCountries()
        {
            List<Country> countries = new List<Country>();
            return countries;
        }
        private static List<JobCategory> InitializeMockJobCategories()
        {
            List<JobCategory> jobCategories = new List<JobCategory>();
            return jobCategories;
        }
    }
}
