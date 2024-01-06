// Client code

// Create the chain of validators
using ChainOfResponsability.Validators.Handlers;

ValidatorHandler notEmptyValidator = new NotEmptyValidatorHandler();
ValidatorHandler lettersOnlyValidator = new LettersOnlyValidatorHandler();
ValidatorHandler emailValidator = new EmailValidatorHandler();

notEmptyValidator.SetSuccessor(lettersOnlyValidator);
lettersOnlyValidator.SetSuccessor(emailValidator);

// Perform validation
string validInput = "JohnDoe";
string emptyInput = "";
string invalidEmail = "john.doe@example"; // Missing top-level domain

Console.WriteLine("Validation for valid input:");
notEmptyValidator.Validate(validInput);

Console.WriteLine("\nValidation for empty input:");
notEmptyValidator.Validate(emptyInput);

Console.WriteLine("\nValidation for invalid email:");
notEmptyValidator.Validate(invalidEmail);