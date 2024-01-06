using ChainOfResponsability.Authentication.Dtos;

namespace ChainOfResponsability.Authentication.Handlers;

public class DataValidationHandler : OrderHandler
{
    public override void ProcessOrder(OrderRequest request)
    {

        // Data validation logic
        Console.WriteLine("Validating request data.");

        // Simply pass to the next handler
        nextHandler?.ProcessOrder(request);
    }
}
