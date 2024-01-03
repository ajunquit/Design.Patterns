using Strategy.Routes.Strategies;

namespace Strategy.Routes.Contexts;

public class Navigation
{
    private IRouteStrategy routeStrategy;

    public void SetRouteStrategy(IRouteStrategy routeStrategy)
    {
        this.routeStrategy = routeStrategy;
    }

    public void BuildRoute(string source, string destination)
    {
        if (routeStrategy is null)
        {
            throw new InvalidOperationException("Route strategy not set.");
        }

        this.routeStrategy.BuildStrategy(source, destination);
    }
}
