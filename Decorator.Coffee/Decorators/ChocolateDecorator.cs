namespace Decorator.Coffee.Decorators;

public class ChocolateDecorator : CoffeeDecorator
{
    public ChocolateDecorator(ICoffee coffee) : base(coffee)
    {
    }

    public override float GetCost()
    {
        return coffee.GetCost() + 0.5f;
    }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} + Chocolate";
    }
}
