using TestTaskPasswords.Models;

namespace TestTaskPasswords.Providers;

public interface IPasswordModelProvider
{
    public IEnumerable<PasswordModel> GetAllPasswordModelsFromFile(string filePath);
}