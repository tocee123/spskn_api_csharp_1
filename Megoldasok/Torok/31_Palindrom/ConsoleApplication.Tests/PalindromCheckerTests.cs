namespace ConsoleApplication.Tests;

public class PalindromCheckerTests
{
    [Theory]
    [InlineData("101", true)]
    [InlineData("1001", true)]
    [InlineData("apa", true)]
    [InlineData("alma", false)]
    public void IsPalindrom_WhenInputIsGiven_ReturnsExpected(string input, bool expected)
    {
        PalindromChecker.IsPalindrom(input).Should().Be(expected);
    }
}