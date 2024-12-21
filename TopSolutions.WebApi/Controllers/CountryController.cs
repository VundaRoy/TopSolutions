using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.Controllers
{
    public class CountryController : Controller
    {
        static List<Country> countryList = new List<Country>();
        // GET: CountryController
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult<IEnumerable<Country>>GetCountry()
        {
            return Ok(countryList); 
        }
        // GET: api/Country/5
        //[HttpGet("{id}")]
        //public ActionResult<Country> GetCountry(int id)
        //{
        //    var country = countryList.FirstOrDefault(s => s.CountryId == id);
        //    if (country == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(country);
        //}
        //// POST: api/Country
        //[HttpPost]
        //public ActionResult<Country> PostCountry(Country country)
        //{
        //    countryList.Add(country);
        //    return CreatedAtAction(nameof(GetCountry), new { id = country.CountryId }, country);
        //}
        // GET: CountryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CountryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CountryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CountryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CountryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CountryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
