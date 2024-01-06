using ChainOfResponsability.Authentication.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsability.Authentication.Handlers;

public class CacheHandler : OrderHandler
{
    public override void ProcessOrder(OrderRequest request)
    {
        // Response caching logic
        Console.WriteLine("Checking response cache.");

        // Simply pass to the next handler
        nextHandler?.ProcessOrder(request);
    }
}
