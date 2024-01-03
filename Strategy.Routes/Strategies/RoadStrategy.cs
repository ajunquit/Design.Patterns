namespace Strategy.Routes.Strategies;

public class RoadStrategy : IRouteStrategy
{
    public void BuildStrategy(string from, string destination)
    {
        Console.WriteLine($"Road strategy from {from} to {destination}");
    }
}
