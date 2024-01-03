using Decorator.Coffee.Decorators;

namespace Decorator.Decorators;

// Concrete decorator classes for adding extras
public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee) { }

    public override string GetDescription()
    {
        return $"{coffee.GetDescription()} + Milk";
    }

    public override float GetCost()
    {
        return coffee.GetCost() + 0.99f;
    }
}