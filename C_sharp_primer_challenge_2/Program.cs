public class Program
{
    public static void Main(string[] args)
    {
        // Example usage of WeatherData class
        WeatherData weather = new WeatherData(30, 65, 'C');
        Console.WriteLine($"Temperature: {weather.Temperature}°{weather.Scale}, Humidity: {weather.Humidity}%");

        weather.Convert();
        Console.WriteLine($"Converted Temperature: {weather.Temperature}°{weather.Scale}");
    }
}
