namespace Adapter.DistanceInMeters.Adaptees;

public class DistanceInMeters(double meters)
{
    private readonly double meters = meters;

    public double GetDistanceInMeters() { return meters; }
}


