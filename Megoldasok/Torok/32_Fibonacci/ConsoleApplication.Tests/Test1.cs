namespace ConsoleApplication.Tests;

public class FibonacciCalculatorTests
{
    [Theory]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    [InlineData(2, 1)]
    [InlineData(3, 2)]
    [InlineData(4, 3)]
    [InlineData(5, 5)]
    [InlineData(6, 8)]
    [InlineData(19, 4181)]
    public void CalculateNthElement_Test(int input, int expected)
    {
        FibonacciCalculator.CalculateNthElement(input).Should().Be(expected);
    }
}
