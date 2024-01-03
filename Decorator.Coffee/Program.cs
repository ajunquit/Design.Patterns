using Decorator.Coffee.Decorators;
using Decorator.Decorators;

// Order a plain coffee

ICoffee coffee = new BasicCoffee();
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add milk to the coffee
coffee = new MilkDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add whipped cream
coffee = new WhippedCreamDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

// Add chocolate
coffee = new ChocolateDecorator(coffee);
Console.WriteLine($"Order: {coffee.GetDescription()}, Cost: ${coffee.GetCost()}");

Console.ReadLine();