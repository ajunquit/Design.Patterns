namespace Strategy.Payments.Strategies;

public interface IPaymentStrategy
{
    void ProcessPayment(float amount);
}
