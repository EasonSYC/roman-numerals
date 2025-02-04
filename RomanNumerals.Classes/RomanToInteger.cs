namespace RomanNumerals.Classes;

public class RomanToInteger : IRomanToInteger
{
    private static readonly Dictionary<char, int> _romanMap = new()
    {
        {'I', 1},
        {'V', 5},
        {'X', 10}
    };

    public int ConvertRomanToInteger(string roman)
    {
        int number = 0;
        int length = roman.Length;
        List<int> romanArray = [];

        foreach (char cc in roman)
        {
            if (!_romanMap.TryGetValue(cc, out int value)) // invalid symbol
            {
                return -1;
            }

            romanArray.Add(value);
        }

        for (int i = 0; i < length; i++)
        {
            if (i + 1 < length && romanArray[i] == 5 && romanArray[i + 1] == 5) // two Vs
            {
                return -1;
            }

            if (i + 3 < length && romanArray[i] == romanArray[i + 1] && romanArray[i] == romanArray[i + 2] && romanArray[i] == romanArray[i + 3] && (romanArray[i] == 1 || romanArray[i] == 10)) // three Is, three Xs
            {
                return -1;
            }

            if (i + 1 < length && romanArray[i] < romanArray[i + 1] && romanArray[i] == 5) // incorrect subtraction V
            {
                return -1;
            }

            if (i - 1 >= 0 && i + 1 < length && romanArray[i] < romanArray[i + 1] && romanArray[i] == 1 && romanArray[i - 1] == 1) // incorrect subtraction 2Is
            {
                return -1;
            }

            if (i + 2 < length && romanArray[i] < romanArray[i + 1] && romanArray[i + 1] >= romanArray[i + 2]) // incorrect subtraction 'hill peak'
            {
                return -1;
            }

            if (i + 1 < length && romanArray[i] < romanArray[i + 1])
            {
                number -= romanArray[i];
            }
            else
            {
                number += romanArray[i];
            }
        }

        return number;
    }
}
