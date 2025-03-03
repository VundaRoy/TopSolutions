using Microsoft.AspNetCore.Mvc;
using TopSolutions.WebApi.Service;

namespace TopSolutions.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherController : ControllerBase
    {
        private readonly WeatherService _weatherService;

        public WeatherController(WeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [HttpGet("{city}")]
        public async Task<IActionResult> GetWeather(string city)
        {
            var weather = await _weatherService.GetWeatherAsync(city);
            if (weather == null)
            {
                return NotFound();
            }

            var result = new
            {
                City = weather.Name,
                Forecast = weather.Weather[0].Description,
                MaxTemp = weather.Temp.MaximumTemperature,
                MinTemp = weather.Temp.MinimumTemperature
            };

            return Ok(result);
        }
    }
}
