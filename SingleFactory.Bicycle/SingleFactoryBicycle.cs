using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleFactory.Bicycle;

public abstract class Bicycle
{
    protected string ModelName { get; init; }

    public void Build()
    {
        Console.WriteLine($"Building {ModelName} bicycle.");
    }
}

public class RoadBike : Bicycle
{
    public RoadBike()
    {
        ModelName = "Hillcrest";
    }
}

public class MountainBike : Bicycle
{
    public MountainBike()
    {
        ModelName = "Palo Duro Canyon Ranger";
    }

}

public class SimpleBicycleFactory
{
    public Bicycle CreateBicycle(string bicycleType)
    {
        Bicycle bikeToBuild;
        switch (bicycleType)
        {
            case "mountainbike":
                bikeToBuild = new MountainBike();
                break;
            case "roadbike":
                bikeToBuild = new RoadBike();
                break;
            default:
                throw new Exception("Unknown bicycle type: " + bicycleType);
        }
        return bikeToBuild;
    }
}