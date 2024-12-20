using TopSolutions.WebApi.Model;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TopSolutions.WebApi.View.Staff
{
    public class IndexModel : PageModel
    {
        public List<Staff> StaffList { get; set; }
        public void OnGet()
        {
            StaffList = new List<Staff>
            {
                new Staff { StaffId = 1, UserName = "jdoe", FirstName = "John", LastName = "Doe", Email = "jdoe@example.com" },
                new Staff { StaffId = 2, UserName = "asmith", FirstName = "Anna", LastName = "Smith", Email = "asmith@example.com" }
            };
        }
    }
}
