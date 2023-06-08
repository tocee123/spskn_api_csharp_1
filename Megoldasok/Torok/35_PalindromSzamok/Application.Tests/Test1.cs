namespace Application.Tests;

public class PalindromNumberCheckerTests
{
    [Theory]
    [InlineData(101, true)]
    [InlineData(454, true)]
    [InlineData(111, true)]
    [InlineData(44, true)]
    [InlineData(987, false)]
    [InlineData(1010, false)]
    [InlineData(1001, true)]
    public void IsPalindrom_WhenInputIsGiven_ReturnsExpected(int input, bool expected)
    {
        PalindromNumberChecker.IsPalindrom(input).Should().Be(expected);
    }
}