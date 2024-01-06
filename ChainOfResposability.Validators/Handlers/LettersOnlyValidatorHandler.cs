using System.ComponentModel.DataAnnotations;

namespace ChainOfResponsability.Validators.Handlers;

public class LettersOnlyValidatorHandler : ValidatorHandler
{
    public override bool Validate(string input)
    {
        if (!string.IsNullOrEmpty(input) && !input.All(char.IsLetter))
        {
            Console.WriteLine("Validation failed: Input must contain only letters.");
            return false;
        }

        // If the validation passes, pass it to the next validator
        return successor is null || successor.Validate(input);
    }
}
