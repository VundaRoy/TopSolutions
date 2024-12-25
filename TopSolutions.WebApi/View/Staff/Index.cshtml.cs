
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.View.StaffView
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
