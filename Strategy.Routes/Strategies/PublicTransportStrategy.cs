namespace Strategy.Routes.Strategies;

public class PublicTransportStrategy : IRouteStrategy
{
    public void BuildStrategy(string from, string destination)
    {
        Console.WriteLine($"Public transport strategy from {from} to {destination}");
    }
}
