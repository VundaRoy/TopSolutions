using Newtonsoft.Json;
using TopSolutions.WebApi.Model.WeatherForecast;

namespace TopSolutions.WebApi.Service
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private const string ApiKey = "YOUR_API_KEY";
        private const string BaseUrl = "http://api.openweathermap.org/data/2.5/weather";

        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<WeatherResponse> GetWeatherAsync(string city)
        {
            var response = await _httpClient.GetAsync($"{BaseUrl}?q={city}&appid={ApiKey}&units=metric");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<WeatherResponse>(content);
        }
    }
}
