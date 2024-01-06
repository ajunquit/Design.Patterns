using ChainOfResponsability.Authentication.Dtos;

namespace ChainOfResponsability.Authentication.Handlers;

// abstract handler
public abstract class OrderHandler
{
    protected OrderHandler nextHandler;

    public void SetNextHandler(OrderHandler handler)
    {
        this.nextHandler = handler;
    }

    public abstract void ProcessOrder(OrderRequest request);
}
