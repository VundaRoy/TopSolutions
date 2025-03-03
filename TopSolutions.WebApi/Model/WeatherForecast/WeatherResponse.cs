namespace TopSolutions.WebApi.Model.WeatherForecast
{
    public class WeatherResponse
    {
        public string Name { get; set; }
        public Temperature Temp { get; set; }
        public Weather[] Weather { get; set; }
    }
}
