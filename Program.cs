// See https://aka.ms/new-console-template for more information

using TestTaskPasswords.Services;

const char AgreedRestartChar = 'y';
var validationService = new PasswordValidationService();

GetValidPasswordsCount(validationService);

Console.WriteLine("Completed");


void GetValidPasswordsCount(IPasswordValidationService passwordValidationService)
{
    Console.WriteLine("Please write valid txt file path:");

    var filePath = Console.ReadLine();

    if (!File.Exists(filePath))
    {
        Console.WriteLine($"File is not exists in path: {filePath}");

        GetValidPasswordsCount(passwordValidationService);
    }

    Console.WriteLine(
        $"Count of valid passwords in file = {passwordValidationService.GetValidPasswordsCount(filePath)}");

    Console.WriteLine("Another file? (Y - YES)");

    var input = char.Parse(Console.ReadLine()?.ToLower() ?? string.Empty);

    if (input == AgreedRestartChar)
    {
        GetValidPasswordsCount(passwordValidationService);
    }
}