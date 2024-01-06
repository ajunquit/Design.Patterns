namespace ChainOfResponsability.Validators.Handlers;

public class NotEmptyValidatorHandler : ValidatorHandler
{
    public override bool Validate(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Validation failed: Input cannot be empty");
            return false;
        }

        return successor is null || successor.Validate(input);
    }
}
