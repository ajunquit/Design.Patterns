using Adapter.Temperature.Targets;

namespace Adapter.Temperature.Client;

public class TemperatureClient
{
    public void DisplayTemperature(ICelsiusTemperature celsiusTemperature)
    {
        Console.WriteLine($"Temperature in Celsius: {celsiusTemperature.GetTemperatureInCelsius()}°C");
    }
}
