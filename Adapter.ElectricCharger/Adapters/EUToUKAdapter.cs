using Adapter.ElectricCharger.Adaptees;
using Adapter.ElectricCharger.Targets;

namespace Adapter.ElectricCharger.Adapters;

public class EUToUKAdapter (EuropeanCharger europeanCharger) : IUKSocket
{

    public void PlugIntoUKSocket()
    {
        europeanCharger.PlugIntoEUSocket();
    }
}
