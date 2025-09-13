// This is the main entry point for the ASP.NET Core Minimal API.
// It sets up the web application and defines the API endpoints.

// Use the WebApplication.CreateBuilder to configure services.
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// We are adding HttpClient to make HTTP requests to the external weather API.
builder.Services.AddHttpClient();

// Add CORS policy to allow the HTML page to fetch data from the API.
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyHeader()
                  .AllowAnyMethod();
        });
});

// Build the application.
var app = builder.Build();

// Enable CORS middleware.
app.UseCors();

// Define a list of cities with their coordinates (latitude and longitude).
// This data would typically come from a database, but we hardcode it for this simple example.
var cities = new Dictionary<string, (double Latitude, double Longitude)>
{
    { "New York", (40.7128, -74.0060) },
    { "London", (51.5074, -0.1278) },
    { "Tokyo", (35.6895, 139.6917) },
    { "Sydney", (-33.8688, 151.2093) },
    { "Paris", (48.8566, 2.3522) }
};

// Define the API endpoint to get weather data for a specific city.
// The endpoint URL is /weather/{city}.
RouteHandlerBuilder routeHandlerBuilder = app.MapGet("/weather/{city}", handler: async (string city, IHttpClientFactory httpClientFactory) =>
{
    // The API Key and base URL for OpenWeatherMap.
    // NOTE: You must sign up for a free API key at https://openweathermap.org/api.
    // Replace "YOUR_API_KEY_HERE" with your actual key.
    const string apiKey = "YOUR_API_KEY_HERE";
    const string baseUrl = "https://api.openweathermap.org/data/2.5/weather";

    // Check if the requested city exists in our predefined dictionary.
    if (!cities.TryGetValue(city, out var coords))
    {
        return Results.NotFound(new { error = "City not found." });
    }

    // Construct the API URL with the coordinates, API key, and units.
    string requestUrl = $"{baseUrl}?lat={coords.Latitude}&lon={coords.Longitude}&appid={apiKey}&units=metric";

    try
    {
        // Create an HttpClient instance to make the external API call.
        var httpClient = httpClientFactory.CreateClient();
        var response = await httpClient.GetAsync(requestUrl);

        // Check if the response was successful.
        response.EnsureSuccessStatusCode();

        // Read the JSON content from the response.
        var jsonResponse = await response.Content.ReadAsStringAsync();

        // Deserialize the JSON to a dynamic object to easily access its properties.
        dynamic weatherData = System.Text.Json.JsonSerializer.Deserialize<object>(jsonResponse);

        // Extract the required information and create our custom WeatherReport object.
        var weatherReport = new WeatherReport(
            City: weatherData.name,
            Description: weatherData.weather[0].description,
            Temperature: weatherData.main.temp,
            FeelsLike: weatherData.main.feels_like,
            Humidity: weatherData.main.humidity,
            WindSpeed: weatherData.wind.speed,
            IconUrl: $"https://openweathermap.org/img/wn/{weatherData.weather[0].icon}@2x.png"
        );

        // Return the custom WeatherReport as JSON.
        return Results.Ok(weatherReport);
    }
    catch (HttpRequestException e)
    {
        // Handle cases where the external API call fails.
        return Results.Json(
     new { error = $"Error fetching weather data: {e.Message}" },
     statusCode: 500
 );

    }
});

// Run the application.
app.Run();

// Define a simple data model to represent the weather report.
// This is a record type for immutability and conciseness.
public record WeatherReport(
    string City,
    string Description,
    double Temperature,
    double FeelsLike,
    double Humidity,
    double WindSpeed,
    string IconUrl
);
