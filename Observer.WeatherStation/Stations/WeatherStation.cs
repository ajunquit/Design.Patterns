using Observer.WeatherStation.Observers;

namespace Observer.WeatherStation.Stations;

public class WeatherStation : IWeatherStation
{
    private List<IObserver> Observers = new List<IObserver>();
    private string weatherMessage;
    public void AddObserver(IObserver observer)
    {
        Observers.Add(observer);
    }

    public void NotifyObservers()
    {
        foreach (var observer in Observers)
        {
            observer.Update(weatherMessage);

            // Simulation of updating the message to all subscribers
            Thread.Sleep(1000);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        Observers.Remove(observer);
    }

    public void SetWeatherUpdate(string update)
    {
        weatherMessage = update;
    }
}
