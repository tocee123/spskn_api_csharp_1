using Xunit.Abstractions;

namespace Application.Tests;

public class PalindromNumbersRangeTests
{
    private ITestOutputHelper _output;

    public PalindromNumbersRangeTests(ITestOutputHelper output)
    {
        _output = output;
    }

    [Theory]
    [InlineData(5,4)]
    [InlineData(-1, 4)]
    [InlineData(-1, -6)]
    public void GetPalindromNumbers_WhenBordersAreIncorrect_ExceptionIsThrown(int lowerBorder, int upperBorder)
    {
        Assert.Throws<BorderNotCorrectException>(() => PalindromNumbersRange.GetPalindromNumbers(lowerBorder, upperBorder));
    }

    [Theory]
    [InlineData(100,102,1)]
    [InlineData(100, 200, 10)]
    public void GetPalindromNumbers_WhenBordersAreCorrect_ReturnsExpectedCount(int lowerBorder, int upperBorder, int expectedCount)
    {
        var palindroms = PalindromNumbersRange.GetPalindromNumbers(lowerBorder, upperBorder);
        palindroms.Count().Should().Be(expectedCount);
        _output.WriteLine(string.Join("\n", palindroms));
    }
}
