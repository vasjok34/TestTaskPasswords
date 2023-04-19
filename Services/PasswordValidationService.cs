using TestTaskPasswords.Extensions;
using TestTaskPasswords.Providers;

namespace TestTaskPasswords.Services;

public class PasswordValidationService : IPasswordValidationService
{
    private readonly IPasswordModelProvider passwordModelProvider;
    
    public PasswordValidationService()
    {
        passwordModelProvider = new PasswordModelProvider();
    }
    
    public int GetValidPasswordsCount(string filePath)
    {
        var validPasswordsCount = 0;
        var passwordModels = passwordModelProvider.GetAllPasswordModelsFromFile(filePath);
        foreach (var model in passwordModels)
        {
            if (model.IsPasswordValid())
            {
                validPasswordsCount++;
            }
        }

        return validPasswordsCount;
    }
}