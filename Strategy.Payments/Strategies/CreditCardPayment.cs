namespace Strategy.Payments.Strategies;

public class CreditCardPayment : IPaymentStrategy
{
    public void ProcessPayment(float amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount} dollars.");
        // Actual implementation for credit card payment
    }
}
