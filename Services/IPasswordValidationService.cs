namespace TestTaskPasswords.Services;

public interface IPasswordValidationService
{
    public int GetValidPasswordsCount(string filePath);
}