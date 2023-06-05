namespace ConsoleApplication.Tests;
public class TextReverserTests
{
    [Theory]
    [InlineData("alma", "amla")]
    public void ReverseUsingForCycle_Test(string input, string expected)
    {
        TextReverser.ReverseUsingForCycle(input).Should().Be(expected);
    }
}