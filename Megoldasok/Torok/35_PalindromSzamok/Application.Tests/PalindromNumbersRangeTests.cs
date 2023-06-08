namespace Application.Tests;

public class PalindromNumbersRangeTests
{
    [Theory]
    [InlineData(5,4)]
    [InlineData(-1, 4)]
    [InlineData(-1, -6)]
    public void GetPalindromNumbers_WhenBordersAreIncorrect_ExceptionIsThrown(int lowerBorder, int upperBorder)
    {
        Assert.Throws<BorderNotCorrectException>(() => PalindromNumbersRange.GetPalindromNumbers(lowerBorder, upperBorder));
    }
}
