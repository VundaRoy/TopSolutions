using TopSolutions.WebApi.Model;

namespace TopSolutions.WebApi.Service
{
    public class WeatherService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey = "";
        public WeatherService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<WeatherInfo> GetWeatherAsync(string city)
        {
            var url = $"https://api.openweathermap.org/data/2.5/weather?q={city}&appid={_apiKey}&units=metric";
            var response = await _httpClient.GetFromJsonAsync<JsonElement>(url);
            return new WeatherInfo
            {
                City = response.GetProperty("name").GetString(),
                TempMin = response.GetProperty("main").GetProperty("temp_min").GetDouble(),
                TempMax = response.GetProperty("main").GetProperty("temp_max").GetDouble(),
                Description = response.GetProperty("main").GetProperty("weather")[0].GetProperty("description").GetString()
            };
        }
    }
}
