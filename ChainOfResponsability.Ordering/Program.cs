// Client code

// Configuring the chain of responsibility
using ChainOfResponsability.Authentication.Dtos;
using ChainOfResponsability.Authentication.Handlers;

OrderHandler authenticationHandler = new AuthenticationHandler();
OrderHandler dataValidationHandler = new DataValidationHandler();
OrderHandler ipFilterHandler = new IPFilterHandler();
OrderHandler cacheHandler = new CacheHandler();

authenticationHandler.SetNextHandler(dataValidationHandler);
dataValidationHandler.SetNextHandler(ipFilterHandler);
ipFilterHandler.SetNextHandler(cacheHandler);

// Simulating requests
OrderRequest request1 = new OrderRequest
{
    Credentials = "valid_credentials",
    RequestData = "Request data 1",
    IPAddress = "allowed_IP"
};

OrderRequest request2 = new OrderRequest
{
    Credentials = "invalid_credentials",
    RequestData = "Request data 2",
    IPAddress = "blocked_IP"
};

authenticationHandler.ProcessOrder(request1);

Console.WriteLine("\n---\n");

authenticationHandler.ProcessOrder(request2);