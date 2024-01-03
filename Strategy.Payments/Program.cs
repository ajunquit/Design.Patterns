// Client code

// Create a shopping cart
using Strategy.Payments.Contexts;
using Strategy.Payments.Strategies;

ShoppingCart cart = new ShoppingCart();

// Set the payment strategy to Credit Card
cart.SetPaymentStrategy(new CreditCardPayment());

// Process payment
cart.Checkout(100.50f);

Console.WriteLine();

// Set the payment strategy to PayPal
cart.SetPaymentStrategy(new PayPalPayment());

// Process payment
cart.Checkout(75.25f);

Console.WriteLine();

// Set the payment strategy to Bank Transfer
cart.SetPaymentStrategy(new BankTransferPayment());

// Process payment
cart.Checkout(120.75f);