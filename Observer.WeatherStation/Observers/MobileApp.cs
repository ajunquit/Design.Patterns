namespace Observer.WeatherStation.Observers;

public class MobileApp : IObserver
{
    public string DeviceName { get; set; }
    public MobileApp(string deviceName)
    {
        DeviceName = deviceName;
    }
    public void Update(string message)
    {
        Console.WriteLine($"Mobile App '{DeviceName}' received weather update: {message}");
    }
}