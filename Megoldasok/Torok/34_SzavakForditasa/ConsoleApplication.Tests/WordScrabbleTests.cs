using FluentAssertions;

namespace ConsoleApplication.Tests
{
    public class WordScrabbleTests
    {
        [Theory]
        [InlineData("Géza szép az ég", "azéG pézs za gé")]
        public void Test1ReverseOnlyWords_WhenSentenceIsGiven_ReturnsExpected(string input, string expected)
        {
            WordScrabble.ReverseOnlyWords(input).Should().Be(expected);
        }
    }
}