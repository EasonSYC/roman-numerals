namespace RomanNumerals;
using RomanNumerals.Classes;

internal class Program
{
    static void Main()
    {
        string[] testCases = { "III", "IV", "IX", "XX", "XV", "IIII", "VX", "IIX", "VI", "XI", "XXI", "VVV" };

        foreach (var testCase in testCases)
        {
            int result = RomanToInteger.ConvertRomanToInteger(testCase);
            Console.WriteLine($"Roman: {testCase}, Integer: {result}");
        }
    }
}