namespace Decorator.Coffee.Decorators;

public abstract class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }
    public virtual float GetCost()
    {
        return coffee.GetCost();
    }

    public virtual string GetDescription()
    {
        return coffee.GetDescription();
    }
}
