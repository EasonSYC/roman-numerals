using RomanNumerals.Classes;

namespace RomanNumerals;
internal class Program
{
    static void Main()
    {
        string[] testCases = { "III", "IV", "IX", "XX", "XV", "IIII", "VX", "IIX", "VI", "XI", "XXI", "VVV" };

        IRomanToInteger converter = new RomanToInteger();

        foreach (string testCase in testCases)
        {
            int result = converter.ConvertRomanToInteger(testCase);
            Console.WriteLine($"Roman: {testCase}, Integer: {result}");
        }
    }
}