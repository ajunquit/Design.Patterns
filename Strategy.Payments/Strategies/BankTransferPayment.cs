namespace Strategy.Payments.Strategies;

public class BankTransferPayment : IPaymentStrategy
{
    public void ProcessPayment(float amount)
    {
        Console.WriteLine($"Processing bank transfer payment of {amount} dollars.");
        // Actual implementation for bank transfer payment
    }
}
