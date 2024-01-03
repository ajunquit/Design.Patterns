namespace Strategy.Routes.Strategies;

public class WalkingStrategy : IRouteStrategy
{
    public void BuildStrategy(string from, string destination)
    {
        Console.WriteLine($"Walking strategy from {from} to {destination}");
    }
}
