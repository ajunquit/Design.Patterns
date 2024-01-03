namespace Strategy.Payments.Strategies;

public class PayPalPayment : IPaymentStrategy
{
    public void ProcessPayment(float amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount} dollars.");
        // Actual implementation for PayPal payment
    }
}
