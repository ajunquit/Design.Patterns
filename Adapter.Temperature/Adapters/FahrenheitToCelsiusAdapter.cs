using Adapter.Temperature.Adaptees;
using Adapter.Temperature.Targets;

namespace Adapter.Temperature.Adapters;

public class FahrenheitToCelsiusAdapter(FahrenheitTemperature fahrenheitTemperature) : ICelsiusTemperature
{
    private readonly FahrenheitTemperature fahrenheitTemperature = fahrenheitTemperature;

    public double GetTemperatureInCelsius()
    {
        return (fahrenheitTemperature.GetTemperatureInFahrenheit() - 32) * 5 / 9;
    }
}
