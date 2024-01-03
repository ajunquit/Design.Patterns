namespace Observer.WeatherStation.Observers;

public class OutdoorDisplay : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Received: {message}");
    }
}
