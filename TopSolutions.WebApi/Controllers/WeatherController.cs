using Microsoft.AspNetCore.Mvc;
using TopSolutions.WebApi.Service;

namespace TopSolutions.WebApi.Controllers
{
    public class WeatherController : Controller
    {

        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        public async Task<IActionResult> Index(string city = "Sydney")
        {
            var weather = await _weatherService.GetWeatherAsync(city);
            return View(weather);
        }

    }
}
