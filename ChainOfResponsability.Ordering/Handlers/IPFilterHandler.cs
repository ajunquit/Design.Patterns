using ChainOfResponsability.Authentication.Dtos;

namespace ChainOfResponsability.Authentication.Handlers;

public class IPFilterHandler : OrderHandler
{
    public override void ProcessOrder(OrderRequest request)
    {
        if (!IsIPBlocked(request.IPAddress))
        {
            Console.WriteLine("Request allowed from IP address: " + request.IPAddress);
            nextHandler?.ProcessOrder(request);
        }
        else
        {
            Console.WriteLine("Request blocked from IP address: " + request.IPAddress);
        }
    }

    private bool IsIPBlocked(string ipAddress)
    {
        // IP filtering logic
        return ipAddress == "blocked_IP";
    }
}
