using Microsoft.AspNetCore.Mvc;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CountriesController : ControllerBase
    {
        static List<Country> countryList = new(){
                new Country { CountryId = 1, CountryName = "Australia", CountryCode = "AU" },
                new Country { CountryId = 2, CountryName = "New Zealand", CountryCode = "NZ" },
                new Country { CountryId = 3, CountryName = "Canada", CountryCode = "CA" },
                new Country { CountryId = 4, CountryName = "United Kingdom", CountryCode = "UK" }
             };
       
        [HttpGet]
        public IActionResult GetCountries()
        {            
            return Ok(countryList);
        }
        // DELETE: api/Country/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCountry(int id)
        {
            var country = countryList.FirstOrDefault(s => s.CountryId == id);
            if (country == null)
            {
                return NotFound();
            }

            countryList.Remove(country);
            return NoContent();
        }
    }
}
