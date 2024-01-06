using Adapter.DistanceInMeters.Targets;

namespace Adapter.DistanceInMeters.Adapters;

public class MetersToKilometesAdapter(Adaptees.DistanceInMeters distanceInMeters) : IDistance
{
    private readonly Adaptees.DistanceInMeters distanceInMeters = distanceInMeters;

    public double GetDistanceInKilometers()
    {
        return distanceInMeters.GetDistanceInMeters() / 1000.0;
    }
}
