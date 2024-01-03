namespace Decorator.Coffee.Decorators;

public class BasicCoffee : ICoffee
{
    public float GetCost()
    {
        return 2.99f;
    }

    public string GetDescription()
    {
        return "Basic Coffee";
    }
}
