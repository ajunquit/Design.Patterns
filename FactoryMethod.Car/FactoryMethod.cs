namespace FactoryMethod.Car;

public abstract class Car
{
    public abstract void Assemble();
}

public class ChevroletCar : Car
{
    public override void Assemble()
    {
        Console.WriteLine("Assembling a Chevrolet car.");
    }
}

public abstract class CarFactory
{
    public abstract Car CreateCar();
}

public class ChevroletFactory : CarFactory
{
    public override Car CreateCar()
    {
        return new ChevroletCar();
    }
}
