namespace ChainOfResponsability.Validators.Handlers;

public class EmailValidatorHandler : ValidatorHandler
{
    public override bool Validate(string input)
    {
        if (!string.IsNullOrEmpty(input) && !IsValidEmail(input))
        {
            Console.WriteLine("Validation failed: Invalid email address.");
            return false;
        }

        // If the validation passes, pass it to the next validator
        return successor is null || successor.Validate(input);
    }

    private bool IsValidEmail(string email)
    {
        // Basic email validation logic (for demonstration purposes)
        return email.Contains("@") && email.Contains(".");
    }
}
