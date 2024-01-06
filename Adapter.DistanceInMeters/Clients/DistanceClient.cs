using Adapter.DistanceInMeters.Adapters;
using Adapter.DistanceInMeters.Targets;

namespace Adapter.DistanceInMeters.Clients;

public class DistanceClient
{
    public void DisplayDistance(IDistance metersToKilometersAdapter)
    {
        Console.WriteLine($"Distance in Kilometers: {metersToKilometersAdapter.GetDistanceInKilometers()} km");
    }
}
