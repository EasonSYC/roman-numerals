using RomanNumerals.Classes;

namespace RomanNumerals;
internal class Program
{
    static void Main()
    {
        Console.WriteLine("Please input a Roman Numeral:");
        string input = Console.ReadLine() ?? string.Empty;
        RomanToIntegerNew converter = new RomanToIntegerNew();
        Console.WriteLine($"The integer is: {converter.ConvertRomanToInteger(input)} (if it is -1, it is invalid)");
    }

    private static void TestCases<T>() where T : IRomanToInteger, new()
    {
        IEnumerable<string> testCases = ["III", "IV", "IX", "XX", "XV", "IIII", "VX", "IIX", "VI", "XI", "XXI", "VVV"];

        T converter = new T();

        foreach (string testCase in testCases)
        {
            int result = converter.ConvertRomanToInteger(testCase);
            Console.WriteLine($"Roman: {testCase}, Integer: {result}");
        }
    }
}