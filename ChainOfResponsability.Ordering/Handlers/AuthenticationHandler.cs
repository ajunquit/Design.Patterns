using ChainOfResponsability.Authentication.Dtos;

namespace ChainOfResponsability.Authentication.Handlers;

// concrete handler - authentication
public class AuthenticationHandler : OrderHandler
{
    public override void ProcessOrder(OrderRequest request)
    {
        if (AuthenticateUser(request.Credentials))
        {
            Console.WriteLine("User authenticated successfully.");
            nextHandler?.ProcessOrder(request);
        }
        else
        {
            Console.WriteLine("Authentication error. Access denied.");
        }
    }

    private bool AuthenticateUser(string credentials)
    {
        // Authentication logic
        return credentials == "valid_credentials";
    }
}
