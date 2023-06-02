namespace ConsoleApplication.Tests;

public class PalindromCheckerTests
{
    [Fact]
    public void IsPalindrom_WhenInputIsGiven_ReturnsExpected(string input, bool expected)
    {
        PalindromChecker.IsPalindrom(input).Should().Be(expected);
    }
}
