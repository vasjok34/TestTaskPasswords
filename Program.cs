// See https://aka.ms/new-console-template for more information

using TestTaskPasswords.Services;

const char AgreedRestartChar = 'y';
var validationService = new PasswordValidationService();

GetValidPasswordsCount(validationService);

Console.WriteLine("Completed");


void GetValidPasswordsCount(IPasswordValidationService passwordValidationService)
{
    Console.WriteLine("Please write txt file path:");

    var filePath = Console.ReadLine();

    Console.WriteLine(
        $"Count of valid passwords in file = {passwordValidationService.GetValidPasswordsCount(filePath)}");
    
    Console.WriteLine($"Another file? (Y - YES)");
    
    var input = char.Parse(Console.ReadLine()?.ToLower() ?? string.Empty);

    if (input == AgreedRestartChar)
    {
        GetValidPasswordsCount(passwordValidationService);
    }
}