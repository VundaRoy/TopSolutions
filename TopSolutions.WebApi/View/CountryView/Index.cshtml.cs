using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.View.CountryView
{
    public class IndexModel : PageModel
    {
        public List<Country> Countries { get; set; }
        public void OnGet()
        {
            Countries = new List<Country> {
            new Country { CountryId=1, CountryCode="us", CountryName="United States"},
            new Country { CountryId = 2, CountryCode = "au", CountryName = "Australia" },
            new Country { CountryId = 3, CountryCode ="nz", CountryName = "New Zealand" }
            };
        }
    }
}
