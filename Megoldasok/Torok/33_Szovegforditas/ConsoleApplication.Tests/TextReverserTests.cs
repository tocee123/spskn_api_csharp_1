namespace ConsoleApplication.Tests;
public class TextReverserTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void ReverseUsingForwardForCycle_Test(string input, string expected)
    {
        TextReverser.ReverseUsingForwardForCycle(input).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void ReverseUsingBackwardForCycle_Test(string input, string expected)
    {
        TextReverser.ReverseUsingBackwardForCycle(input).Should().Be(expected);
    }

    [Theory]
    [MemberData(nameof(Data))]
    public void ReverseUsingWhileCycle_Test(string input, string expected)
    {
        TextReverser.ReverseUsingWhileCycle(input).Should().Be(expected);
    }

    public static IEnumerable<object[]> Data = new object[][] {
        new[]{ "alma", "amla" },
        new[]{ "apple", "elppa" },
        new[]{"fizzy drink", "knird yzzif" }
    };
}