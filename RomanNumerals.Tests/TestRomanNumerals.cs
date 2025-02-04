using RomanNumerals.Classes;

namespace RomanNumerals.Tests;
[TestClass]
public class TestRomanNumerals
{
    public static IEnumerable<object[]> ValidTestData
        => [
            ["I", 1],
            ["II", 2],
            ["III", 3],
            ["IV", 4],
            ["V", 5],
            ["VI", 6],
            ["VII", 7],
            ["VIII", 8],
            ["IX", 9],
            ["X", 10],
            ["XI", 11],
            ["XII", 12],
            ["XIII", 13],
            ["XIV", 14],
            ["XV", 15],
            ["XVI", 16],
            ["XVII", 17],
            ["XVIII", 18],
            ["XIX", 19],
            ["XX", 20]
        ];

    public static void ValidRomanNumerals<T>(string roman, int expected) where T : IRomanToInteger, new()
    {
        int result = new T().ConvertRomanToInteger(roman);
        Assert.AreEqual(expected, result);
    }

    public static IEnumerable<object[]> InvalidTestData
        => [
            ["IIII"],
            ["VV"],
            ["XXXX"],
            ["IVI"],
            ["VX"],
            ["XIXI"],
            ["IIX"],
            ["VVV"],
            ["VIV"],
            ["IXIX"],
            ["IXX"],
            ["IXI"],
            ["XXIXX"],
            ["IVIV"],
            ["IIV"],
            ["XVX"],
            ["VVVV"],
            ["VXI"],
            ["IIIII"],
            ["IIIIII"],
            ["VVVVVV"]
        ];

    public static void InvalidRomanNumerals<T>(string roman) where T : IRomanToInteger, new()
    {
        int result = new T().ConvertRomanToInteger(roman);
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    [DynamicData(nameof(ValidTestData))]
    public void TestRomanToIntegerValid(string roman, int expected) => ValidRomanNumerals<RomanToInteger>(roman, expected);

    [TestMethod]
    [DynamicData(nameof(InvalidTestData))]
    public void TestRomanToIntegerInvalid(string roman) => InvalidRomanNumerals<RomanToInteger>(roman);

    [TestMethod]
    [DynamicData(nameof(ValidTestData))]
    public void TestRomanToIntegerNewValid(string roman, int expected) => ValidRomanNumerals<RomanToIntegerNew>(roman, expected);

    [TestMethod]
    [DynamicData(nameof(InvalidTestData))]
    public void TestRomanToIntegerNewInvalid(string roman) => InvalidRomanNumerals<RomanToIntegerNew>(roman);
}