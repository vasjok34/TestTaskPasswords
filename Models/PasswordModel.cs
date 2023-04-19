namespace TestTaskPasswords.Models;

public class PasswordModel
{
    public PasswordModel(string password, char requiredSymbol, int minOccurrences, int maxOccurrences)
    {
        Password = password;
        RequiredSymbol = requiredSymbol;
        MinOccurrences = minOccurrences;
        MaxOccurrences = maxOccurrences;
    }

    public string Password { get; }
    public char RequiredSymbol { get; }
    public int MinOccurrences { get; }
    public int MaxOccurrences { get; }
}