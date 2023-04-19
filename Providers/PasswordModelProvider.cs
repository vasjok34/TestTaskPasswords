using System.Text.RegularExpressions;
using TestTaskPasswords.Models;

namespace TestTaskPasswords.Providers;

public class PasswordModelProvider : IPasswordModelProvider
{
    private const string NumbersRegexPattern = @"\D+";
    private const char ColonChar = ':';

    public IEnumerable<PasswordModel> GetAllPasswordModelsFromFile(string filePath)
    {
        var lines = File.ReadAllLines(filePath);

        return lines.Select(BuildPasswordModel).ToList();
    }

    private static PasswordModel BuildPasswordModel(string lineOfFile)
    {
        var requiredChar = lineOfFile.First();
        var quantities = GetQuantities(lineOfFile);

        var minQuantity = quantities[0];
        var maxQuantity = quantities[1];

        var possiblePassword = lineOfFile.Substring(lineOfFile.LastIndexOf(ColonChar) + 1).Replace(" ", string.Empty);

        return new PasswordModel(possiblePassword, requiredChar, minQuantity, maxQuantity);
    }

    private static int[] GetQuantities(string line)
    {
        var quantitiesArray = new int[2];
        var index = 0;
        var matchResult = Regex.Split(line, NumbersRegexPattern);

        foreach (var value in matchResult)
            if (!string.IsNullOrEmpty(value))
            {
                quantitiesArray[index] = int.Parse(value);
                index++;
            }

        return quantitiesArray;
    }
}