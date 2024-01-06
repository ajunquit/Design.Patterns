using Adapter.ElectricCharger.Adaptees;
using Adapter.ElectricCharger.Targets;

namespace Adapter.ElectricCharger.Adapters;

public class EUToUKAdapter (EuropeanCharger europeanCharger) : IUKSocket
{
    private readonly EuropeanCharger europeanCharger = europeanCharger;

    public void PlugIntoUKSocket()
    {
        europeanCharger.PlugIntoEUSocket();
    }
}
