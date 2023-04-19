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

    public string Password { get; set; }
    public char RequiredSymbol { get; set; }
    public int MinOccurrences { get; set; }
    public int MaxOccurrences { get; set; }
}