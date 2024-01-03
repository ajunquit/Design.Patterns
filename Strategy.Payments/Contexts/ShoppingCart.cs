using Strategy.Payments.Strategies;

namespace Strategy.Payments.Contexts;

// context
public class ShoppingCart
{
    private IPaymentStrategy _paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this._paymentStrategy = paymentStrategy;
    }

    public void Checkout(float amount)
    {
        if (_paymentStrategy is null)
        {
            throw new InvalidOperationException("Payment strategy not set.");
        }

        this._paymentStrategy.ProcessPayment(amount);
    }

}
