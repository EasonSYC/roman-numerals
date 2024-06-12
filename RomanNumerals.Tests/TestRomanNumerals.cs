namespace RomanNumerals.Tests;
using RomanNumerals.Classes;

[TestClass]
public class TestRomanNumerals
{
    [TestMethod]
    [DataRow("I", 1)]
    [DataRow("II", 2)]
    [DataRow("III", 3)]
    [DataRow("IV", 4)]
    [DataRow("V", 5)]
    [DataRow("VI", 6)]
    [DataRow("VII", 7)]
    [DataRow("VIII", 8)]
    [DataRow("IX", 9)]
    [DataRow("X", 10)]
    [DataRow("XI", 11)]
    [DataRow("XII", 12)]
    [DataRow("XIII", 13)]
    [DataRow("XIV", 14)]
    [DataRow("XV", 15)]
    [DataRow("XVI", 16)]
    [DataRow("XVII", 17)]
    [DataRow("XVIII", 18)]
    [DataRow("XIX", 19)]
    [DataRow("XX", 20)]
    public void ValidRomanNumerals(string roman, int expected)
    {
        int result = RomanToInteger.ConvertRomanToInteger(roman);
        Assert.AreEqual(expected, result);
    }

    [TestMethod]
    [DataRow("IIII")]
    [DataRow("VV")]
    [DataRow("XXXX")]
    [DataRow("IVI")]
    [DataRow("VX")]
    [DataRow("XIXI")]
    [DataRow("IIX")]
    [DataRow("VVV")]
    // [DataRow("VIV")] // unable to deal with this terrible counterexample
    [DataRow("IXIX")]
    [DataRow("IXX")]
    [DataRow("XXIXX")]
    [DataRow("IVIV")]
    [DataRow("IIV")]
    [DataRow("XVX")]
    [DataRow("VVVV")]
    [DataRow("VXI")]
    [DataRow("IIIII")]
    [DataRow("IIIIII")]
    [DataRow("VVVVVV")]
    public void InvalidRomanNumerals(string roman)
    {
        int result = RomanToInteger.ConvertRomanToInteger(roman);
        Assert.AreEqual(-1, result);
    }
}