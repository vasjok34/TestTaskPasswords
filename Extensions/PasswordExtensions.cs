using TestTaskPasswords.Models;

namespace TestTaskPasswords.Extensions;

public static class PasswordExtensions
{
    public static bool IsPasswordValid(this PasswordModel passwordModel)
    {
        var occurrences = passwordModel.Password.Count(x => x == passwordModel.RequiredSymbol);

        return occurrences >= passwordModel.MinOccurrences && occurrences <= passwordModel.MaxOccurrences;
    }
}