namespace Strategy.Routes.Strategies;

public interface IRouteStrategy
{
    void BuildStrategy(string from, string destination);
}
