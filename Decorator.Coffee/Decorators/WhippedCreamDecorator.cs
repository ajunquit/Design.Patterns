using Decorator.Coffee.Decorators;

namespace Decorator.Decorators;

public class WhippedCreamDecorator : CoffeeDecorator
{
    public WhippedCreamDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} + Whipped Cream";
    }

    public override float GetCost()
    {
        return coffee.GetCost() + 0.75f;
    }
}