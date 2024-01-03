using Observer.WeatherStation.Observers;

namespace Observer.WeatherStation.Stations;

public interface IWeatherStation
{
    void AddObserver(IObserver observer);
    void RemoveObserver(IObserver observer);
    void NotifyObservers();
}