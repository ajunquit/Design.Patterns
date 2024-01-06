namespace Adapter.Temperature.Adaptees;

public class FahrenheitTemperature(double temperature)
{
    private readonly double temperature = temperature;
    public double GetTemperatureInFahrenheit()
    {
        return temperature;
    }
}
