using System.Text.RegularExpressions;

namespace RomanNumerals.Classes;
public partial class RomanToIntegerNew : IRomanToInteger
{
    private static readonly Dictionary<char, int> _romanMap = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10}
    };

    public int ConvertRomanToInteger(string roman)
    {
        roman = roman.ToUpper();
        if (!RegexMatch().IsMatch(roman))
        {
            return -1;
        }

        IEnumerable<int> numerals = roman.Select(x => _romanMap[x]);
        int length = numerals.Count(), number = 0;

        for (int i = 0; i < length; ++i)
        {
            if (i + 1 < length && numerals.ElementAt(i) < numerals.ElementAt(i + 1))
            {
                number -= numerals.ElementAt(i);
            }
            else
            {
                number += numerals.ElementAt(i);
            }
        }

        return number;
    }

    [GeneratedRegex("^X{0,3}(IX|IV|V?I{0,3})$")]
    private static partial Regex RegexMatch();
}
