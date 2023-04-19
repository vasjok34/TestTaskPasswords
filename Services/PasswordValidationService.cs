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
        var passwordModels = passwordModelProvider.GetAllPasswordModelsFromFile(filePath);

        return passwordModels.Count(model => model.IsPasswordValid());
    }
}