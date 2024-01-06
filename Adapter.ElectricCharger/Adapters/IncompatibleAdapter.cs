using Adapter.ElectricCharger.Targets;

namespace Adapter.ElectricCharger.Adapters;

internal class IncompatibleAdapter : IUKSocket
{
    public void PlugIntoUKSocket()
    {
        Console.WriteLine("Incompatible adapter cannot plug into UK socket.");
    }
}
