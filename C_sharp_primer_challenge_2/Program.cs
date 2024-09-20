public class Program
{
    public static void Main(string[] args)
    {
        // Example usage of WeatherData class
        WeatherData weather = new WeatherData(25, 50, 'C');
        Console.WriteLine($"Temperature: {weather.Temperature}°{weather.Scale}, Humidity: {weather.Humidity}%");

        weather.Convert();
        Console.WriteLine($"Converted Temperature: {weather.Temperature}°{weather.Scale}");
    }
}

public class WeatherData
{
    private double temperature;
    private int humidity;
    private char scale;

    public double Temperature
    {
        get { return temperature; }
        set
        {
            if ((scale == 'C' && (value < -60 || value > 60)) || (scale == 'F' && (value < -76 || value > 140)))
            {
                Console.WriteLine("A reading mistake must have been made since the value seems unrealistic.");
            }
            else
            {
                temperature = value;
            }
        }
    }

    public int Humidity
    {
        get { return humidity; }
        set
        {
            if (value < 0 || value > 100)
            {
                Console.WriteLine("Humidity must be between 0% and 100%.");
            }
            else
            {
                humidity = value;
            }
        }
    }

    public char Scale
    {
        get { return scale; }
        set
        {
            if (value == 'C' || value == 'F')
            {
                scale = value;
            }
            else
            {
                Console.WriteLine("Scale must be either 'C' or 'F'.");
            }
        }
    }

    public WeatherData(double temperature, int humidity, char scale)
    {
        Scale = scale; // Ensure scale is set before temperature
        Temperature = temperature;
        Humidity = humidity;
    }

    public void Convert()
    {
        if (scale == 'C')
        {
            temperature = (temperature * 9 / 5) + 32;
            scale = 'F';
        }
        else if (scale == 'F')
        {
            temperature = (temperature - 32) * 5 / 9;
            scale = 'C';
        }
    }
}
